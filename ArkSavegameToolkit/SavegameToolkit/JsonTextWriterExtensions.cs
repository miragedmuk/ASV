using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SavegameToolkit {

    public static class JsonTextWriterExtensions {
        public static void WriteObjectFieldStart(this JsonTextWriter jsonTextWriter, string name) {
            jsonTextWriter.WritePropertyName(name);
            jsonTextWriter.WriteStartObject();
        }

        public static void WriteArrayFieldStart(this JsonTextWriter jsonTextWriter, string name) {
            jsonTextWriter.WritePropertyName(name);
            jsonTextWriter.WriteStartArray();
        }

        public static void WriteNullField(this JsonTextWriter jsonTextWriter, string name) {
            jsonTextWriter.WritePropertyName(name);
            jsonTextWriter.WriteNull();
        }

        public static void WriteField<T>(this JsonTextWriter jsonTextWriter, string name, T value) {
            jsonTextWriter.WritePropertyName(name);
            jsonTextWriter.WriteValue(value);
        }

        public static void UseDefaultPrettyPrint(this JsonTextWriter jsonTextWriter) {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Formatting = Formatting.Indented,
                    NullValueHandling = NullValueHandling.Include
            };

            jsonTextWriter.IndentChar = '\t';
            jsonTextWriter.Indentation = 1;
            jsonTextWriter.Formatting = Formatting.Indented;
        }
    }

    public class ToStringJsonConverter : JsonConverter {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue(value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType) => true;
    }

}
