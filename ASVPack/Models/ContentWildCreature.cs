using SavegameToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentWildCreature : ContentCreature
    {
        public ContentWildCreature() : base()
        {

        }

        public ContentWildCreature(GameObject gameObject, GameObject statusObject) : base(gameObject, statusObject)
        {

        }
    }
}