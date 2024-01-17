using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmErrorReport : Form
    {
        public frmErrorReport(string errorMessage, string stackTrace)
        {
            InitializeComponent();

            string saveFile = Program.LastLoadedSaveFilename;

            lblLogFilePath.Text = Path.Combine(System.AppContext.BaseDirectory, @"logs\asv.log");

            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Bold);
            rtbError.SelectedText = "Mode: ";
            rtbError.SelectionStart = rtbError.TextLength;
            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Regular);
            rtbError.SelectedText = Program.ProgramConfig.Mode.ToString() + "\n\n";
            rtbError.SelectionStart = rtbError.TextLength;

            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Bold);
            rtbError.SelectedText = "Save:\n";
            rtbError.SelectionStart = rtbError.TextLength;
            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Regular);
            rtbError.SelectedText = saveFile + "\n\n";
            rtbError.SelectionStart = rtbError.TextLength;


            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Bold);
            rtbError.SelectedText = "Message:\n";
            rtbError.SelectionStart = rtbError.TextLength;

            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Regular);
            rtbError.SelectedText = errorMessage + "\n\n";
            rtbError.SelectionStart = rtbError.TextLength;

            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Bold);
            rtbError.SelectedText = "Trace:\n";
            rtbError.SelectionStart = rtbError.TextLength;

            rtbError.SelectionFont = new Font(new FontFamily("Calibri"), 10, FontStyle.Regular);
            rtbError.SelectedText = stackTrace;
            rtbError.SelectionStart = rtbError.TextLength;



        }

        private void lblLogFilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFolder(System.AppContext.BaseDirectory);
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
        }

    }
}
