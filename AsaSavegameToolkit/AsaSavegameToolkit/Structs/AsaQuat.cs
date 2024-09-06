namespace AsaSavegameToolkit.Structs
{
    public class AsaQuat
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;
        private readonly double w;

        public double X => x;
        public double Y => y;
        public double Z => z;
        public double W => w;


        public AsaQuat(AsaArchive archive)
        {
            x = archive.ReadDouble();
            y = archive.ReadDouble();
            z = archive.ReadDouble();
            w = archive.ReadDouble();
        }
    }
}
