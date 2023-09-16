using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavegameToolkit
{
    internal class ChunkedStore : IConversionSupport
    {
        internal struct ChunkInfo
        {
            public int ArchiveIndex { get; private set; }
            public long ArchiveOffset { get; private set; }
            public long Unknown { get; private set; }
            public long Size { get; private set; }

            internal static ChunkInfo ReadBinary(ArkArchive archive)
            {
                ChunkInfo result = new ChunkInfo();
                result.ArchiveIndex = archive.ReadInt();
                result.ArchiveOffset = archive.ReadLong();
                result.Unknown = archive.ReadLong();
                result.Size = archive.ReadLong();
                return result;
            }
        }

        public long TotalIndexSize { get; private set; }
        public long TotalDataSize { get; private set; }
        public List<ChunkInfo> IndexChunks { get; private set; }
        public List<ChunkInfo> DataChunks { get; private set; }

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            bool versioned = archive.ReadInt() == -1;
            int version = archive.ReadInt();
            if (!versioned || version != 2)
            {
                throw new NotSupportedException("Only version 2 ChunkedStores can be read.");
            }

            (TotalDataSize, DataChunks) = _readChunkChain(archive, 1);
            (TotalIndexSize, IndexChunks) = _readChunkChain(archive, 24);

            // TODO: seems to be a map<ID, Object>.
            // TODO: each index entry looks to be 64-bit ID + 64-bit offset (relative to data buffer start) + 64-bit
            // TODO: sub-buffer size.
            // TODO: handle the chunking, read the tribe/player data, and should be good.
        }

        private Tuple<long, List<ChunkInfo>> _readChunkChain(ArkArchive archive, int elementSize)
        {
            List<ChunkInfo> results = new List<ChunkInfo>();

            long totalSize = archive.ReadLong() * elementSize;
            long bytesRemaining = totalSize;
            while (bytesRemaining > 0)
            {
                ChunkInfo chunk = ChunkInfo.ReadBinary(archive);
                bytesRemaining -= chunk.Size;
                results.Add(chunk);
            }

            return new Tuple<long, List<ChunkInfo>>(totalSize, results);
        }

    }
}
