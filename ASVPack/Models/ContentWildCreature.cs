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
            IsTameable = !gameObject.GetPropertyValue<bool>("bForceDisablingTaming",0,false);
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
                if (ClassName.Equals("Xenomorph_Character_BP_Female_C")) IsTameable = false; //reaper queen
                if (ClassName.Equals("Xenomorph_Character_BP_Male_Surface_C")) IsTameable = false; //reaper king (surface)
                if (ClassName.Contains("chupacabra", StringComparison.CurrentCultureIgnoreCase)) IsTameable = false; //nameless
                if (ClassName.Contains("pteroteuthis", StringComparison.CurrentCultureIgnoreCase)) IsTameable = false; //seeker
                //   
            }

            var geneTraits = gameObject.Properties.FirstOrDefault(p=>p.Name == "GeneTraits")?.Value;
            if (geneTraits != null)
            {
                foreach (string geneTrait in geneTraits)
                {
                    var openBracketPos = geneTrait.LastIndexOf("[");
                    var closeBracketPos = geneTrait.LastIndexOf("]");

                    var traitClass = geneTrait.Substring(0, openBracketPos);
                    var traitTier = int.Parse(geneTrait.Substring(openBracketPos + 1, closeBracketPos - openBracketPos - 1));

                    string traitName = string.Concat(traitClass.Replace("Inherit", ""), " (", traitTier + 1, ")");

                    Traits.Add(traitName);

                }

            }



        }

    }
}