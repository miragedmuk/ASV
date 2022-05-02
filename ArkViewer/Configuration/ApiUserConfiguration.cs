using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Configuration
{
    [DataContract]
    public class ApiUserConfiguration
    {
        [DataMember] public DateTime Created { get; set; } = DateTime.Now; //time this user was added
        [DataMember] public DateTime Accessed { get; set; } = DateTime.MinValue; //time this user last made a request
        [DataMember] public string Name { get; set; } = ""; //user / account name
        [DataMember] public string AccessKey { get; set; } = ""; //unique access key to identify each user and their restrictions
        [DataMember] public bool AllowGameStructures { get; set; } = false; //local of nests/beaver dams etc.
        [DataMember] public bool AllowGameInventories { get; set; } = false; //content of nests/beaver dams etc.
        [DataMember] public bool AllowDroppedContents { get; set; } = false; //dropped items, death bags and corpses
        [DataMember] public bool AllowTamedCreatures { get; set; } = false; //tamed creatures
        [DataMember] public bool AllowWildCreatures { get; set; } = false; //wild creatures
        [DataMember] public bool AllowTribeStructures { get; set; } = false; //player built structures
        [DataMember] public int TribeId { get; set; } = 0; //restricted tribeId
        [DataMember] public int PlayerId { get; set; } = 0; //restricted playerId
        [DataMember] public decimal Latitude { get; set; } = 50; //restricted latitude
        [DataMember] public decimal Longitude { get; set; } = 50; //restricted longitude
        [DataMember] public decimal Radius { get; set; } = int.MaxValue; //restricted radius

    }
}
