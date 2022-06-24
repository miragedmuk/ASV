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
    

    public partial class MapControl : UserControl
    {
        public float? FilterLatitude { get; set; }
        public float? FilterLongitude { get; set; }
        public float? FilterRadius { get; set; }


        public MapControl()
        {
            InitializeComponent();
            cboView.SelectedIndex = 0;
        }
    }
}
