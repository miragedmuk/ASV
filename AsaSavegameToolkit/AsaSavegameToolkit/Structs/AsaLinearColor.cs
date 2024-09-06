namespace AsaSavegameToolkit.Structs
{
    public class AsaLinearColor
    {
        private readonly float r;
        private readonly float g;
        private readonly float b;
        private readonly float a;

        public float R => r;
        public float G => g;
        public float B => b;
        public float A => a;

        public AsaLinearColor(AsaArchive archive)
        {
            r = archive.ReadFloat();
            g = archive.ReadFloat();
            b = archive.ReadFloat();
            a = archive.ReadFloat();
        }
    }
}
