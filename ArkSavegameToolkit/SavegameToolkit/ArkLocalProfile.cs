using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit {

    public class ArkLocalProfile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer {

        private static readonly int UNKNOWN_DATA_2_SIZE = 0xc;

        public int LocalProfileVersion { get; set; }

        private byte[] unknownData;

        private byte[] unknownData2;

        private GameObject localProfile;
        public GameObject LocalProfile {
            get => localProfile;
            set {
                if (localProfile != null) {
                    int oldIndex = Objects.IndexOf(localProfile);
                    if (oldIndex > -1) {
                        Objects.RemoveAt(oldIndex);
                    }
                }

                localProfile = value;
                if (value != null && Objects.IndexOf(value) == -1) {
                    Objects.Insert(0, value);
                }
            }
        }

        public List<IProperty> Properties => localProfile.Properties;

        private int propertiesBlockOffset;

        public void ReadBinary(ArkArchive archive, ReadingOptions options) {
            LocalProfileVersion = archive.ReadInt();

            if (LocalProfileVersion != 1 && LocalProfileVersion != 3 && LocalProfileVersion != 4) {
                throw new NotSupportedException("Unknown Profile Version " + LocalProfileVersion);
            }

            if (LocalProfileVersion < 4) {
                int unknownDataSize = archive.ReadInt();

                unknownData = archive.ReadBytes(unknownDataSize);

                if (LocalProfileVersion == 3) {
                    unknownData2 = archive.ReadBytes(UNKNOWN_DATA_2_SIZE);
                }
            }

            int objectCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < objectCount; i++) {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            for (int i = 0; i < objectCount; i++) {
                GameObject gameObject = Objects[i];
                if (gameObject.ClassString == "PrimalLocalProfile") {
                    localProfile = gameObject;
                }

                gameObject.LoadProperties(archive, i < objectCount - 1 ? Objects[i + 1] : null, 0);
            }
        }


    }

}
