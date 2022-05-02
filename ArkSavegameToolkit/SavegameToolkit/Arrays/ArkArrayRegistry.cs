using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public static class ArkArrayRegistry {

        private static readonly Dictionary<ArkName, ArkArrayConstructor> types = new Dictionary<ArkName, ArkArrayConstructor>();

        private static void addType(ArkName name, ArkArrayConstructor.Binary binaryConstructor, ArkArrayConstructor.Json jsonConstructor) {
            types.Add(name, new ArkArrayConstructor(binaryConstructor, jsonConstructor));
        }

        private static ArkArrayConstructor.Binary binaryConstructorFunction<T>() where T : IArkArray, new() {
            return (archive, property) => {
                T t = new T();
                t.Init(archive, property);
                return t;
            };
        }

        private static ArkArrayConstructor.Json jsonConstructorFunction<T>() where T : IArkArray, new() {
            return (node, property) => {
                T t = new T();
                t.Init(node, property);
                return t;
            };
        }

        static ArkArrayRegistry() {
            types = new Dictionary<ArkName, ArkArrayConstructor>();

            addType(ArkArrayInt8.TYPE, binaryConstructorFunction<ArkArrayInt8>(), jsonConstructorFunction<ArkArrayInt8>());
            addType(ArkArrayByteHandler.TYPE, ArkArrayByteHandler.create, ArkArrayByteHandler.create);
            addType(ArkArrayInt16.TYPE, binaryConstructorFunction<ArkArrayInt16>(), jsonConstructorFunction<ArkArrayInt16>());
            addType(ArkArrayUInt16.TYPE, binaryConstructorFunction<ArkArrayUInt16>(), jsonConstructorFunction<ArkArrayUInt16>());
            addType(ArkArrayInt.TYPE, binaryConstructorFunction<ArkArrayInt>(), jsonConstructorFunction<ArkArrayInt>());
            addType(ArkArrayUInt32.TYPE, binaryConstructorFunction<ArkArrayUInt32>(), jsonConstructorFunction<ArkArrayUInt32>());
            addType(ArkArrayInt64.TYPE, binaryConstructorFunction<ArkArrayInt64>(), jsonConstructorFunction<ArkArrayInt64>());
            addType(ArkArrayUInt64.TYPE, binaryConstructorFunction<ArkArrayUInt64>(), jsonConstructorFunction<ArkArrayUInt64>());
            addType(ArkArrayFloat.TYPE, binaryConstructorFunction<ArkArrayFloat>(), jsonConstructorFunction<ArkArrayFloat>());
            addType(ArkArrayDouble.TYPE, binaryConstructorFunction<ArkArrayDouble>(), jsonConstructorFunction<ArkArrayDouble>());
            addType(ArkArrayBool.TYPE, binaryConstructorFunction<ArkArrayBool>(), jsonConstructorFunction<ArkArrayBool>());
            addType(ArkArrayString.TYPE, binaryConstructorFunction<ArkArrayString>(), jsonConstructorFunction<ArkArrayString>());
            addType(ArkArrayName.TYPE, binaryConstructorFunction<ArkArrayName>(), jsonConstructorFunction<ArkArrayName>());
            addType(ArkArrayObjectReference.TYPE, binaryConstructorFunction<ArkArrayObjectReference>(), jsonConstructorFunction<ArkArrayObjectReference>());
            addType(ArkArrayStruct.TYPE, binaryConstructorFunction<ArkArrayStruct>(), jsonConstructorFunction<ArkArrayStruct>());
        }

        public static IArkArray ReadBinary(ArkArchive archive, ArkName arrayType, PropertyArray property) {
            if (arrayType != null && types.TryGetValue(arrayType, out ArkArrayConstructor constructor)) {
                return constructor.BinaryConstructor(archive, property);
            }

            throw new UnreadablePropertyException($"Unknown Array Type {arrayType} at {archive.Position:X4}");
        }

        public static IArkArray ReadJson(JArray node, ArkName arrayType, PropertyArray property) {
            if (arrayType != null && types.TryGetValue(arrayType, out ArkArrayConstructor constructor)) {
                return constructor.JsonConstructor(node, property);
            }

            throw new UnreadablePropertyException("Unknown Array Type " + arrayType);
        }
    }

}
