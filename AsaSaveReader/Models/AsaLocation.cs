using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsaSaveReader.Models
{
    internal class AsaLocation
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;
        public double Pitch = 0;
        public double Yaw = 0;
        public double Roll = 0;

        public AsaLocation(double x, double y, double z, double pitch, double yaw, double roll)
        {
            X = x;
            Y = y;
            Z = z;
            Pitch = pitch;
            Yaw = yaw;
            Roll = roll;
        }
    }
}
