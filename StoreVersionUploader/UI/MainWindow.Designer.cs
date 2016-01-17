namespace StoreVersionUploader
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbox_ProductId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_ProductZipFile = new System.Windows.Forms.TextBox();
            this.txtbox_ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ZipFile = new System.Windows.Forms.Label();
            this.btn_ZipFile = new System.Windows.Forms.Button();
            this.txtbox_Console = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_Version = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbox_VersionType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_Changelog = new System.Windows.Forms.TextBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.pbar_UploadProgress = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbox_APIKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AssignAPIKey = new System.Windows.Forms.Button();
            this.txtbox_APIKeyInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_ProductFolderPathInput = new System.Windows.Forms.TextBox();
            this.btn_FolderPath = new System.Windows.Forms.Button();
            this.dtg_ProductList = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_ProductIdInput = new System.Windows.Forms.TextBox();
            this.btn_AddProductName = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_ProductNameInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductList)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 495);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtbox_ProductId);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbox_ProductZipFile);
            this.tabPage1.Controls.Add(this.txtbox_ProductName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl_ZipFile);
            this.tabPage1.Controls.Add(this.btn_ZipFile);
            this.tabPage1.Controls.Add(this.txtbox_Console);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtbox_Version);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbox_VersionType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtbox_Changelog);
            this.tabPage1.Controls.Add(this.btn_Upload);
            this.tabPage1.Controls.Add(this.pbar_UploadProgress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Uploader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "ID:";
            // 
            // txtbox_ProductId
            // 
            this.txtbox_ProductId.Location = new System.Drawing.Point(8, 26);
            this.txtbox_ProductId.Name = "txtbox_ProductId";
            this.txtbox_ProductId.Size = new System.Drawing.Size(72, 20);
            this.txtbox_ProductId.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "ZIP Package:";
            // 
            // txtbox_ProductZipFile
            // 
            this.txtbox_ProductZipFile.Location = new System.Drawing.Point(134, 269);
            this.txtbox_ProductZipFile.Name = "txtbox_ProductZipFile";
            this.txtbox_ProductZipFile.ReadOnly = true;
            this.txtbox_ProductZipFile.Size = new System.Drawing.Size(120, 20);
            this.txtbox_ProductZipFile.TabIndex = 24;
            // 
            // txtbox_ProductName
            // 
            this.txtbox_ProductName.Location = new System.Drawing.Point(86, 26);
            this.txtbox_ProductName.Name = "txtbox_ProductName";
            this.txtbox_ProductName.Size = new System.Drawing.Size(199, 20);
            this.txtbox_ProductName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name:";
            // 
            // lbl_ZipFile
            // 
            this.lbl_ZipFile.AutoSize = true;
            this.lbl_ZipFile.Location = new System.Drawing.Point(149, 281);
            this.lbl_ZipFile.Name = "lbl_ZipFile";
            this.lbl_ZipFile.Size = new System.Drawing.Size(0, 13);
            this.lbl_ZipFile.TabIndex = 19;
            // 
            // btn_ZipFile
            // 
            this.btn_ZipFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZipFile.Location = new System.Drawing.Point(260, 270);
            this.btn_ZipFile.Name = "btn_ZipFile";
            this.btn_ZipFile.Size = new System.Drawing.Size(44, 23);
            this.btn_ZipFile.TabIndex = 14;
            this.btn_ZipFile.Text = "...";
            this.btn_ZipFile.UseVisualStyleBackColor = true;
            this.btn_ZipFile.Click += new System.EventHandler(this.btn_ZipFile_Click);
            // 
            // txtbox_Console
            // 
            this.txtbox_Console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtbox_Console.Location = new System.Drawing.Point(3, 315);
            this.txtbox_Console.Multiline = true;
            this.txtbox_Console.Name = "txtbox_Console";
            this.txtbox_Console.ReadOnly = true;
            this.txtbox_Console.Size = new System.Drawing.Size(424, 141);
            this.txtbox_Console.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Version:";
            // 
            // txtbox_Version
            // 
            this.txtbox_Version.Location = new System.Drawing.Point(291, 26);
            this.txtbox_Version.Name = "txtbox_Version";
            this.txtbox_Version.Size = new System.Drawing.Size(83, 20);
            this.txtbox_Version.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Version type:";
            // 
            // cmbox_VersionType
            // 
            this.cmbox_VersionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_VersionType.FormattingEnabled = true;
            this.cmbox_VersionType.Items.AddRange(new object[] {
            "Release",
            "Beta"});
            this.cmbox_VersionType.Location = new System.Drawing.Point(8, 269);
            this.cmbox_VersionType.Name = "cmbox_VersionType";
            this.cmbox_VersionType.Size = new System.Drawing.Size(93, 21);
            this.cmbox_VersionType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Changelog:";
            // 
            // txtbox_Changelog
            // 
            this.txtbox_Changelog.Location = new System.Drawing.Point(8, 74);
            this.txtbox_Changelog.Multiline = true;
            this.txtbox_Changelog.Name = "txtbox_Changelog";
            this.txtbox_Changelog.Size = new System.Drawing.Size(414, 161);
            this.txtbox_Changelog.TabIndex = 7;
            // 
            // btn_Upload
            // 
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Location = new System.Drawing.Point(341, 270);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(81, 29);
            this.btn_Upload.TabIndex = 4;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // pbar_UploadProgress
            // 
            this.pbar_UploadProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar_UploadProgress.Location = new System.Drawing.Point(3, 456);
            this.pbar_UploadProgress.Name = "pbar_UploadProgress";
            this.pbar_UploadProgress.Size = new System.Drawing.Size(424, 10);
            this.pbar_UploadProgress.TabIndex = 20;
            this.pbar_UploadProgress.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbox_APIKey);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btn_AssignAPIKey);
            this.tabPage2.Controls.Add(this.txtbox_APIKeyInput);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtbox_ProductFolderPathInput);
            this.tabPage2.Controls.Add(this.btn_FolderPath);
            this.tabPage2.Controls.Add(this.dtg_ProductList);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtbox_ProductIdInput);
            this.tabPage2.Controls.Add(this.btn_AddProductName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtbox_ProductNameInput);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbox_APIKey
            // 
            this.txtbox_APIKey.Location = new System.Drawing.Point(8, 71);
            this.txtbox_APIKey.Name = "txtbox_APIKey";
            this.txtbox_APIKey.ReadOnly = true;
            this.txtbox_APIKey.Size = new System.Drawing.Size(414, 20);
            this.txtbox_APIKey.TabIndex = 19;
            this.txtbox_APIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Your API Key:";
            // 
            // btn_AssignAPIKey
            // 
            this.btn_AssignAPIKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssignAPIKey.Location = new System.Drawing.Point(300, 25);
            this.btn_AssignAPIKey.Name = "btn_AssignAPIKey";
            this.btn_AssignAPIKey.Size = new System.Drawing.Size(81, 29);
            this.btn_AssignAPIKey.TabIndex = 17;
            this.btn_AssignAPIKey.Text = "Assign";
            this.btn_AssignAPIKey.UseVisualStyleBackColor = true;
            this.btn_AssignAPIKey.Click += new System.EventHandler(this.btn_AssignAPIKey_Click);
            // 
            // txtbox_APIKeyInput
            // 
            this.txtbox_APIKeyInput.Location = new System.Drawing.Point(8, 25);
            this.txtbox_APIKeyInput.Name = "txtbox_APIKeyInput";
            this.txtbox_APIKeyInput.Size = new System.Drawing.Size(277, 20);
            this.txtbox_APIKeyInput.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "New API Key:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Folder path:";
            // 
            // txtbox_ProductFolderPathInput
            // 
            this.txtbox_ProductFolderPathInput.Location = new System.Drawing.Point(8, 424);
            this.txtbox_ProductFolderPathInput.Name = "txtbox_ProductFolderPathInput";
            this.txtbox_ProductFolderPathInput.ReadOnly = true;
            this.txtbox_ProductFolderPathInput.Size = new System.Drawing.Size(215, 20);
            this.txtbox_ProductFolderPathInput.TabIndex = 13;
            // 
            // btn_FolderPath
            // 
            this.btn_FolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FolderPath.Location = new System.Drawing.Point(239, 422);
            this.btn_FolderPath.Name = "btn_FolderPath";
            this.btn_FolderPath.Size = new System.Drawing.Size(46, 23);
            this.btn_FolderPath.TabIndex = 12;
            this.btn_FolderPath.Text = "...";
            this.btn_FolderPath.UseVisualStyleBackColor = true;
            this.btn_FolderPath.Click += new System.EventHandler(this.btn_FolderPath_Click);
            // 
            // dtg_ProductList
            // 
            this.dtg_ProductList.AllowUserToAddRows = false;
            this.dtg_ProductList.AllowUserToDeleteRows = false;
            this.dtg_ProductList.AllowUserToResizeColumns = false;
            this.dtg_ProductList.AllowUserToResizeRows = false;
            this.dtg_ProductList.BackgroundColor = System.Drawing.Color.White;
            this.dtg_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPath});
            this.dtg_ProductList.GridColor = System.Drawing.Color.Gainsboro;
            this.dtg_ProductList.Location = new System.Drawing.Point(8, 134);
            this.dtg_ProductList.MultiSelect = false;
            this.dtg_ProductList.Name = "dtg_ProductList";
            this.dtg_ProductList.ReadOnly = true;
            this.dtg_ProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtg_ProductList.RowHeadersVisible = false;
            this.dtg_ProductList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtg_ProductList.Size = new System.Drawing.Size(414, 218);
            this.dtg_ProductList.TabIndex = 11;
            this.dtg_ProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ProductList_CellDoubleClick);
            this.dtg_ProductList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_ProductList_CellMouseClick);
            this.dtg_ProductList.SelectionChanged += new System.EventHandler(this.dtg_ProductList_SelectionChanged);
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productId.FillWeight = 42.6396F;
            this.productId.HeaderText = "ID";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.FillWeight = 155.8464F;
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPath
            // 
            this.productPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productPath.FillWeight = 101.5141F;
            this.productPath.HeaderText = "Path";
            this.productPath.Name = "productPath";
            this.productPath.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID:";
            // 
            // txtbox_ProductIdInput
            // 
            this.txtbox_ProductIdInput.Location = new System.Drawing.Point(8, 382);
            this.txtbox_ProductIdInput.Name = "txtbox_ProductIdInput";
            this.txtbox_ProductIdInput.Size = new System.Drawing.Size(72, 20);
            this.txtbox_ProductIdInput.TabIndex = 50;
            // 
            // btn_AddProductName
            // 
            this.btn_AddProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddProductName.Location = new System.Drawing.Point(300, 382);
            this.btn_AddProductName.Name = "btn_AddProductName";
            this.btn_AddProductName.Size = new System.Drawing.Size(81, 29);
            this.btn_AddProductName.TabIndex = 7;
            this.btn_AddProductName.Text = "Add";
            this.btn_AddProductName.UseVisualStyleBackColor = true;
            this.btn_AddProductName.Click += new System.EventHandler(this.btn_AddProductName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // txtbox_ProductNameInput
            // 
            this.txtbox_ProductNameInput.Location = new System.Drawing.Point(86, 382);
            this.txtbox_ProductNameInput.Name = "txtbox_ProductNameInput";
            this.txtbox_ProductNameInput.Size = new System.Drawing.Size(199, 20);
            this.txtbox_ProductNameInput.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Products:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(430, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Store Version Uploader by Aeon";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 495);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 533);
            this.MinimumSize = new System.Drawing.Size(454, 533);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Store Version Uploader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Button btn_Upload;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbox_Changelog;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cmbox_VersionType;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtbox_Version;
        public System.Windows.Forms.Button btn_ZipFile;
        public System.Windows.Forms.Label lbl_ZipFile;
        public System.Windows.Forms.ProgressBar pbar_UploadProgress;
        public System.Windows.Forms.TextBox txtbox_Console;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtbox_ProductNameInput;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_AddProductName;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtbox_ProductIdInput;
        public System.Windows.Forms.DataGridView dtg_ProductList;
        public System.Windows.Forms.Button btn_FolderPath;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtbox_ProductFolderPathInput;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtbox_APIKeyInput;
        public System.Windows.Forms.Button btn_AssignAPIKey;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtbox_APIKey;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtbox_ProductName;
        public System.Windows.Forms.TextBox txtbox_ProductZipFile;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtbox_ProductId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
    }
}

