using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AsaSavegameToolkit
{
    public class AsaPropertyRegistry
    {

        public static AsaProperty<dynamic> ReadProperty(AsaArchive archive)
        {
            return ReadProperty(archive, false);
        }

        public static AsaProperty<dynamic> ReadProperty(AsaArchive archive, bool inArray)
        {
            var keyName = archive.ReadName();

            if (keyName == null || keyName.Equals(AsaName.NameNone))
            {
                return null;
            }

            var valueTypeName = archive.ReadName();
            if (valueTypeName == null)
            {
                return null;
            }

            var dataSize = archive.ReadInt();
            var position = archive.ReadInt();
            var startPosition = archive.Position;


            AsaProperty<dynamic> returnProperty = null;

            switch (valueTypeName.Name)
            {
                case "BoolProperty":
                    returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, ReadPropertyValue(valueTypeName, archive));
                    return returnProperty;

                case "FloatProperty":
                case "IntProperty":
                case "Int8Property":
                case "DoubleProperty":
                case "UInt32Property":
                case "UInt64Property":
                case "UInt16Property":
                case "Int16Property":
                case "Int64Property":
                case "StrProperty":
                case "NameProperty":
                case "SoftObjectProperty":
                case "ObjectProperty":

                    returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, archive.ReadByte(), ReadPropertyValue(valueTypeName, archive));
                    return returnProperty;

                case "StructProperty":
                    dynamic structType = archive.ReadName();
                    if (structType == null)
                    {
                        archive.Position = startPosition;
                        archive.SkipBytes(dataSize);
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0,0);
                    }
                    else
                    {
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, archive.ReadByte(), ReadStructPropertyValue(archive, dataSize, structType, inArray));

                    }
                    return returnProperty;


                case "ArrayProperty":
                    var a = ReadArrayProperty(keyName, position, archive, dataSize);
                    returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, a.Value);
                    return returnProperty;

                case "MapProperty":


                    dynamic? mapValue = null;
                    try
                    {
                        mapValue = ReadMapProperty(archive);
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, mapValue);
                    }
                    catch
                    {
                        archive.Position = startPosition;
                        archive.SkipBytes(dataSize);
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, 0);

                    }
                    //returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, mapValue);
                    return returnProperty;
                    
                case "ByteProperty":
                    var byteType = archive.ReadName();
                    if (byteType.Equals(AsaName.NameNone))
                    {
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, archive.ReadByte(), archive.ReadByte());
                    }
                    else
                    {
                        returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, archive.ReadByte(), archive.ReadName());
                    }

                    return returnProperty;

                default:
                    return null;
            }

            return null;
        }


        private static dynamic? ReadMapProperty(AsaArchive archive)
        {
            var keyType = archive.ReadName();
            var valueType = archive.ReadName();
            var byteUnknown = archive.ReadByte();
            var skipCount = archive.ReadInt();
            var mapCount = archive.ReadInt();

            List<AsaProperty<dynamic>> property = new List<AsaProperty<dynamic>>();
            AsaName? propertyName = AsaName.NameNone;

            for (int mapIndex = 0; mapIndex < mapCount; mapIndex++)
            {
                List<AsaProperty<dynamic>> propertyValues = new List<AsaProperty<dynamic>>();


                switch (keyType.Name)
                {
                    case "NameProperty":
                        property.Add(ReadStructMap(archive, keyType, valueType));

                        break;
                    case "ObjectProperty":
                        var mapObjectRef = new AsaObjectReference(archive, true);
                        archive.SkipBytes(1);


                        break;
                    default:

                        propertyName = archive.ReadName();
                        var unknown0 = archive.ReadInt(); //0

                        while (true)
                        {
                            AsaName? subKeyName = archive.ReadName();
                            if (subKeyName is null) break;
                            if (subKeyName.Equals(AsaName.NameNone))
                            {
                                break;
                            }

                            var dataType = archive.ReadName();
                            var unknown1 = archive.ReadInt(); //8
                            var unknown2 = archive.ReadInt(); //0

                            archive.SkipBytes(1);
                            var keyValue = ReadPropertyValue(dataType, archive);
                            propertyValues.Add(new AsaProperty<dynamic>(subKeyName.Name, dataType.Name, 0, 0, keyValue));

                        }

                        if (propertyValues.Count > 0)
                        {
                            property.Add(new AsaProperty<dynamic>(propertyName.Name, "PropertyList", 0, 0, propertyValues));
                        }

                        break;
                }
            }

            return property;
        }

        private static AsaProperty<dynamic>? ReadStructMap(AsaArchive archive, AsaName keyType, AsaName valueType)
        {
            List<AsaProperty<dynamic>> propertyValues = new List<AsaProperty<dynamic>>();

            var keyName = ReadPropertyValue(keyType, archive);

            while (true)
            {
                string valueKeyName = string.Empty;

                if (keyType.Name == "NameProperty")
                {
                    var valueName = archive.ReadName();
                    if (valueName == null || valueName.Equals(AsaName.NameNone))
                    {
                        break; //end of set
                    }
                    valueKeyName = valueName.Name;
                }
                else
                {
                    //TODO:// unknown atm
                    break;
                }

                var mapType = archive.ReadName(); //SetProperty
                switch (mapType.Name)
                {
                    case "SetProperty":
                        var mapValue = ReadSetProperty(archive);
                        propertyValues.Add(new AsaProperty<dynamic>(valueKeyName, mapType.Name, 0, 0, mapValue));

                        break;
                    case "NameProperty":

                        break;
                    default:

                        break;
                }



            }

            return new AsaProperty<dynamic>(keyName, valueType.Name, 0, 0, propertyValues);
        }

        private static dynamic? ReadSetProperty(AsaArchive archive)
        {
            List<dynamic> values = new List<dynamic>();

            //SetProperty
            var setUnknownInt = archive.ReadInt(); //8
            var shouldBeZero = archive.ReadInt(); //0
            var setType = archive.ReadName(); //ObjectProperty
            archive.SkipBytes(1);

            var objectSkipCount = archive.ReadInt(); //0
            var objectCount = archive.ReadInt(); //1

            for (int x = 0; x < objectCount; x++)
            {
                values.Add(ReadPropertyValue(setType, archive));
            }

            return values;
        }



        private static AsaPropertyArray ReadArrayProperty(AsaName key, int position, AsaArchive archive, int dataSize)
        {
            var arrayType = archive.ReadName();
            var endOfStruct = archive.ReadByte();
            var arrayLength = archive.ReadInt();
            var startOfArrayValuesPosition = archive.Position;

            //struct
            switch (arrayType.Name)
            {
                case "StructProperty":
                    return ReadStructArray(archive, arrayType, arrayLength);

                default:
                    break;
            }


            //anything else

            var expectedEndOfArrayPosition = startOfArrayValuesPosition + dataSize - 4;

            List<dynamic> array = new List<dynamic>();
            try
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    array.Add(ReadPropertyValue(arrayType, archive));
                }
                if (expectedEndOfArrayPosition != archive.Position)
                {
                    var skipBytes = expectedEndOfArrayPosition - archive.Position;
                    archive.SkipBytes((int)skipBytes);
                }
            }
            catch (Exception e)
            {
                archive.Position = startOfArrayValuesPosition;
                String content = Convert.ToHexString(archive.ReadBytes(dataSize - 4));
                array.Add(content);
            }

            return new AsaPropertyArray(key.Name, (dynamic)array);

        }

        private static AsaPropertyArray ReadStructArray(AsaArchive archive, AsaName arrayType, int arrayLength)
        {
            List<dynamic> structArray = new List<dynamic>();

            var name = archive.ReadName();
            var type = archive.ReadName();
            var dataSize = archive.ReadInt();
            var position = archive.ReadInt();
            var structType = archive.ReadName();
            var unknownByte = archive.ReadByte();

            archive.SkipBytes(16);
            for (int i = 0; i < arrayLength; i++)
            {
                var structProperties = ReadStructPropertyValue(archive, dataSize, type, true);

                structArray.Add(structProperties);
            }

            return new AsaPropertyArray(name.Name, (dynamic)structArray);
        }

        private static dynamic ReadPropertyValue(AsaName valueTypeName, AsaArchive archive)
        {
            switch (valueTypeName.Name)
            {
                case "ByteProperty":
                case "Int8Property":
                    return archive.ReadByte();
                case "DoubleProperty":
                    return archive.ReadDouble();
                case "FloatProperty":
                    return archive.ReadFloat();
                case "IntProperty":
                    return archive.ReadInt();
                case "ObjectProperty":
                    return ReadObjectPropertyValue(archive);
                case "StrProperty":
                    return archive.ReadString();
                case "NameProperty":
                    return archive.ReadName().ToString();
                case "UInt32Property":
                    return (uint)archive.ReadInt();
                case "UInt64Property":
                    return (ulong)archive.ReadLong();
                case "UInt16Property":
                    return (UInt16)archive.ReadShort();
                case "Int16Property":
                    return archive.ReadShort();
                case "Int64Property":
                    return archive.ReadLong();
                case "BoolProperty":
                    return archive.ReadShort() == 1;
                case "StructProperty":
                    return ReadStructPropertyValue(archive, archive.ReadInt(), true);
                case "SoftObjectProperty":
                    return ReadSoftObjectPropertyValue(archive);
                default:
                    return null;
            }

        }

        private static object ReadSoftObjectPropertyValue(AsaArchive archive)
        {
            var objectName = archive.ReadName();
            var objectValue = archive.ReadName();

            return new AsaProperty<dynamic>(objectName?.ToString(), "PropertyStr", 0, 0, objectValue);
        }


        private static object ReadStructPropertyValue(AsaArchive archive, int dataSize, bool inArray)
        {
            return ReadStructPropertyValue(archive, dataSize, archive.ReadName(), inArray);

        }

        private static dynamic ReadStructPropertyValue(AsaArchive archive, int dataSize, AsaName structType, bool inArray)
        {
            if (!inArray)
            {
                archive.SkipBytes(16);
            }


            switch (structType.Name)
            {
                case "LinearColor":
                    return new AsaLinearColor(archive);
                case "Quat":
                    return new AsaQuat(archive);

                case "Vector":
                    return new AsaVector(archive);

                case "Rotator":
                    return new AsaRotator(archive);

                case "UniqueNetIdRepl":
                    return new AsaUniqueNetIdRepl(archive);
                case "Color":
                    return new AsaColor(archive);

                default:

                    break;
            }

            //not a known/special struct, read in property value(s)
            var position = archive.Position;
            List<object> properties = new List<object>();
            try
            {
                properties = ReadStructProperties(archive);
                if ((archive.Position != position + dataSize) && !inArray)
                {
                    throw new Exception("");
                }

            }
            catch (Exception ex)
            {



            }

            return properties;

        }

        private static List<object> ReadStructProperties(AsaArchive archive)
        {

            List<object> properties = new List<object>();
            var structProperty = ReadProperty(archive);
            while (structProperty != null)
            {
                properties.Add(structProperty);
                structProperty = ReadProperty(archive);
            }

            return properties;
        }

        private static object ReadObjectPropertyValue(AsaArchive archive)
        {
            return new AsaObjectReference(archive, true);
        }
    }
}
