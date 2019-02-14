using System;
using System.Windows.Forms;

using WK.Libraries.BetterFolderBrowserNS;

namespace BetterFolderBrowserPreview.Tests
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtDialogTitle.SelectAll();
            txtDialogTitle.Focus();
        }

        public void SelectFolder()
        {
            betterFolderBrowser1.Title = txtDialogTitle.Text;
            betterFolderBrowser1.RootFolder = txtRootFolder.Text;
            betterFolderBrowser1.Multiselect = chkAllowMultiselect.Checked;
            
            if (betterFolderBrowser1.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Hide();
                lstSelectedFolders.Items.AddRange(betterFolderBrowser1.SelectedPaths);
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }

        private void chkAllowMultiselect_CheckedChanged(object sender, EventArgs e)
        {
            betterFolderBrowser1.Multiselect = chkAllowMultiselect.Checked;
        }

        private void btnChooseRootFolder_Click(object sender, EventArgs e)
        {
            BetterFolderBrowser bfb = new BetterFolderBrowser();
            bfb.Title = "Choose any folder as the root folder...";
            bfb.RootFolder = @"C:\";
            
            if (bfb.ShowDialog() == DialogResult.OK)
                txtRootFolder.Text = bfb.SelectedPath;
        }
    }
}
