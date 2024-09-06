namespace AsaSavegameToolkit.Structs
{
    public class AsaVector
    {
        public double X;
        public double Y;
        public double Z;
        public AsaVector(AsaArchive archive)
        {
            X = archive.ReadDouble();
            Y = archive.ReadDouble();
            Z = archive.ReadDouble();
        }

    }
}
