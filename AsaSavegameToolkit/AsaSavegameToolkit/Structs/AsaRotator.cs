namespace AsaSavegameToolkit.Structs
{
    public class AsaRotator
    {
        private readonly double pitch;
        private readonly double yaw;
        private readonly double roll;

        public double Pitch => pitch;
        public double Yaw => yaw;
        public double Roll => roll;


        public AsaRotator(AsaArchive archive)
        {
            pitch = archive.ReadDouble();
            yaw = archive.ReadDouble();
            roll = archive.ReadDouble();
        }
    }
}
