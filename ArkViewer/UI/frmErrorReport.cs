using System.Drawing;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmErrorReport : Form
    {
        public frmErrorReport(string errorMessage, string stackTrace)
        {
            InitializeComponent();

            string saveFile = Program.LastLoadedSaveFilename;

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
    }
}
