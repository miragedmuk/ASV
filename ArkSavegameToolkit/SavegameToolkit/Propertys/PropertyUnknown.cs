using System;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    public class PropertyUnknown : PropertyBase<byte[]> {

        public override ArkName Type { get; }

        public PropertyUnknown(ArkArchive archive, ArkName name) : base(name, 0, null) {
            base.Init(archive, name);
            Type = name;
            if (DataSize > 0)
            {
                Value = archive.ReadBytes(DataSize);
            }
        }

        public PropertyUnknown(JObject node) : base(null, 0, null) {
            base.Init(node);
            Type = ArkName.From(node.Value<string>("type"));
            try {
                Value = node["value"]?.ToObject<byte[]>();
            } catch (FormatException ex) {
                throw new UnreadablePropertyException(ex);
            }
        }

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => Value.Length;

        protected override void writeBinaryValue(ArkArchive archive) => archive.WriteBytes(Value);
    }

}
