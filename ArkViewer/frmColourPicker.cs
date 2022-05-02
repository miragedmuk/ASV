using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmColourPicker : Form
    {
        public int ColourId { get; set; } = 0;

        public frmColourPicker()
        {
            InitializeComponent();
            PopulateColours();
        }

        private void chkApplyFilterColours_CheckedChanged(object sender, EventArgs e)
        {
            txtFilterColour.Enabled = !chkApplyFilterColours.Checked;
            if (!chkApplyFilterColours.Checked)
            {
                txtFilterColour.Text = string.Empty;
                PopulateColours();
                txtFilterColour.Focus();
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                lvwColours.BeginUpdate();
                int lastIndex = lvwColours.Items.Count - 1;
                for (int currentIndex = lastIndex; currentIndex >= 0; currentIndex--)
                {
                    ListViewItem item = lvwColours.Items[currentIndex];
                    bool shouldKeep = false;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(txtFilterColour.Text.ToLower()))
                        {
                            shouldKeep = true;
                            break;
                        }
                    }

                    if (!shouldKeep)
                    {
                        lvwColours.Items.Remove(item);
                    }
                }
                lvwColours.EndUpdate();

                this.Cursor = Cursors.Default;
            }

            btnSave.Enabled = lvwColours.SelectedItems.Count > 0;
        }

        private void PopulateColours()
        {
            this.Cursor = Cursors.WaitCursor;

            //populate class map
            lvwColours.Items.Clear();
            lvwColours.Refresh();
            lvwColours.BeginUpdate();
            if (Program.ProgramConfig.ColourMap.Count > 0)
            {
                foreach (var colourMap in Program.ProgramConfig.ColourMap.OrderBy(d => d.Id))
                {
                    ListViewItem newItem = lvwColours.Items.Add(colourMap.Id.ToString());
                    newItem.UseItemStyleForSubItems = false;
                    newItem.SubItems.Add(colourMap.Hex);
                    newItem.SubItems.Add("");
                    newItem.SubItems[2].BackColor = colourMap.Color;
                    newItem.Tag = colourMap;
                }

            }

            lvwColours.EndUpdate();

            btnSave.Enabled = lvwColours.SelectedItems.Count == 1;

            this.Cursor = Cursors.Default;
        }

        private void lvwColours_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = lvwColours.SelectedItems.Count > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int.TryParse(lvwColours.SelectedItems[0].Text, out int colourId);
            ColourId = colourId;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
