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
    public partial class frmCommandInput : Form
    {
        public string EnteredValue { get; internal set; } = string.Empty;

        public frmCommandInput(string paramName)
        {
            InitializeComponent();

            lblParamName.Text = paramName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnteredValue = txtEnteredValue.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnteredValue = string.Empty;
        }
    }
}
