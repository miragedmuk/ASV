using AsaSavegameToolkit.Types;
using System.Text;

namespace AsaSavegameToolkit
{
    public class AsaArchive : IDisposable
    {
        private const int bufferSize = 4096;
        private readonly byte[] smallByteBuffer = new byte[bufferSize];

        private readonly Stream mbb;
        private readonly BinaryReader mbbReader;


        public Dictionary<int,string> ConstantNameTable { get; set; } = new Dictionary<int,string>();
        public Dictionary<int, string> NameTable { get; set; } = new Dictionary<int, string>();
        public bool HasNameTable => (NameTable != null && NameTable.Count > 0) || (ConstantNameTable!=null && ConstantNameTable.Count > 0);
        public bool HasInstanceInNameTable { get; private set; }

        public long Position
        {
            get => mbb.Position;
            set => mbb.Position = value;
        }

        public long Limit => mbb.Length;

        public short SaveVersion { get; internal set; }

        public AsaArchive(Stream stream)
        {
            mbb = stream;
            mbbReader = new BinaryReader(mbb);
        }

        #region read data

        public void SkipBytes(int count)
        {

            mbb.Seek(count, SeekOrigin.Current);
        }

        public string ReadString()
        {
            int size = mbbReader.ReadInt32();

            switch (size)
            {
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

            if (readSize + mbb.Position > mbb.Length)
            {
                throw new IndexOutOfRangeException();
            }

            bool isLarge = readSize > bufferSize;


            if (multibyte)
            {
                byte[] buffer = isLarge ? new byte[readSize] : smallByteBuffer;
                mbbReader.Read(buffer, 0, readSize);
                return Encoding.Unicode.GetString(buffer, 0, readSize - 2);
            }
            else
            {
                byte[] buffer = isLarge ? new byte[absSize] : smallByteBuffer;
                mbb.Read(buffer, 0, absSize);

                return Encoding.ASCII.GetString(buffer, 0, absSize - 1);
            }
        }

        public AsaName ReadName()
        {
            if (!HasNameTable)
            {
                return AsaName.From(ReadString());
            }

            return readNameFromTable();
        }

        private AsaName readNameFromTable()
        {
            int id = mbbReader.ReadInt32();
            string name = string.Empty;
            if(NameTable.ContainsKey(id)) 
            {
                name = NameTable[id];
            }
            else
            {
                if (ConstantNameTable.Count > 0)
                {
                    if (ConstantNameTable.ContainsKey(id))
                    {
                        name = ConstantNameTable[id];
                    }
                    else
                    {
                        name = string.Concat("Unknown_", id);
                    }                    
                }
                else
                {
                    return null;
                }
            }

            if (HasInstanceInNameTable)
            {
                return AsaName.From(name);
            }

            int instance = mbbReader.ReadInt32();

            // Get or create AsaName
            return AsaName.From(name, instance);
        }

        public float ReadFloat()
        {
            return mbbReader.ReadSingle();
        }

        public int ReadInt()
        {
            return mbbReader.ReadInt32();
        }

        public uint ReadUInt()
        {
            return mbbReader.ReadUInt32();
        }

        public short ReadShort()
        {
            return mbbReader.ReadInt16();
        }

        public long ReadLong()
        {
            return mbbReader.ReadInt64();
        }

        public double ReadDouble()
        {
            return mbbReader.ReadDouble();
        }

        public byte ReadByte()
        {
            return mbbReader.ReadByte();
        }

        public byte[] ReadBytes(int length)
        {
            return mbbReader.ReadBytes(length);
        }

        public bool ReadBool()
        {
            int val = mbbReader.ReadInt32();
            return val != 0;
        }


        public string ReadStringStored()
        {
            int length = ReadByte();
            SkipBytes(1);
            return UTF8Encoding.UTF8.GetString(ReadBytes(length - 1));
           
        }

        #endregion read data


        public void Dispose()
        {
            mbb?.Dispose();
            mbbReader?.Dispose();
        }

    }
}
