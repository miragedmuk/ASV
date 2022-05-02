using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVStructureOptions
    {
        public bool Terminals { get; set; } = false;
        public bool Glitches { get; set; } = false;
        public bool ChargeNodes { get; set; } = false;
        public bool BeaverDams { get; set; } = false;
        public bool DeinoNests { get; set; } = false;
        public bool WyvernNests { get; set; } = false;
        public bool DrakeNests { get; set; } = false;
        public bool MagmaNests { get; set; } = false;
        public bool OilVeins { get; set; } = false;
        public bool WaterVeins { get; set; } = false;
        public bool GasVeins { get; set; } = false;
        public bool Artifacts { get; set; } = false;

        public override bool Equals(object obj)
        {
            if (obj is ASVStructureOptions compareTo)
            {
                return this.Terminals == compareTo.Terminals
                    && this.Glitches == compareTo.Glitches
                    && this.ChargeNodes == compareTo.ChargeNodes
                    && this.BeaverDams == compareTo.BeaverDams
                    && this.DeinoNests == compareTo.DeinoNests
                    && this.WyvernNests == compareTo.WyvernNests
                    && this.DrakeNests == compareTo.DrakeNests
                    && this.MagmaNests == compareTo.MagmaNests
                    && this.OilVeins == compareTo.OilVeins
                    && this.WaterVeins == compareTo.WaterVeins
                    && this.GasVeins == compareTo.GasVeins
                    && this.Artifacts == compareTo.Artifacts;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 773983307;
            hashCode = hashCode * -1521134295 + Terminals.GetHashCode();
            hashCode = hashCode * -1521134295 + Glitches.GetHashCode();
            hashCode = hashCode * -1521134295 + ChargeNodes.GetHashCode();
            hashCode = hashCode * -1521134295 + BeaverDams.GetHashCode();
            hashCode = hashCode * -1521134295 + DeinoNests.GetHashCode();
            hashCode = hashCode * -1521134295 + WyvernNests.GetHashCode();
            hashCode = hashCode * -1521134295 + DrakeNests.GetHashCode();
            hashCode = hashCode * -1521134295 + MagmaNests.GetHashCode();
            hashCode = hashCode * -1521134295 + OilVeins.GetHashCode();
            hashCode = hashCode * -1521134295 + WaterVeins.GetHashCode();
            hashCode = hashCode * -1521134295 + GasVeins.GetHashCode();
            hashCode = hashCode * -1521134295 + Artifacts.GetHashCode();
            return hashCode;
        }
    }
}
