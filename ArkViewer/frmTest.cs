using ARKViewer.Models;
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
    public partial class frmTest : Form
    {
        ASVDataManager cm = null;

        public frmTest(ASVDataManager manager)
        {
            InitializeComponent();
            cm = manager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elevationControl1.DrawWild(cm.GetWildCreatures(150, 150, 50, 50, 100, "", ""),null);
            

        }
    }
}
