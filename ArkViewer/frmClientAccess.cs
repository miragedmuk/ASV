using ARKViewer.Configuration;
using ARKViewer.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmClientAccess : Form
    {
        public ApiUserConfiguration ClientConfig { get; set; } = new ApiUserConfiguration();
        ASVDataManager cm = null;


        private void LoadWindowSettings()
        {
            var savedWindow = ARKViewer.Program.ProgramConfig.Windows.FirstOrDefault(w => w.Name == this.Name);

            if (savedWindow != null)
            {
                var targetScreen = Screen.FromPoint(new Point(savedWindow.Left, savedWindow.Top));
                if (targetScreen == null) return;

                if (targetScreen.DeviceName == null || targetScreen.DeviceName == savedWindow.Monitor)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Left = savedWindow.Left;
                    this.Top = savedWindow.Top;
                    this.Width = savedWindow.Width;
                    this.Height = savedWindow.Height;
                }
            }
        }

        private void UpdateWindowSettings()
        {
            //only save location if normal window, do not save location/size if minimized/maximized
            if (this.WindowState == FormWindowState.Normal)
            {
                var savedWindow = ARKViewer.Program.ProgramConfig.Windows.FirstOrDefault(w => w.Name == this.Name);
                if (savedWindow == null)
                {
                    savedWindow = new ViewerWindow();
                    savedWindow.Name = this.Name;
                    ARKViewer.Program.ProgramConfig.Windows.Add(savedWindow);
                }

                if (savedWindow != null)
                {
                    var restoreScreen = Screen.FromHandle(this.Handle);

                    savedWindow.Left = this.Left;
                    savedWindow.Top = this.Top;
                    savedWindow.Width = this.Width;
                    savedWindow.Height = this.Height;
                    savedWindow.Monitor = restoreScreen.DeviceName;

                }
            }
        }

        public frmClientAccess(ASVDataManager manager)
        {
            InitializeComponent();
            cm = manager;

            PopulateTribes();

            ClientConfig = new ApiUserConfiguration();
        }

        public frmClientAccess(ASVDataManager manager, ApiUserConfiguration editConfig) : this(manager)
        {
            ClientConfig = editConfig;

            //populate controls with selected config
            txtName.Text = ClientConfig.Name;
            txtAccessKey.Text = ClientConfig.AccessKey;
            chkAllowDroppedItems.Checked = ClientConfig.AllowDroppedContents;
            chkAllowMapInventories.Checked = ClientConfig.AllowGameInventories;
            chkAllowMapStructures.Checked = ClientConfig.AllowGameStructures;
            chkAllowTamed.Checked = ClientConfig.AllowTamedCreatures;
            chkAllowTribeStructures.Checked = ClientConfig.AllowTribeStructures;
            chkAllowWild.Checked = ClientConfig.AllowWildCreatures;

        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyAccessKey_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void PopulateTribes()
        {
            cboSelectedForTribeId.Items.Clear();
            cboSelectedForTribeId.Items.Add(new ASVComboValue("0", "[All Tribes]"));

            var tribes = cm.GetTribes(0);
            if (tribes != null && tribes.Count > 0)
            {
                foreach (var tribe in tribes.OrderBy(o => o.TribeName))
                {
                    cboSelectedForTribeId.Items.Add(new ASVComboValue(tribe.TribeId.ToString(), tribe.TribeName));
                }
                cboSelectedForTribeId.SelectedIndex = 0;
            }
        }

        private void PopulatePlayers()
        {
            cboSelectedForPlayerId.Items.Clear();
            cboSelectedForPlayerId.Items.Add(new ASVComboValue("0", "[All Players]"));
            if (cboSelectedForTribeId.SelectedItem != null)
            {
                ASVComboValue selectedValue = (ASVComboValue)cboSelectedForTribeId.SelectedItem;
                int.TryParse(selectedValue.Key, out int selectedTribeId);
                var tribePlayers = cm.GetTribes(selectedTribeId).SelectMany(t => t.Players).ToList();
                if (tribePlayers != null && tribePlayers.Count > 0)
                {
                    foreach (var player in tribePlayers.OrderBy(o => o.CharacterName))
                    {
                        cboSelectedForPlayerId.Items.Add(new ASVComboValue(player.Id.ToString(), player.CharacterName));
                    }
                }
            }

            cboSelectedForPlayerId.SelectedIndex = 0;

        }

        private void cboSelectedForTribeId_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePlayers();
        }

        private void btnCcancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
