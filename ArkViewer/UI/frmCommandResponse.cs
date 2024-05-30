using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkViewer.UI
{
    public partial class frmCommandResponse : Form
    {
        public frmCommandResponse(string serverResponse)
        {
            InitializeComponent();

            rtbResponse.Text = serverResponse;
        }
    }
}
