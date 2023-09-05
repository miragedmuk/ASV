using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    public static class PropertyRegistry {

        private static readonly Dictionary<ArkName, PropertyConstructor> typeMap = new Dictionary<ArkName, PropertyConstructor>();

        private static void addProperty(ArkName name, PropertyConstructor.Binary binaryConstructor, PropertyConstructor.Json jsonConstructor) {
            typeMap.Add(name, new PropertyConstructor(binaryConstructor, jsonConstructor));
        }

        private static PropertyConstructor.Binary binaryConstructorFunction<T>() where T : IProperty, new() {
            return (archive, name) => {
                T t = new T();
                t.Init(archive, name);
                return t;
            };
        }

        private static PropertyConstructor.Json jsonConstructorFunction<T>() where T : IProperty, new() {
            return node => {
                T t = new T();
                t.Init(node);
                return t;
            };
        }

        static PropertyRegistry() {
            addProperty(PropertyInt8.TYPE, binaryConstructorFunction<PropertyInt8>(), jsonConstructorFunction<PropertyInt8>());
            addProperty(PropertyByte.TYPE, binaryConstructorFunction<PropertyByte>(), jsonConstructorFunction<PropertyByte>());
            addProperty(PropertyInt16.TYPE, binaryConstructorFunction<PropertyInt16>(), jsonConstructorFunction<PropertyInt16>());
            addProperty(PropertyUInt16.TYPE, binaryConstructorFunction<PropertyUInt16>(), jsonConstructorFunction<PropertyUInt16>());
            addProperty(PropertyInt.TYPE, binaryConstructorFunction<PropertyInt>(), jsonConstructorFunction<PropertyInt>());
            addProperty(PropertyUInt32.TYPE, binaryConstructorFunction<PropertyUInt32>(), jsonConstructorFunction<PropertyUInt32>());
            addProperty(PropertyInt64.TYPE, binaryConstructorFunction<PropertyInt64>(), jsonConstructorFunction<PropertyInt64>());
            addProperty(PropertyUInt64.TYPE, binaryConstructorFunction<PropertyUInt64>(), jsonConstructorFunction<PropertyUInt64>());
            addProperty(PropertyFloat.TYPE, binaryConstructorFunction<PropertyFloat>(), jsonConstructorFunction<PropertyFloat>());
            addProperty(PropertyDouble.TYPE, binaryConstructorFunction<PropertyDouble>(), jsonConstructorFunction<PropertyDouble>());
            addProperty(PropertyBool.TYPE, binaryConstructorFunction<PropertyBool>(), jsonConstructorFunction<PropertyBool>());
            addProperty(PropertyString.TYPE, binaryConstructorFunction<PropertyString>(), jsonConstructorFunction<PropertyString>());
            addProperty(PropertyName.TYPE, binaryConstructorFunction<PropertyName>(), jsonConstructorFunction<PropertyName>());
            addProperty(PropertyObject.TYPE, binaryConstructorFunction<PropertyObject>(), jsonConstructorFunction<PropertyObject>());
            addProperty(PropertyArray.TYPE, binaryConstructorFunction<PropertyArray>(), jsonConstructorFunction<PropertyArray>());
            addProperty(PropertyStruct.TYPE, binaryConstructorFunction<PropertyStruct>(), jsonConstructorFunction<PropertyStruct>());
        }

        public static IProperty ReadBinary(ArkArchive archive) {
            ArkName name = archive.ReadName();

            if (name == null || string.IsNullOrEmpty(name.ToString())) {
                archive.HasUnknownData = true;
                throw new UnreadablePropertyException(
                        $"Property name is {(name == null ? "null" : "empty")}, indicating a corrupt file. Ignoring remaining properties.");
            }

            if (name == ArkName.NameNone) {
                return null;
            }

            ArkName type = archive.ReadName();

            if (type != null && typeMap.TryGetValue(type, out PropertyConstructor constructor)) {
                return constructor.BinaryConstructor(archive, name);
            }

            archive.DebugMessage($"Unknown property type {name}");
            archive.HasUnknownNames = true;
            return new PropertyUnknown(archive, name);
        }

        private class PropertyConstructor {

            public delegate IProperty Binary(ArkArchive archive, ArkName name);

            public delegate IProperty Json(JObject node);

            public Binary BinaryConstructor { get; }
            public Json JsonConstructor { get; }

            public PropertyConstructor(Binary binaryConstructor, Json jsonConstructor) {
                BinaryConstructor = binaryConstructor;
                JsonConstructor = jsonConstructor;
            }

        }

    }

}
