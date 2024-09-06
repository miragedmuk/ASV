namespace AsaSavegameToolkit.Structs
{
    public class AsaUniqueNetIdRepl
    {
        private readonly byte unknown;
        private readonly string valueType;
        private readonly string value;

        public string ValueType => valueType;
        public string Value => value;

        public AsaUniqueNetIdRepl(AsaArchive archive)
        {
            unknown = archive.ReadByte();
            valueType = archive.ReadString();
            int length = archive.ReadByte();
            value = Convert.ToHexString(archive.ReadBytes(length));
        }
    }
}
