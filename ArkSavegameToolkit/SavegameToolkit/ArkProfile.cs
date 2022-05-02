using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit
{

    public class ArkProfile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer
    {

        public int ProfileVersion { get; set; }

        public List<IProperty> Properties => profile.Properties;

        private GameObject profile;
        private int propertiesBlockOffset;

        public GameObject Profile
        {
            get => profile;
            set
            {
                if (profile != null)
                {
                    int oldIndex = Objects.IndexOf(profile);
                    if (oldIndex > -1)
                    {
                        Objects.RemoveAt(oldIndex);
                    }
                }

                profile = value;
                if (value != null && Objects.IndexOf(value) == -1)
                {
                    Objects.Insert(0, value);
                }
            }
        }

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            try
            {
                ProfileVersion = archive.ReadInt();

                if (ProfileVersion != 1)
                {
                    //throw new NotSupportedException("Unknown Profile Version " + ProfileVersion);
                }

                int profilesCount = archive.ReadInt();

                Objects.Clear();
                ObjectMap.Clear();
                for (int i = 0; i < profilesCount; i++)
                {
                    addObject(new GameObject(archive), options.BuildComponentTree);
                }

                for (int i = 0; i < profilesCount; i++)
                {
                    GameObject gameObject = Objects[i];
                    if (gameObject.ClassString == "PrimalPlayerData" || gameObject.ClassString == "PrimalPlayerDataBP_C")
                    {
                        profile = gameObject;
                    }

                    gameObject.LoadProperties(archive, i < profilesCount - 1 ? Objects[i + 1] : null, 0);
                }
            }
            catch
            {

            }

            //var tekGrams = Objects.Where(o => o.ClassString.ToLower().Contains("canteen")).ToList();

        }

        public void WriteBinary(ArkArchive archive, WritingOptions options)
        {
            archive.WriteInt(ProfileVersion);
            archive.WriteInt(Objects.Count);

            foreach (GameObject gameObject in Objects)
            {
                propertiesBlockOffset = gameObject.WriteBinary(archive, propertiesBlockOffset);
            }

            foreach (GameObject gameObject in Objects)
            {
                gameObject.WriteProperties(archive, 0);
            }
        }

        public int CalculateSize()
        {
            int size = sizeof(int) * 2;

            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;

            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }

        public void ReadJson(JToken node, ReadingOptions options)
        {
            ProfileVersion = node.Value<int>("profileVersion");

            Objects.Clear();
            ObjectMap.Clear();
            JObject profileNode = node.Value<JObject>("profile");
            if (profileNode != null)
            {
                addObject(new GameObject(profileNode), options.BuildComponentTree);
                profile = Objects[0];
            }

            JArray objectsNode = node.Value<JArray>("objects");
            if (objectsNode != null)
            {
                foreach (JToken objectNode in objectsNode)
                {
                    addObject(new GameObject((JObject)objectNode), options.BuildComponentTree);
                }
            }
        }

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions)
        {
            generator.WriteStartObject();

            generator.WriteField("profileVersion", ProfileVersion);
            generator.WritePropertyName("profile");
            if (profile != null)
            {
                profile.WriteJson(generator, writingOptions);
            }
            else
            {
                generator.WriteNull();
            }

            if (Objects.Count > (profile == null ? 0 : 1))
            {
                generator.WriteArrayFieldStart("objects");
                foreach (GameObject gameObject in Objects)
                {
                    if (gameObject == profile)
                    {
                        continue;
                    }

                    gameObject.WriteJson(generator, writingOptions);
                }

                generator.WriteEndArray();
            }

            generator.WriteEndObject();
        }
    }

}
