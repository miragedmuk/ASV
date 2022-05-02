using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using ASVPack.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmStructureExclusionFilter : Form
    {
        private List<ContentStructure> playerStructures = new List<ContentStructure>();
        private List<string> currentExclusions = new List<string>();


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



        public frmStructureExclusionFilter(List<ContentStructure> structures)
        {
            InitializeComponent();
            LoadWindowSettings();

            playerStructures = structures;
            currentExclusions = Program.ProgramConfig.StructureExclusions;

            PopulateStructures();
        }

        private void PopulateStructures()
        {
            if (playerStructures == null) return;
            if (playerStructures.Count == 0) return;

            var playerStructureTypes = playerStructures
                                            .GroupBy(g => g.ClassName)
                                            .Select(s => s.Key);


            lstStructureFilter.Items.Clear();
            foreach (var className in playerStructureTypes)
            {
                var structureName = className;
                StructureClassMap itemMap = Program.ProgramConfig.StructureMap.Where(i => i.ClassName == className).FirstOrDefault();
                if (itemMap != null && itemMap.FriendlyName.Length > 0)
                {
                    structureName = itemMap.FriendlyName;
                }

                if (className.ToLower().Contains(txtFilter.Text.ToLower()) || structureName.ToLower().Contains(txtFilter.Text.ToLower()))
                {
                    int newIndex = lstStructureFilter.Items.Add(new ASVComboValue() { Key = className, Value = structureName });
                    lstStructureFilter.SetItemChecked(newIndex, Program.ProgramConfig.StructureExclusions.Contains(className));
                }
            }

            //add rafts
            int itemIndex = lstStructureFilter.Items.Add(new ASVComboValue() { Key = "Raft_BP_C", Value = "Raft" });
            lstStructureFilter.SetItemChecked(itemIndex, Program.ProgramConfig.StructureExclusions.Contains("Raft_BP_C"));

            itemIndex = lstStructureFilter.Items.Add(new ASVComboValue() { Key = "MotorRaft_BP_C", Value = "Motorboat" });
            lstStructureFilter.SetItemChecked(itemIndex, Program.ProgramConfig.StructureExclusions.Contains("MotorRaft_BP_C"));

            lstStructureFilter.Sorted = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Program.ProgramConfig.StructureExclusions = currentExclusions;
        }

        private void chkApplyFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApplyFilter.Checked)
            {
                txtFilter.Enabled = false;
            }
            else
            {
                txtFilter.Enabled = true;
                txtFilter.Text = string.Empty;
                txtFilter.Focus();
            }

            PopulateStructures();
        }

        private void UpdateCheckState()
        {
            if (lstStructureFilter.SelectedIndex >= 0)
            {
                int selectedIndex = lstStructureFilter.SelectedIndex;
                bool currentCheck = lstStructureFilter.GetItemChecked(selectedIndex);
                currentCheck = !currentCheck;
                lstStructureFilter.SetItemChecked(selectedIndex, currentCheck);

            }
        }

        private void lstStructureFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (lstStructureFilter.SelectedIndex >= 0)
            {

                ASVComboValue comboValue = (ASVComboValue)lstStructureFilter.Items[e.Index];
                if (e.NewValue == CheckState.Checked)
                {
                    if (!currentExclusions.Contains(comboValue.Key))
                    {
                        currentExclusions.Add(comboValue.Key);
                    }
                }
                else
                {
                    if (currentExclusions.Contains(comboValue.Key))
                    {
                        currentExclusions.Remove(comboValue.Key);
                    }
                }


            }
        }

        private void frmStructureExclusionFilter_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }
    }
}
