using AsaSavegameToolkit;
using ASVPack.Extensions;
using SavegameToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentWildCreature : ContentCreature
    {
        public bool IsTameable { get; set; } = true; 

        public ContentWildCreature(): base()
        {

        }

        public ContentWildCreature(GameObject gameObject, GameObject statusObject) : base(gameObject, statusObject)
        {
            IsTameable = !gameObject.GetPropertyValue<bool>("bForceDisablingTaming");
            if(ClassName.StartsWith("Mega")) 
            {
                if (Regex.IsMatch(ClassName, "Mega[A-Z]") || ClassName.StartsWith("Mega_")) IsTameable = false;
            }
            else
            {
                if (ClassName.Contains("Mega_") || ClassName.Contains("Alpha_")) IsTameable = false;
            }
        }

        public ContentWildCreature(AsaGameObject gameObject, AsaGameObject statusObject) : base(gameObject, statusObject)
        {
            IsTameable = !gameObject.GetPropertyValue<bool>("bForceDisablingTaming",0,false)??false;
            if (ClassName.StartsWith("Mega"))
            {
                if (Regex.IsMatch(ClassName, "Mega[A-Z]") || ClassName.StartsWith("Mega_")) IsTameable = false;
            }
            else
            {
                if (ClassName.Contains("Mega_") || ClassName.Contains("Alpha_")) IsTameable = false;
            }

        }

    }
}