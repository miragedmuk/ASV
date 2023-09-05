using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;

namespace SavegameToolkit.Data {

    public class ExtraDataFoliageHandler : IExtraDataHandler {
        private static readonly ArkName className = ArkName.ConstantPlain("InstancedFoliageActor");

        public bool CanHandle(GameObject gameObject, int length) => gameObject.ClassName == className;

        public bool CanHandle(GameObject gameObject, JToken node) => gameObject.ClassName == className && node.Type == JTokenType.Array;

        public IExtraData ReadBinary(GameObject gameObject, ArkArchive archive, int length) {
            int shouldBeZero = archive.ReadInt();
            if (shouldBeZero != 0) {
                throw new UnexpectedDataException($"Expected int after properties to be 0 but found {shouldBeZero} at {(archive.Position - 4):X4}");
            }

            int structMapCount = archive.ReadInt();

            List<Dictionary<string, StructPropertyList>> structMapList = new List<Dictionary<string, StructPropertyList>>(structMapCount);

            try {
                for (int structMapIndex = 0; structMapIndex < structMapCount; structMapIndex++) {
                    int structCount = archive.ReadInt();
                    Dictionary<string, StructPropertyList> structMap = new Dictionary<string, StructPropertyList>();

                    for (int structIndex = 0; structIndex < structCount; structIndex++) {
                        string structName = archive.ReadString();
                        if (!string.IsNullOrEmpty(structName))
                        {
                            StructPropertyList properties = new StructPropertyList(archive);

                            int shouldBeZero2 = archive.ReadInt();
                            if (shouldBeZero2 != 0)
                            {
                                throw new UnexpectedDataException($"Expected int after properties to be 0 but found {shouldBeZero2} at {(archive.Position - 4):X4}");
                            }

                            structMap[structName] = properties;
                        }
                        
                    }

                    structMapList.Add(structMap);
                }
            } catch (UnreadablePropertyException upe) {
                //throw new UnexpectedDataException(upe);
            }

            ExtraDataFoliage extraDataFoliage = new ExtraDataFoliage {
                    StructMapList = structMapList
            };

            return extraDataFoliage;
        }

       
    }

}
