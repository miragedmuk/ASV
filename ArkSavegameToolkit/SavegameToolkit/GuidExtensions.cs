using System;
using System.Collections.Generic;

namespace SavegameToolkit {

    // todo

    /// <summary>
    /// Order the binary data in a way that corresponds to the Java version's reading implementation,
    /// but that might be wrong in the Java version. However the GUID is not used for reference or so,
    /// so it doesn't really matter.
    /// Background: the binary format / order of the bytes is different when C# or Java writes GUIDs/UUIDs.
    /// </summary>
    public static class GuidExtensions {
        private static readonly Dictionary<int, int> translation = new Dictionary<int, int> {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 6 },
                { 5, 7 },
                { 6, 4 },
                { 7, 5 },
                { 8, 11 },
                { 9, 10 },
                { 10, 9 },
                { 11, 8 },
                { 12, 15 },
                { 13, 14 },
                { 14, 13 },
                { 15, 12 }
        };

        public static byte[] ToBytes(this Guid guid) {
            byte[] bytes = guid.ToByteArray();

            byte[] result = new byte[16];

            foreach (KeyValuePair<int, int> pair in translation) {
                result[pair.Key] = bytes[pair.Value];
            }

            return result;
        }

        public static Guid ToGuid(this byte[] bytes) {
            byte[] temp = new byte[16];

            foreach (KeyValuePair<int, int> pair in translation) {
                temp[pair.Value] = bytes[pair.Key];
            }

            return new Guid(temp);
        }
    }

}
