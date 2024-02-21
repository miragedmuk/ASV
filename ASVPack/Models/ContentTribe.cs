using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentTribe
    {
        [DataMember] public long TribeId { get; set; } = 0;
        [DataMember] public string TribeName { get; set; } = "";
        [DataMember] public bool IsSolo { get; set; } = false;


        [DataMember] public ConcurrentBag<ContentPlayer> Players { get; set; } = new ConcurrentBag<ContentPlayer>();
        [DataMember] public ConcurrentBag<ContentStructure> Structures { get; set; } = new ConcurrentBag<ContentStructure>();
        [DataMember] public ConcurrentBag<ContentTamedCreature> Tames { get; set; } = new ConcurrentBag<ContentTamedCreature>();
        [DataMember] public Dictionary<int, string> Members { get; set; } = new Dictionary<int, string>();

        [DataMember] public string[] Logs { get; set; } = new string[0];

        public DateTime TribeFileDate { get; set; } = DateTime.MinValue;

        public DateTime? LastActive
        {
            get
            {
                List<DateTime> possibleDates = new List<DateTime>();

                possibleDates.Add(TribeFileDate);
                var maxPlayer = Players.Max(p => p.LastActiveDateTime);
                if (maxPlayer != null && maxPlayer.HasValue) possibleDates.Add(maxPlayer.Value);
                    
                return possibleDates.Where(d=>d <= DateTime.Now).Max();
                


            }
        }
        public bool HasGameFile { get; set; } = false;
        public string TribeFileName { get; set; } = string.Empty;

        public ContentTribe(GameObject tribeObject)
        {
            PropertyStruct properties = (PropertyStruct)tribeObject.Properties[0];
            StructPropertyList propertyList = (StructPropertyList)properties.Value;

            TribeId = propertyList.GetPropertyValue<int>("TribeId");

            

            if (TribeId == 0) TribeId = propertyList.GetPropertyValue<int>("TribeID");
            TribeName = propertyList.GetPropertyValue<string>("TribeName");

            Members = new Dictionary<int, string>();
            
            var memberNames = (ArkArrayString)propertyList.GetTypedProperty<PropertyArray>("MembersPlayerName").Value; 
            var memberNumbers = (ArkArrayInt)propertyList.GetTypedProperty<PropertyArray>("MembersPlayerDataID").Value;

            for(int x = 0; x < memberNames.Count; x++)
            {
                Members.Add(memberNumbers[x], memberNames[x]);
            }


            //logs
            var tribeLogs = propertyList.GetTypedProperty<PropertyArray>("TribeLog");
            if (tribeLogs != null)
            {
                IArkArray<string> tribeLogProp = (IArkArray<string>)tribeLogs.Value;
                Logs = tribeLogProp.ToArray<string>();
            }
        }

        public ContentTribe()
        {

        }

        public ContentTribe(AsaObject tribeObject)
        {
            
            List<dynamic> propertyList = tribeObject.Properties[0].Value;
            if (propertyList != null)
            {

                TribeId = propertyList.FirstOrDefault(p=>((AsaProperty<dynamic>)p).Name == "TribeId")?.Value??0;
                if (TribeId == 0) TribeId = propertyList.FirstOrDefault(p=> ((AsaProperty<dynamic>)p).Name == "TribeID")?.Value??0;
                TribeName = propertyList.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "TribeName")?.Value??"";

                Members = new Dictionary<int, string>();
                Members = new Dictionary<int, string>();

                var memberNames = propertyList.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "MembersPlayerName")?.Value;
                var memberNumbers = propertyList.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "MembersPlayerDataID")?.Value;

                if (memberNames != null && memberNumbers!=null)
                {
                    for(int i = 0; i < memberNames.Count; i++)  
                    {
                        Members.Add((int)memberNumbers[i], (string)memberNames[i]);
                    }
                }

                var tribeLogs = propertyList.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "TribeLog")?.Value;
                if (tribeLogs != null)
                {
                    List<string> logLines = new List<string>();
                    foreach(var line in tribeLogs)
                    {
                        logLines.Add(line.ToString());
                    }
                 
                    Logs = logLines.ToArray();

                }
            }

        }

        public override bool Equals(object? obj)
        {
            if (obj is ContentTribe) return ((ContentTribe)obj).TribeId == TribeId;
            return false;
        }
        public override int GetHashCode()
        {
            return TribeId.GetHashCode();
        }
    }
}
