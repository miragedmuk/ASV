using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit
{

    public class ArkTribe : GameObjectContainerMixin, IConversionSupport, IPropertyContainer
    {

        public int TribeVersion { get; set; }

        public GameObject Tribe { get; set; }

        public List<IProperty> Properties => Tribe.Properties;

        private int propertiesBlockOffset;

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            TribeVersion = archive.ReadInt();

            if (TribeVersion != 1)
            {
                throw new NotSupportedException("Unknown Tribe Version " + TribeVersion);
            }

            int tribesCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < tribesCount; i++)
            {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            for (int i = 0; i < tribesCount; i++)
            {
                GameObject gameObject = Objects[i];
                if (gameObject.ClassString == "PrimalTribeData")
                {
                    Tribe = gameObject;
                }

                gameObject.LoadProperties(archive, i < tribesCount - 1 ? Objects[i + 1] : null, 0);
            }
        }

        public void WriteBinary(ArkArchive archive, WritingOptions options)
        {
            archive.WriteInt(TribeVersion);
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
            TribeVersion = node.Value<int>("tribeVersion");

            Objects.Clear();
            ObjectMap.Clear();
            JObject tribeNode = node.Value<JObject>("tribe");
            if (tribeNode != null)
            {
                addObject(new GameObject(tribeNode), options.BuildComponentTree);
                Tribe = Objects[0];
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

            generator.WriteField("tribeVersion", TribeVersion);
            generator.WritePropertyName("tribe");
            if (Tribe != null)
            {
                Tribe.WriteJson(generator, writingOptions);
            }
            else
            {
                generator.WriteNull();
            }

            if (Objects.Count > (Tribe == null ? 0 : 1))
            {
                generator.WriteArrayFieldStart("objects");
                foreach (GameObject gameObject in Objects.Where(o => o != Tribe))
                {
                    gameObject.WriteJson(generator, writingOptions);
                }

                generator.WriteEndArray();
            }

            generator.WriteEndObject();
        }
    }

}
