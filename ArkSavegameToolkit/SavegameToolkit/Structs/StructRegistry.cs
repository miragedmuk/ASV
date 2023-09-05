using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Structs {

    public static class StructRegistry {

        private static readonly Dictionary<ArkName, StructConstructor> typeMap = new Dictionary<ArkName, StructConstructor>();

        private static readonly Dictionary<ArkName, ArkName> nameTypeMap = new Dictionary<ArkName, ArkName>();

        private static void addStruct(string name, StructConstructor.Binary binaryConstructor) {
            typeMap.Add(ArkName.ConstantPlain(name), new StructConstructor(binaryConstructor));
        }

        private static StructConstructor.Binary binaryConstructorFunction<T>() where T : IStruct, new() {
            return archive => {
                T t = new T();
                t.Init(archive);
                return t;
            };
        }

        static StructRegistry() {
            addStruct("Vector", binaryConstructorFunction<StructVector>());
            addStruct("Vector2D", binaryConstructorFunction<StructVector2D>());
            addStruct("Quat", binaryConstructorFunction<StructQuat>());
            addStruct("Color", binaryConstructorFunction<StructColor>());
            addStruct("LinearColor", binaryConstructorFunction<StructLinearColor>());
            addStruct("Rotator", binaryConstructorFunction<StructVector>());
            addStruct("UniqueNetIdRepl", binaryConstructorFunction<StructUniqueNetIdRepl>());

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

        private class StructConstructor {

            public delegate IStruct Binary(ArkArchive archive);

            public delegate IStruct Json(JObject node);

            public Binary BinaryConstructor { get; }

            public StructConstructor(Binary binaryConstructor) {
                BinaryConstructor = binaryConstructor;
            }
        }

    }

}
