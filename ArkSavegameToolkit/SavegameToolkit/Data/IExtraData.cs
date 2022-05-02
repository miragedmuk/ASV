using System;
using Newtonsoft.Json;

namespace SavegameToolkit.Data {

    [JsonConverter(typeof(ExtraDataConverter))]
    public interface IExtraData {
        int CalculateSize(NameSizeCalculator nameSizer);

        void WriteJson(JsonTextWriter generator, WritingOptions writingOptions);

        void WriteBinary(ArkArchive archive);
    }

    public class ExtraDataConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            if (value is null) {
                writer.WriteNull();
                return;
            }
            (value as IExtraData)?.WriteJson(writer as JsonTextWriter, WritingOptions.Create());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType) {
            return true;
        }
    }

}
