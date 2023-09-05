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

 
}
