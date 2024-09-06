namespace AsaSavegameToolkit.Structs
{
    public class AsaColor 
    {
        private readonly byte r;
        private readonly byte g;
        private readonly byte b;
        private readonly byte a;

        public byte R => r;
        public byte G => g;
        public byte B => b;
        public byte A => a;


        public AsaColor(AsaArchive archive)
        {
            r = archive.ReadByte();
            g = archive.ReadByte();
            b = archive.ReadByte();
            a = archive.ReadByte();
        }

    }
}
