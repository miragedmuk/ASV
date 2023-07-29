using ARKViewer.Models;
using ARKViewer.Models.NameMap;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmGenericClassMap : Form
    {

        public IGenericClassMap ClassMap { get; set; } = null;

        IGenericClassMap LoadedClassMap { get; set; } = null;

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


        public frmGenericClassMap(IGenericClassMap selectedClassMap)
        {
            InitializeComponent();
            LoadWindowSettings();

            LoadedClassMap = selectedClassMap;
            ClassMap = selectedClassMap;
            txtClassName.Text = selectedClassMap.ClassName;
            txtDisplayName.Text = selectedClassMap.FriendlyName;





        }

        private void txtClassName_Validating(object sender, CancelEventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            ClassMap.ClassName = txtClassName.Text;
            ClassMap.FriendlyName = txtDisplayName.Text;

            if (ClassMap.ClassName.Length == 0)
            {
                MessageBox.Show("Please enter a class name for this class.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClassName.Focus();
                return;
            }
            else
            {
                if (LoadedClassMap.ClassName != ClassMap.ClassName)
                {
                    //name changed, check it doesn't arleady exist in the map
                    switch (LoadedClassMap)
                    {
                        case DinoClassMap dinoMap:
                            if (Program.ProgramConfig.DinoMap.Any(d => d.ClassName == ClassMap.ClassName))
                            {
                                MessageBox.Show("Please enter a unique class name for this class.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            break;
                        case StructureClassMap structureMap:

                            break;
                    }
                }

            }

            if (ClassMap.FriendlyName.Length == 0)
            {
                MessageBox.Show("Please enter a display name for this class.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDisplayName.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void frmGenericClassMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void frmGenericClassMap_Enter(object sender, EventArgs e)
        {

        }

        private void frmGenericClassMap_Load(object sender, EventArgs e)
        {

        }

        private void frmGenericClassMap_Shown(object sender, EventArgs e)
        {
            if (ClassMap.ClassName != null && ClassMap.ClassName.Length > 0)
            {
                txtDisplayName.Focus();
                txtDisplayName.SelectAll();
            }
        }
    }
}
