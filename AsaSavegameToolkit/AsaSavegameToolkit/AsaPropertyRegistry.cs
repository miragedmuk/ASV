using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    var structType = archive.ReadName();
                    returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, archive.ReadByte(), ReadStructPropertyValue(archive, dataSize, structType, inArray));
                    return returnProperty;


                case "ArrayProperty":
                    var a = ReadArrayProperty(keyName, valueTypeName, position, archive, dataSize);
                    returnProperty = new AsaProperty<dynamic>(keyName.Name, valueTypeName.Name, position, 0, a.Value);
                    return returnProperty;

                case "MapProperty":

                    break;
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

                    break;
            }

            return null;
        }

        private static AsaPropertyArray ReadArrayProperty(AsaName key, AsaName valueType, int position, AsaArchive archive, int dataSize)
        {
            var arrayType = archive.ReadName();
            var endOfStruct = archive.ReadByte();
            var arrayLength = archive.ReadInt();
            var startOfArrayValuesPosition = archive.Position;

            //struct
            if (arrayType.Name.Equals("StructProperty"))
            {
                return ReadStructArray(archive, arrayType, arrayLength);

            }


            //anything else

            var expectedEndOfArrayPosition = startOfArrayValuesPosition + dataSize - 4;

            List<dynamic> array = new List<dynamic>();
            if (valueType == null)
            {
                throw new Exception("");
            }

            try
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    array.Add(ReadPropertyValue(arrayType, archive));
                }
                if (expectedEndOfArrayPosition != archive.Position)
                {
                    throw new Exception("");
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
            var objectValue = Convert.ToHexString(archive.ReadBytes(4));

            return new AsaProperty<dynamic>(objectName.ToString(), "PropertyStr", 0, 0, objectValue);
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
