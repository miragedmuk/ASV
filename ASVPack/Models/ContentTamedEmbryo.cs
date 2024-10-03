using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    public class ContentTamedEmbryo: ContentTamedCreature
    {
        public ContentTamedEmbryo(AsaGameObject container, AsaGameObject embryoData) 
        {
            IsEmbryo = true;
            IsBaby=true;
            IsClaimed=true;
            
            DinoId = embryoData.Guid.ToString();
            var customDataSet = embryoData.Properties.First(p=>p.Name=="CustomItemDatas").Value;
            if (customDataSet != null)
            {
                foreach (var customData in customDataSet)
                {
                    var objectList = customData as List<object>;
                    var propertyList = objectList.Cast<AsaProperty<dynamic>>();                    
                    string customName = propertyList.FirstOrDefault(p=>p.Name=="CustomDataName")?.Value??"";
                    switch (customName)
                    {
                        case "CustomEmbryoData":

                            ClassName = "";



                            break;

                        default:
                            break;

                    }


                }
            }
            int genderOverride = embryoData.Properties.First(p => p.Name == "EggGenderOverride").Value;
            Gender = genderOverride == 2 ? "Male" : "Female";
            BaseLevel = 1;
            BaseStats = new byte[12];
            for (var i = 0; i < TamedStats.Length; i++)
            {
                var value = embryoData.Properties.FirstOrDefault(p => p.Name == "EggNumberOfLevelUpPointsApplied" && p.Position == i)?.Value ?? 0;
                BaseStats[i] = (byte)value;
                BaseLevel += (int)value;
            }





        }

    }
}
