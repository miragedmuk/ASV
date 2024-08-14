using ARKViewer.Configuration;
using ARKViewer.Models;
using CoreRCON;
using CoreRCON.Parsers.Standard;
using FluentFTP;
using Renci.SshNet;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ARKViewer
{
    public partial class frmFtpFileBrowser : Form
    {
        public ServerConfiguration SelectedServer { get; set; } = null;

        string lastPath = "";
        FtpClient ftpClient = null;
        SftpClient sftpClient = null;


        private void ownerDrawCombo_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;

            e.DrawBackground();

            Rectangle r1 = e.Bounds;
            r1.Width = r1.Width;

            using (SolidBrush sb = new SolidBrush(comboBox.ForeColor))
            {
                string drawText = comboBox.Items[e.Index].ToString();
                e.Graphics.DrawString(drawText, e.Font, sb, r1);
            }
        }
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



        public frmFtpFileBrowser()
        {
            InitializeComponent();
            LoadWindowSettings();
        }

        public frmFtpFileBrowser(ServerConfiguration selectedConfig)
        {
            InitializeComponent();

            SelectedServer = selectedConfig;
            txtServerName.Text = SelectedServer.Name;
            txtFTPAddress.Text = SelectedServer.Address;
            txtFTPUsername.Text = SelectedServer.Username;
            txtFTPPassword.Text = SelectedServer.Password;
            udFTPPort.Value = SelectedServer.Port;
            optFtpModeSftp.Checked = SelectedServer.Mode == 1;
            optFtpModeFtp.Checked = SelectedServer.Mode == 0;
            chkPasswordVisibility.Visible = false;
            txtRconServer.Text = SelectedServer.RCONServerIP ?? "";
            txtRconPassword.Text = SelectedServer.RCONPassword ?? "";
            udRconPort.Value = SelectedServer.RCONPort != 0 ? SelectedServer.RCONPort : 27020;
        }


        private void frmFtpFileBrowser_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateWindowSettings();
        }

        private void PopulateServerFileListFtp(string filePath)
        {

            lvwFileBrowser.Items.Clear();

            try
            {
                var serverFiles = ftpClient.GetListing(filePath).OrderByDescending(o => o.Type).ThenBy(o => o.Name).ToList();

                if (filePath.Length > 0 && filePath != "/")
                {

                    int lastPathSeperator = filePath.LastIndexOf("/");
                    if (lastPathSeperator > 0)
                    {
                        lastPath = filePath.Substring(0, lastPathSeperator);
                    }
                    else
                    {
                        lastPath = @"/";
                    }

                    var browseUp = new ASVFtpItem()
                    {
                        FullName = lastPath,
                        Name = @"..\",
                        IsFolder = true
                    };

                    ListViewItem upFolderItem = lvwFileBrowser.Items.Add("..");
                    upFolderItem.SubItems.Add("");
                    upFolderItem.SubItems.Add("");
                    upFolderItem.ImageIndex = 0;
                    upFolderItem.Tag = browseUp;


                }

                serverFiles.ForEach(f =>
                {


                    var browseItem = new ASVFtpItem()
                    {
                        FullName = f.FullName,
                        Name = f.Name,
                        IsFolder = f.Type == FtpObjectType.Directory
                    };

                    ListViewItem item = lvwFileBrowser.Items.Add(f.Name);
                    item.SubItems.Add(f.Modified.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(f.Type.ToString());
                    switch (f.Type)
                    {
                        case FtpObjectType.Directory:
                            item.ImageIndex = 1;
                            break;

                        case FtpObjectType.File:
                            item.ImageIndex = 2;
                            break;
                    }
                    item.Tag = browseItem;

                });
            }
            catch
            {
                MessageBox.Show("Failed to retrieve file information from server.\n\nPlease re-connect and try again.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConnect.Enabled = true;
            }

        }

        private void PopulateServerFileListSFtp(string filePath)
        {


            lvwFileBrowser.Items.Clear();

            try
            {
                //var serverFiles1 = sftpClient.ListDirectory(filePath).OrderByDescending(o => o.IsDirectory).ThenBy(o => o.Name).ToList();

                var serverFiles = sftpClient.ListDirectory(filePath).Where(f => f.Name != "." && f.Name != "..").OrderByDescending(o => o.IsDirectory).ThenBy(o => o.Name).ToList();

                if (filePath.Length > 0 && filePath != "/")
                {

                    int lastPathSeperator = filePath.LastIndexOf("/");
                    if (lastPathSeperator > 0)
                    {
                        lastPath = filePath.Substring(0, lastPathSeperator);
                    }
                    else
                    {
                        lastPath = @"/";
                    }

                    var browseUp = new ASVFtpItem()
                    {
                        FullName = lastPath,
                        Name = @"..\",
                        IsFolder = true
                    };

                    ListViewItem upFolderItem = lvwFileBrowser.Items.Add("..");
                    upFolderItem.SubItems.Add("");
                    upFolderItem.SubItems.Add("");
                    upFolderItem.ImageIndex = 0;
                    upFolderItem.Tag = browseUp;


                }

                serverFiles.ForEach(f =>
                {


                    var browseItem = new ASVFtpItem()
                    {
                        FullName = f.FullName,
                        Name = f.Name,
                        IsFolder = f.IsDirectory
                    };

                    ListViewItem item = lvwFileBrowser.Items.Add(f.Name);
                    item.SubItems.Add(f.LastWriteTimeUtc.ToString("yyyy-MM-dd HH:mm:ss"));
                    item.SubItems.Add(f.LastWriteTimeUtc.ToString());
                    item.ImageIndex = f.IsDirectory ? 1 : 2;
                    item.Tag = browseItem;
                });
            }
            catch
            {
                MessageBox.Show("Failed to retrieve file information from server.\n\nPlease re-connect and try again.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConnect.Enabled = true;
            }

        }

        private void PopulateServerFileList(string filePath)
        {
            if (optFtpModeSftp.Checked)
            {
                //use sftp
                PopulateServerFileListSFtp(filePath);

            }
            else
            {
                //use normal ftp
                PopulateServerFileListFtp(filePath);
            }


        }

        private void lvwFileBrowser_DoubleClick(object sender, EventArgs e)
        {
            lvwFileBrowser.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            if (lvwFileBrowser.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwFileBrowser.SelectedItems[0];
            ASVFtpItem browseItem = (ASVFtpItem)selectedItem.Tag;

            if (browseItem.IsFolder)
            {

                PopulateServerFileList(browseItem.FullName);

            }
            else
            {

            }
            this.Cursor = Cursors.Default;
            lvwFileBrowser.Enabled = true;

        }

        private void chkPasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            txtFTPPassword.PasswordChar = chkPasswordVisibility.Checked ? '\0' : '●';
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtServerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a name for this server.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtServerName.Focus();

                return;
            }

            if (txtFTPAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid address for this server.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFTPAddress.Focus();

                return;
            }

            if (txtFTPUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter valid user credentials for this server.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFTPUsername.Focus();

                return;
            }


            if (txtFTPPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter valid user credentials for this server.", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFTPPassword.Focus();

                return;
            }

            btnConnect.Enabled = false;
            optFtpModeFtp.Enabled = false;
            optFtpModeSftp.Enabled = false;

            this.Cursor = Cursors.WaitCursor;

            lvwFileBrowser.Items.Clear();
            lvwFileBrowser.Enabled = false;
            btnSelect.Enabled = false;


            if (optFtpModeFtp.Checked)
            {
                lblStatus.Text = "Attempting to connect...";
                lblStatus.Refresh();

                try
                {

                    btnConnect.Enabled = false;

                    lvwFileBrowser.Enabled = true;
                    txtServerName.Enabled = false;
                    txtFTPAddress.Enabled = false;
                    udFTPPort.Enabled = false;

                    FtpConfig c = new FtpConfig();
                    c.ConnectTimeout = Program.ProgramConfig.FtpTimeout; //5 mins
                    c.DataConnectionConnectTimeout = Program.ProgramConfig.FtpTimeout; //5 mins
                    c.DataConnectionReadTimeout = Program.ProgramConfig.FtpTimeout; //5 mins
                    c.ReadTimeout = Program.ProgramConfig.FtpTimeout; //5 mins

                    ftpClient = new FtpClient(txtFTPAddress.Text);
                    ftpClient.Config = c;

                    ftpClient.Credentials.UserName = txtFTPUsername.Text;
                    ftpClient.Credentials.Password = txtFTPPassword.Text;
                    ftpClient.Port = (int)udFTPPort.Value;

                    ftpClient.ValidateCertificate += FtpClient_ValidateCertificate1;


                    ftpClient.AutoConnect();


                    //not found, please select
                    lblStatus.Text = "Please select your save game.";
                    lblStatus.Refresh();

                    PopulateServerFileList("/");



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to connect to server.\n\n{ex.Message}.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnConnect.Enabled = true;
                    optFtpModeFtp.Enabled = true;
                    optFtpModeSftp.Enabled = true;
                }



            }
            else
            {

                lblStatus.Text = "Attempting to connect...";
                lblStatus.Refresh();

                try
                {
                    sftpClient = new SftpClient(txtFTPAddress.Text, (int)udFTPPort.Value, txtFTPUsername.Text, txtFTPPassword.Text);
                    sftpClient.OperationTimeout = new TimeSpan(0, 0, 0, 0, Program.ProgramConfig.FtpTimeout);
                    sftpClient.Connect();
                    btnConnect.Enabled = false;

                    lvwFileBrowser.Enabled = true;
                    txtServerName.Enabled = false;
                    txtFTPAddress.Enabled = false;
                    udFTPPort.Enabled = false;

                    lblStatus.Text = "Please select your save game.";
                    lblStatus.Refresh();

                    PopulateServerFileList("/");
                }
                catch
                {
                    MessageBox.Show("Unable to connect to server.\n\nPlease check entered information and try again.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnConnect.Enabled = true;
                    optFtpModeFtp.Enabled = true;
                    optFtpModeSftp.Enabled = true;
                }

            }

            this.Cursor = Cursors.Default;

            optFtpModeFtp.Enabled = true;
            optFtpModeSftp.Enabled = true;
        }

        private void FtpClient_ValidateCertificate1(FluentFTP.Client.BaseClient.BaseFtpClient control, FtpSslValidationEventArgs e)
        {
            e.Accept = true;
        }


        private void lvwFileBrowser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFileBrowser.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = lvwFileBrowser.SelectedItems[0];
            ASVFtpItem browseItem = (ASVFtpItem)selectedItem.Tag;
            btnSelect.Enabled = browseItem.FullName.EndsWith(".ark") || browseItem.FullName.EndsWith(".gz") || browseItem.FullName.EndsWith(".asv");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvwFileBrowser.SelectedItems.Count == 0) return;
            ListViewItem selectedItem = lvwFileBrowser.SelectedItems[0];
            ASVFtpItem browseItem = (ASVFtpItem)selectedItem.Tag;

            string selectedArkFilename = browseItem.FullName.Substring(0, browseItem.FullName.LastIndexOf('/'));
            string mapName = browseItem.Name;

            SelectedServer = new ServerConfiguration()
            {
                Name = txtServerName.Text,
                Address = txtFTPAddress.Text,
                SaveGamePath = selectedArkFilename,
                Username = txtFTPUsername.Text,
                Password = txtFTPPassword.Text,
                Port = (int)udFTPPort.Value,
                Map = mapName,
                Mode = optFtpModeFtp.Checked ? 0 : 1,
                RCONServerIP = txtRconServer.Text.Trim(),
                RCONPassword = txtRconPassword.Text.Trim(),
                RCONPort = (int)udRconPort.Value
            };
        }

        private void txtFTPAddress_Validating(object sender, CancelEventArgs e)
        {
            string enteredAddress = txtFTPAddress.Text.Trim();
            if (enteredAddress.StartsWith("ftp:"))
            {
                optFtpModeFtp.Checked = true;
                txtFTPAddress.Text = enteredAddress.Replace("ftp://", "");
            }
            if (enteredAddress.StartsWith("sftp:"))
            {
                optFtpModeSftp.Checked = true;
                enteredAddress = enteredAddress.Replace("ftps://", "");
            }
            if (enteredAddress.Contains(":"))
            {
                string portPart = enteredAddress.Substring(enteredAddress.LastIndexOf(":") + 1);
                int.TryParse(portPart, out int enteredPort);
                udFTPPort.Value = enteredPort;
                txtFTPAddress.Text = enteredAddress.Substring(0, enteredAddress.LastIndexOf(":"));
            }
        }

        private void txtFTPPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFTPPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private async void btnTestRcon_Click(object sender, EventArgs e)
        {
            if (txtRconServer.TextLength == 0)
            {
                MessageBox.Show("Please enter the IP address of RCON server.", "Missing information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtRconPassword.TextLength == 0)
            {
                MessageBox.Show("Please enter password for RCON server.", "Missing information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IPAddress.TryParse(txtRconServer.Text, out IPAddress ipAddress))
            {
                using (RCON client = new RCON(ipAddress, (ushort)udRconPort.Value, txtRconPassword.Text))
                {
                    try
                    {
                        await client.ConnectAsync();

                        MessageBox.Show("RCON connected successfully.", "Connection established.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch
                    {
                        MessageBox.Show("Unable to connect to RCON server.\n\nPlease check details and try again.", "Connection failed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid entry for RCON server. Expected IP address.", "Incorrect information.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}
