using ASVPack.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkViewer
{
    public partial class ElevationControl : UserControl
    {
        enum ViewTypes
        {
            ViewTypeWild,
            ViewTypeTamed,
            ViewTypeItemSearch,
            ViewTypeDroppedItems,
            ViewTypeStructures,
            ViewTypeTribes,
            ViewTypePlayers
        }

        public float? FilterLatitude { get; set; }
        public float? FilterLongitude { get; set; }
        public float? FitlerRadius { get; set;}
        public string FilterClass { get; set; } = "";
        

        public ElevationControl()
        {
            InitializeComponent();
        }


        private void UpdateSelectedView(ViewTypes view)
        {
            if(cboView.SelectedIndex!=(int)view){
                cboView.SelectedIndex = (int)view;
            }
            
        }

        public void DrawTamed(List<ContentTamedCreature> tames, ContentTamedCreature selectedTame)
        {
            UpdateSelectedView(ViewTypes.ViewTypeTamed);
            DrawCreatures(tames.Cast<ContentCreature>().ToList(), selectedTame);
        }
        public void DrawWild(List<ContentWildCreature> wilds, ContentWildCreature selectedWild)
        {
            UpdateSelectedView(ViewTypes.ViewTypeWild);
            DrawCreatures(wilds.Cast<ContentCreature>().ToList(), selectedWild);
        }

        private void DrawCreatures(List<ContentCreature> creatures, ContentCreature selectedCreature)
        {
            var mapMargin = 5;
            var availableWidth = picMap.Width - (2 * mapMargin);
            var availableHeight = picMap.Height - (2 * mapMargin);

            var widthPerCreature = availableWidth / creatures.Count;

            var maxHeight = creatures.Max(c => c.Z);
            var minHeight = creatures.Min(c => c.Z);


            int currentCreatureIndex = 0;
            foreach(var creature in creatures)
            {
                var maxValue = Math.Abs((decimal)maxHeight) - Math.Abs((decimal)minHeight);
                var creatureX = (currentCreatureIndex * widthPerCreature) - (widthPerCreature / 2) + mapMargin;
                var creatureYPercent = ((creature.Z - minHeight) / float.MaxValue);
                var creatureY = mapMargin + (creatureYPercent * availableHeight);

                var creatureRect = new Rectangle(creatureX, (int)creatureY, widthPerCreature, widthPerCreature);
                

                currentCreatureIndex++;
            }

            if(selectedCreature != null)
            {

            }
        }


    }
}
