namespace BetterFolderBrowserPreview.Tests
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpLibrarySettings = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseRootFolder = new System.Windows.Forms.Button();
            this.txtRootFolder = new System.Windows.Forms.TextBox();
            this.txtDialogTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAllowMultiselect = new System.Windows.Forms.CheckBox();
            this.lblObservableTextsDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lstSelectedFolders = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.betterFolderBrowser1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLibrarySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.grpLibrarySettings);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblOptions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 393);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 6F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(217, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 11);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dialog component";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // grpLibrarySettings
            // 
            this.grpLibrarySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLibrarySettings.Controls.Add(this.label4);
            this.grpLibrarySettings.Controls.Add(this.btnChooseRootFolder);
            this.grpLibrarySettings.Controls.Add(this.txtRootFolder);
            this.grpLibrarySettings.Controls.Add(this.txtDialogTitle);
            this.grpLibrarySettings.Controls.Add(this.label2);
            this.grpLibrarySettings.Controls.Add(this.label1);
            this.grpLibrarySettings.Controls.Add(this.label3);
            this.grpLibrarySettings.Controls.Add(this.chkAllowMultiselect);
            this.grpLibrarySettings.Controls.Add(this.lblObservableTextsDesc);
            this.grpLibrarySettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibrarySettings.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpLibrarySettings.Location = new System.Drawing.Point(26, 95);
            this.grpLibrarySettings.Name = "grpLibrarySettings";
            this.grpLibrarySettings.Size = new System.Drawing.Size(295, 281);
            this.grpLibrarySettings.TabIndex = 5;
            this.grpLibrarySettings.TabStop = false;
            this.grpLibrarySettings.Text = "Change browser dialog settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(34, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "When enabled, this option allows \r\nmultiple folders to be selected.";
            // 
            // btnChooseRootFolder
            // 
            this.btnChooseRootFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseRootFolder.ForeColor = System.Drawing.Color.Black;
            this.btnChooseRootFolder.Location = new System.Drawing.Point(250, 228);
            this.btnChooseRootFolder.Name = "btnChooseRootFolder";
            this.btnChooseRootFolder.Size = new System.Drawing.Size(29, 25);
            this.btnChooseRootFolder.TabIndex = 6;
            this.btnChooseRootFolder.Text = "...";
            this.btnChooseRootFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.btnChooseRootFolder, "Browse for a root folder...");
            this.btnChooseRootFolder.UseVisualStyleBackColor = true;
            this.btnChooseRootFolder.Click += new System.EventHandler(this.btnChooseRootFolder_Click);
            // 
            // txtRootFolder
            // 
            this.txtRootFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRootFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtRootFolder.BackColor = System.Drawing.Color.Gainsboro;
            this.txtRootFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtRootFolder.Location = new System.Drawing.Point(16, 228);
            this.txtRootFolder.Name = "txtRootFolder";
            this.txtRootFolder.Size = new System.Drawing.Size(231, 25);
            this.txtRootFolder.TabIndex = 6;
            this.txtRootFolder.Text = "C:\\";
            // 
            // txtDialogTitle
            // 
            this.txtDialogTitle.BackColor = System.Drawing.Color.White;
            this.txtDialogTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtDialogTitle.HideSelection = false;
            this.txtDialogTitle.Location = new System.Drawing.Point(16, 145);
            this.txtDialogTitle.Name = "txtDialogTitle";
            this.txtDialogTitle.Size = new System.Drawing.Size(263, 25);
            this.txtDialogTitle.TabIndex = 10;
            this.txtDialogTitle.Text = "Select a folder...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dialog Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Root Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(14, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "You may provide the dialog box title";
            // 
            // chkAllowMultiselect
            // 
            this.chkAllowMultiselect.AutoSize = true;
            this.chkAllowMultiselect.Checked = true;
            this.chkAllowMultiselect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowMultiselect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.chkAllowMultiselect.ForeColor = System.Drawing.Color.Black;
            this.chkAllowMultiselect.Location = new System.Drawing.Point(17, 33);
            this.chkAllowMultiselect.Name = "chkAllowMultiselect";
            this.chkAllowMultiselect.Size = new System.Drawing.Size(192, 21);
            this.chkAllowMultiselect.TabIndex = 1;
            this.chkAllowMultiselect.Text = "Allow folder multi-selection";
            this.chkAllowMultiselect.UseVisualStyleBackColor = true;
            this.chkAllowMultiselect.CheckedChanged += new System.EventHandler(this.chkAllowMultiselect_CheckedChanged);
            // 
            // lblObservableTextsDesc
            // 
            this.lblObservableTextsDesc.AutoSize = true;
            this.lblObservableTextsDesc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblObservableTextsDesc.ForeColor = System.Drawing.Color.DimGray;
            this.lblObservableTextsDesc.Location = new System.Drawing.Point(14, 207);
            this.lblObservableTextsDesc.Name = "lblObservableTextsDesc";
            this.lblObservableTextsDesc.Size = new System.Drawing.Size(240, 15);
            this.lblObservableTextsDesc.TabIndex = 8;
            this.lblObservableTextsDesc.Text = "Select the folder where browsing starts from";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(62)))), ((int)(((byte)(48)))));
            this.lblTitle.Location = new System.Drawing.Point(89, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 30);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "BetterFolderBrowser";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Segoe UI Semibold", 14.75F);
            this.lblOptions.ForeColor = System.Drawing.Color.Black;
            this.lblOptions.Location = new System.Drawing.Point(89, 44);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(84, 28);
            this.lblOptions.TabIndex = 6;
            this.lblOptions.Text = "Options";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectFolder.ForeColor = System.Drawing.Color.Black;
            this.btnSelectFolder.Location = new System.Drawing.Point(355, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(558, 52);
            this.btnSelectFolder.TabIndex = 13;
            this.btnSelectFolder.Text = "Select folder(s)";
            this.toolTip1.SetToolTip(this.btnSelectFolder, "Click to browse for folders to select...");
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lstSelectedFolders
            // 
            this.lstSelectedFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedFolders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSelectedFolders.FormattingEnabled = true;
            this.lstSelectedFolders.HorizontalScrollbar = true;
            this.lstSelectedFolders.Location = new System.Drawing.Point(355, 70);
            this.lstSelectedFolders.Name = "lstSelectedFolders";
            this.lstSelectedFolders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSelectedFolders.Size = new System.Drawing.Size(558, 314);
            this.lstSelectedFolders.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStatus.Location = new System.Drawing.Point(358, 211);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(552, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "The list of selected folders will appear here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betterFolderBrowser1
            // 
            this.betterFolderBrowser1.Multiselect = false;
            this.betterFolderBrowser1.RootFolder = "C:\\Users\\Kenboi\\Desktop\\Apps";
            this.betterFolderBrowser1.Title = "Please select a folder...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 393);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lstSelectedFolders);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetterFolderBrowser: Tests";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLibrarySettings.ResumeLayout(false);
            this.grpLibrarySettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.GroupBox grpLibrarySettings;
        private System.Windows.Forms.CheckBox chkAllowMultiselect;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRootFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObservableTextsDesc;
        private System.Windows.Forms.Button btnChooseRootFolder;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDialogTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstSelectedFolders;
        private System.Windows.Forms.Button btnSelectFolder;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
    }
}

