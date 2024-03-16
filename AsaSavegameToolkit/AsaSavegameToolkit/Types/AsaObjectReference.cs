using AsaSavegameToolkit.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSavegameToolkit.Types
{
    public class AsaObjectReference
    {
        int TYPE_ID = 0;
        int TYPE_PATH = 1;
        int TYPE_PATH_NO_TYPE = 2;
        int TYPE_NAME = 3;
        int TYPE_UUID = 4;
        int TYPE_UNKNOWN = -1;

        private readonly int type;
        private readonly object value;

        public string Value => value.ToString();

        public AsaObjectReference(string objectValue)
        {
            value = objectValue;
        }

        public AsaObjectReference(AsaArchive archive, bool useNameTable)
        {
            if (useNameTable && archive.NameTable.Count>0)
            {
                bool isName = archive.ReadShort() == 1;
                if (isName)
                {
                    type = TYPE_PATH;
                    value = archive.ReadName().ToString();
                }
                else
                {
                    type = TYPE_UUID;
                    value = GuidExtensions.ToGuid(archive.ReadBytes(16));
                }
                return;

            }

            int objectType = archive.ReadInt();


            if(objectType == -1)
            {
                type = TYPE_UNKNOWN;
                value = string.Empty;

            }
            else if (objectType == 0)
            {
                type = TYPE_ID;
                value = archive.ReadInt();
            }
            else if (objectType == 1)
            {
                type = TYPE_PATH;
                value = archive.ReadString();
            }
            else
            {
                archive.SkipBytes(-4);
                type = TYPE_PATH_NO_TYPE;
                value = archive.ReadString();
            }


        }

        public AsaObjectReference(Guid guid)
        {
            type = TYPE_UUID;
            value = guid.ToString();
        }
    }
}
