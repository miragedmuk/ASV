using ASVPack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVBreedingResult
    {
        public ContentCreature Creature { get; set; } = null;

        public decimal RankHp { get; set; } = 0;
        public decimal RankStamina { get; set; } = 0;
        public decimal RankMelee { get; set; } = 0;
        public decimal RankWeight { get; set; } = 0;
        public decimal RankSpeed { get; set; } = 0;
        public decimal RankFood { get; set; } = 0;
        public decimal RankOxygen { get; set; } = 0;
        public decimal RankCrafting { get; set; } = 0;
        public decimal RankCombined { get; set; } = 0;
        public decimal RankColours { get; set; } = 0;
        public decimal MaxRank { get; set; } = 100;


        public ASVBreedingResult(ContentTamedCreature tamedCreature, ContentCreature potentialMate, ASVBreedingSearch rankCriteria)
        {
            decimal statPointValue = 10;
            decimal colorPointValue = 5;
            MaxRank = (statPointValue * 8) + (colorPointValue * 6);
            Creature = potentialMate;
            RankCombined = 0;

            //assign points based on how close to the ranges they match

            int tameStat = 0;
            int potentialStat = 0;
            int difference = 0;

            //calculate some points based on max range
            decimal pointAllocation = 0;
            decimal pointRatio = 0;

            //hp
            tameStat = tamedCreature.BaseStats[0];
            potentialStat = potentialMate.BaseStats[0];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeHp) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if(pointRatio  >0) RankCombined += pointAllocation;
            RankHp = pointRatio * 100;


            //stamina
            tameStat = tamedCreature.BaseStats[1];
            potentialStat = potentialMate.BaseStats[1];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeStamina) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankStamina = pointRatio * 100;


            //melee
            tameStat = tamedCreature.BaseStats[8];
            potentialStat = potentialMate.BaseStats[8];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeMelee) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankMelee = pointRatio * 100;

            //weight
            tameStat = tamedCreature.BaseStats[7];
            potentialStat = potentialMate.BaseStats[7];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeWeight) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankWeight = pointRatio * 100;

            //speed
            tameStat = tamedCreature.BaseStats[9];
            potentialStat = potentialMate.BaseStats[9];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeWeight) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankSpeed = pointRatio * 100;

            //food
            tameStat = tamedCreature.BaseStats[4];
            potentialStat = potentialMate.BaseStats[4];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeFood) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankFood = pointRatio * 100;


            //oxygen
            tameStat = tamedCreature.BaseStats[3];
            potentialStat = potentialMate.BaseStats[3];
            difference = tameStat - potentialStat;
            pointRatio = 1 - ((((decimal)difference * 100) / (decimal)rankCriteria.RangeOxygen) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankOxygen = pointRatio * 100;


            //crafting
            tameStat = tamedCreature.BaseStats[11];
            potentialStat = potentialMate.BaseStats[11];
            difference = tameStat - potentialStat;
            pointRatio = 1 - (((decimal)difference * 100) / (decimal)100);
            pointAllocation = pointRatio * statPointValue;
            if (pointRatio > 0) RankCombined += pointAllocation;
            RankCrafting = pointRatio * 100;

            RankColours = 0;

            //add points for colour matches
            if (rankCriteria.ColoursRegion0.Any(c=> c == potentialMate.Colors[0]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
            if (rankCriteria.ColoursRegion1.Any(c => c == potentialMate.Colors[1]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
            if (rankCriteria.ColoursRegion2.Any(c => c == potentialMate.Colors[2]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
            if (rankCriteria.ColoursRegion3.Any(c => c == potentialMate.Colors[3]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
            if (rankCriteria.ColoursRegion4.Any(c => c == potentialMate.Colors[4]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
            if (rankCriteria.ColoursRegion5.Any(c => c == potentialMate.Colors[5]))
            {
                RankCombined += colorPointValue;
                RankColours += 100m / 6m;
            }
        }


    }
}
