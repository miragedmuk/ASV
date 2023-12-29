using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    public class ArkArchive : IDisposable {
        private static readonly NameSizeCalculator tableWithInstance = name => 4;
        private static readonly NameSizeCalculator tableWithoutInstance = name => 8;
        private static readonly NameSizeCalculator withoutTable = name => GetStringLength(name.ToString());

        private const bool reportLargeStrings = true;

        private const int bufferSize = 4096;

        private readonly long totalOffset;

        private readonly Stream mbb;
        private readonly BinaryReader mbbReader;

        public List<string> NameTable { get; private set; }

        public bool HasNameTable => NameTable != null;

        public bool HasInstanceInNameTable { get; private set; }

        private Dictionary<string, int> nameMap;

        private int nameOffset;

        private readonly ArkArchiveState state;

        private readonly char[] smallCharBuffer = new char[bufferSize];

        private readonly byte[] smallByteBuffer = new byte[bufferSize];
        
        public short SaveVersion { get; internal set; } = 1;

        /// <summary>
        /// Enable or disable the current nameTable
        /// </summary>
        public bool UseNameTable { get; set; } = true;

        private readonly bool isSlice;

        public ArkArchive(Stream stream) {
            mbb = stream;
            mbbReader = new BinaryReader(mbb);
            state = new ArkArchiveState();
            isSlice = false;
            totalOffset = 0;
        }

        private ArkArchive(ArkArchive toClone) {
            throw new NotImplementedException("Broken feature");
#pragma warning disable 162
            mbb = new MemoryStream();
            toClone.mbb.CopyTo(mbb);
            NameTable = toClone.NameTable;
            nameMap = toClone.nameMap;
            nameOffset = toClone.nameOffset;
            HasInstanceInNameTable = toClone.HasInstanceInNameTable;
            state = toClone.state;
            isSlice = toClone.isSlice;
            totalOffset = toClone.totalOffset;
#pragma warning restore 162
        }

        private ArkArchive(ArkArchive toClone, int size) {
            if (toClone.mbb.Position + size > toClone.mbb.Length) {
                toClone.DebugMessage($"Requesting {size} bytes with only {toClone.mbb.Length - toClone.mbb.Position} bytes available");
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            totalOffset = toClone.totalOffset + toClone.mbb.Position;
            mbb = new MemoryStream(toClone.mbbReader.ReadBytes(size));
            mbbReader = new BinaryReader(mbb);
            state = toClone.state;
            isSlice = true;
            SaveVersion = toClone.SaveVersion;
        }

        public ArkArchive Clone() => new ArkArchive(this);

        public ArkArchive Slice(int size) => new ArkArchive(this, size);

        public void SetNameTable(List<string> nameTable, int offset = 1, bool instanceInTable = false) {
            if (nameTable != null) {
                NameTable = nameTable.ToList();
                nameOffset = offset;
                HasInstanceInNameTable = instanceInTable;
                Dictionary<string, int> nameMapBuilder = new Dictionary<string, int>();

                int index = offset;

                foreach (string name in nameTable) {
                    nameMapBuilder[name] = index++;
                }

                nameMap = nameMapBuilder.ToDictionary(pair => pair.Key, pair => pair.Value);
            } else {
                NameTable = null;
                nameMap = null;
            }
        }

        public long Position {
            get => mbb.Position;
            set => mbb.Position = value;
        }

        private long totalPosition => totalOffset + mbb.Position;

        public long Limit => mbb.Length;

        public void SkipString() {
            int size = mbbReader.ReadInt32();

            bool multibyte = size < 0;
            int absSize = Math.Abs(size);
            int readSize = multibyte ? absSize * 2 : absSize;

            if (readSize + mbb.Position > mbb.Length) {
                DebugMessage($"Trying to skip {readSize} bytes with just {mbb.Length - mbb.Position} bytes left");
                throw new IndexOutOfRangeException();
            }

            if (absSize > bufferSize && reportLargeStrings) {
                DebugMessage($"String ({absSize}) larger than internal Buffer ({bufferSize})");
            }

            mbb.Seek(readSize, SeekOrigin.Current);
        }

        public void SkipBytes(int count) {
            if (count + mbb.Position > mbb.Length) {
                DebugMessage($"Trying to skip {count} bytes with just {mbb.Length - mbb.Position} bytes left");
                throw new IndexOutOfRangeException();
            }

            if (count + mbb.Position < 0) {
                DebugMessage($"Trying to unskip {count} bytes with just {mbb.Position} bytes left");
                throw new IndexOutOfRangeException();
            }

            mbb.Seek(count, SeekOrigin.Current);
        }

        #region read data

        public string ReadString() {
            int size = mbbReader.ReadInt32();

            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (size) {
                case 0:
                    return null;
                case 1:
                    mbb.Seek(1, SeekOrigin.Current);
                    return string.Empty;
                case -1:
                    mbb.Seek(2, SeekOrigin.Current);
                    return string.Empty;
            }

            bool multibyte = size < 0;
            int absSize = Math.Abs(size);
            int readSize = multibyte ? absSize * 2 : absSize;

            if (readSize + mbb.Position > mbb.Length) {
                DebugMessage($"Trying to read {readSize} bytes with just {mbb.Length - mbb.Position} bytes left");
                throw new IndexOutOfRangeException();
            }

            bool isLarge = readSize > bufferSize;

            if (isLarge && reportLargeStrings) {
                DebugMessage($"String ({absSize}) larger than internal Buffer ({bufferSize})");
            }

            if (multibyte) {
                byte[] buffer = isLarge ? new byte[readSize] : smallByteBuffer;
                mbbReader.Read(buffer, 0, readSize);
                return Encoding.Unicode.GetString(buffer, 0, readSize - 2);
            } else {
                byte[] buffer = isLarge ? new byte[absSize] : smallByteBuffer;
                mbb.Read(buffer, 0, absSize);

                return Encoding.ASCII.GetString(buffer, 0, absSize - 1);
            }
        }

        public ArkName ReadName() {
            if (!HasNameTable || !UseNameTable) {
                return ArkName.From(ReadString());
            }

            return readNameFromTable();
        }

        private ArkName readNameFromTable() {
            try 
            {
                int id = mbbReader.ReadInt32();
                int internalId = id - nameOffset;



                if (internalId < 0 || internalId >= NameTable.Count)
                {
                    DebugMessage($"Found invalid nametable index {id} ({internalId})", -4);
                    return null;
                }

                string name = NameTable[internalId];
                if (HasInstanceInNameTable)
                {
                    return ArkName.From(name);
                }

                int instance = mbbReader.ReadInt32();

                // Get or create ArkName
                return ArkName.From(name, instance);
            }
            catch
            {
                return ArkName.NameNone;
            }
            
        }

        public float ReadFloat() {
            return mbbReader.ReadSingle();
        }

        public int ReadInt() {
            return mbbReader.ReadInt32();
        }

        public short ReadShort() {
            return mbbReader.ReadInt16();
        }

        public long ReadLong() {
            return mbbReader.ReadInt64();
        }

        public double ReadDouble() {
            return mbbReader.ReadDouble();
        }

        public byte ReadByte() {
            return mbbReader.ReadByte();
        }

        public sbyte ReadSByte() {
            return mbbReader.ReadSByte();
        }

        public byte[] ReadBytes(int length) {
            return mbbReader.ReadBytes(length);
        }

        public bool ReadBool() {
            int val = mbbReader.ReadInt32();
            if (val < 0 || val > 1) {
                DebugMessage($"bool with value {val}, returning true", -4);
            }
            return val != 0;
        }

        #endregion


        /// <summary>
        /// Indicates that some data couldn't be read.
        /// </summary>
        /// <returns>true if some data has been lost</returns>
        public bool HasUnknownData {
            get => state.unknownData;
            set {
                if (value == false)
                    throw new ArgumentOutOfRangeException(nameof(value), "Only setting to true is allowed");
                state.unknownData = true;
            }
        }

        /// <summary>
        /// Indicates that there might be unknown references to some names. If the current file has to be
        /// written back to disk this should be considered by keeping all old names and adding new names to
        /// the end of the list.
        /// 
        /// Returns true if there are unknown names.
        /// </summary>
        public bool HasUnknownNames {
            get => state.unknownNames;

            set {
                // Set the unknownNames flag to true, except for slices.
                // Slices have either their own nameTable or no nameTable at all.
                if (value == false)
                    throw new ArgumentOutOfRangeException(nameof(value), "Only setting to true is allowed");
                if (isSlice) {
                    state.unknownData = true;
                } else {
                    state.unknownNames = true;
                }
            }
        }

        public void DebugMessage(string message, int offset = 0) {
            if (!Debugger.IsAttached)
                return;
            Debug.Write($"{message} at 0x{mbb.Position + offset:X4}");
            Debug.WriteIf(totalOffset > 0, $" (0x{totalPosition + offset:X4})");
            Debug.WriteLine(string.Empty);
        }

        /// <summary>
        /// Determines how many bytes <code>value</code> will need if written to disk.
        /// </summary>
        /// <param name="value">The string to get the size of</param>
        /// <returns>The amount of bytes needed to store <code>value</code></returns>
        
        public static int GetStringLength(string value) {
            if (value == null) {
                return 4;
            }
            if (string.IsNullOrEmpty(value)) {
                return 5;
            }
            int length = value.Length + 1;

            return (isMultibyte(value) ? length * 2 : length) + 4;
        }

        public NameSizeCalculator GetNameSizer() {
            return GetNameSizer(NameTable != null && UseNameTable, HasInstanceInNameTable);
        }

        public static NameSizeCalculator GetNameSizer(bool nameTable, bool instanceInTable = false) {
            return nameTable ? (instanceInTable ? tableWithInstance : tableWithoutInstance) : withoutTable;
        }

        private static bool isMultibyte(string value) {
            return value.Any(c => c > '\u007f');
        }

        #region IDisposable

        public void Dispose() {
            mbb?.Dispose();
            mbbReader?.Dispose();
        }

        #endregion
    }

}
