using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit
{
    internal class AsaTribeStore
    {
        readonly int headerOffsetAdjustment = 4;
        readonly int tribeHeaderBaseOffset = 12;

        List<Tuple<long, long, long>> tribeDataPointers = new List<Tuple<long, long, long>>(); //tribeId, offset, size
        List<Tuple<long, long, long>> profileDataPointers = new List<Tuple<long, long, long>>(); //eosId, offset, size


        public List<AsaTribe> Tribes { get; internal set; } = new List<AsaTribe>();
        public List<AsaProfile> Profiles { get; internal set; } = new List<AsaProfile>();

        public AsaTribeStore(AsaArchive archive)
        {
            bool someBool = archive.ReadBool();

            //headers (pointers)
            readTribeHeaders(archive);
            readProfileHeaders(archive);

            readTribes(archive);
            readProfiles(archive);

        }

        private void readTribes(AsaArchive archive)
        {
 
            foreach (var tribePointer in tribeDataPointers)
            {
                try
                {
                    archive.Position = tribePointer.Item2;
                    AsaTribe tribeObject = new AsaTribe();
                    tribeObject.Read(archive, false);


                    Tribes.Add(tribeObject);
    
                }
                catch 
                {
                
                }
            }

        }

        private void readProfiles(AsaArchive archive)
        {
            foreach (var profilePointer in profileDataPointers)
            {
                try
                {

                    archive.Position = profilePointer.Item2;
                    AsaProfile profileObject = new AsaProfile();
                    profileObject.Read(archive);

                    if (!Profiles.Any(p => p.Profile.Uuid.Equals(profileObject.Profile.Uuid)))
                    {

                        Profiles.Add(profileObject);
                    }

                }
                catch
                {

                }
            }
        }

        private void readProfileHeaders(AsaArchive archive)
        {
            long playerHeaderStart = archive.ReadInt() + archive.Position + headerOffsetAdjustment;
            int playerCount = archive.ReadInt();
            if (playerCount == 0) return;

            long playerDataStart = archive.Position;
            archive.Position = playerHeaderStart;
            for (int i = 0; i < playerCount; i++)
            {
                long eosId = archive.ReadLong();
                long offset = archive.ReadInt() + playerDataStart;
                int size = archive.ReadInt();
                profileDataPointers.Add(new Tuple<long, long, long>(eosId, offset, size));
            }
        }

        private void readTribeHeaders(AsaArchive archive)
        {
            int tribeHeaderStart = archive.ReadInt() + tribeHeaderBaseOffset;
            int tribeCount = archive.ReadInt();
            if (tribeCount == 0) return;

            long tribeDataStart = archive.Position;

            archive.Position = tribeHeaderStart;
            for (int i = 0; i < tribeCount; i++)
            {
                var tribeId = archive.ReadUInt();
                int something = archive.ReadInt();
                long offset = archive.ReadInt() + tribeDataStart;
                int size = archive.ReadInt();

                tribeDataPointers.Add(new Tuple<long, long, long>(tribeId,offset,size));
            }

        }

    }
}
