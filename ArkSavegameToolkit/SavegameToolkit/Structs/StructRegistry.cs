using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Structs {

    public static class StructRegistry {

        private static readonly Dictionary<ArkName, StructConstructor> typeMap = new Dictionary<ArkName, StructConstructor>();

        private static readonly Dictionary<ArkName, ArkName> nameTypeMap = new Dictionary<ArkName, ArkName>();

        private static void addStruct(string name, StructConstructor.Binary binaryConstructor, StructConstructor.Json jsonConstructor) {
            typeMap.Add(ArkName.ConstantPlain(name), new StructConstructor(binaryConstructor, jsonConstructor));
        }

        private static StructConstructor.Binary binaryConstructorFunction<T>() where T : IStruct, new() {
            return archive => {
                T t = new T();
                t.Init(archive);
                return t;
            };
        }

        private static StructConstructor.Json jsonConstructorFunction<T>() where T : IStruct, new() {
            return node => {
                T t = new T();
                t.Init(node);
                return t;
            };
        }

        static StructRegistry() {
            addStruct("Vector", binaryConstructorFunction<StructVector>(), jsonConstructorFunction<StructVector>());
            addStruct("Vector2D", binaryConstructorFunction<StructVector2D>(), jsonConstructorFunction<StructVector2D>());
            addStruct("Quat", binaryConstructorFunction<StructQuat>(), jsonConstructorFunction<StructQuat>());
            addStruct("Color", binaryConstructorFunction<StructColor>(), jsonConstructorFunction<StructColor>());
            addStruct("LinearColor", binaryConstructorFunction<StructLinearColor>(), jsonConstructorFunction<StructLinearColor>());
            addStruct("Rotator", binaryConstructorFunction<StructVector>(), jsonConstructorFunction<StructVector>());
            addStruct("UniqueNetIdRepl", binaryConstructorFunction<StructUniqueNetIdRepl>(), jsonConstructorFunction<StructUniqueNetIdRepl>());

            nameTypeMap.Add(ArkName.ConstantPlain("CustomColors"), ArkName.ConstantPlain("Color"));
            nameTypeMap.Add(ArkName.ConstantPlain("CustomColours_60_7D3267C846B277953C0C41AEBD54FBCB"), ArkName.ConstantPlain("LinearColor"));
        }

        public static ArkName MapArrayNameToTypeName(ArkName arrayName) {
            return arrayName != null && nameTypeMap.TryGetValue(arrayName, out ArkName result) ? result : null;
        }

        public static IStruct ReadBinary(ArkArchive archive, ArkName structType) {
            if (structType != null && typeMap.TryGetValue(structType, out StructConstructor constructor)) {
                return constructor.BinaryConstructor(archive);
            }

            try {
                return new StructPropertyList(archive);
            } catch (UnreadablePropertyException upe) {
                throw new UnreadablePropertyException($"Unknown Struct Type {structType} at {archive.Position:X4} failed to read as StructPropertyList", upe);
            }
        }

        public static IStruct ReadJson(JToken node, ArkName structType) {
            if (structType != null && typeMap.TryGetValue(structType, out StructConstructor constructor)) {
                return constructor.JsonConstructor((JObject)node);
            }

            try {
                return new StructPropertyList((JArray)node);
            } catch (UnreadablePropertyException upe) {
                throw new UnreadablePropertyException($"Unknown Struct Type {structType} failed to read as StructPropertyList", upe);
            }
        }

        private class StructConstructor {

            public delegate IStruct Binary(ArkArchive archive);

            public delegate IStruct Json(JObject node);

            public Binary BinaryConstructor { get; }
            public Json JsonConstructor { get; }

            public StructConstructor(Binary binaryConstructor, Json jsonConstructor) {
                BinaryConstructor = binaryConstructor;
                JsonConstructor = jsonConstructor;
            }
        }

    }

}
