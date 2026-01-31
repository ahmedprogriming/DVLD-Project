namespace DVLD_Project
{
    partial class frmListLocalDrivingLicenseApplications
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLDLApplication = new System.Windows.Forms.DataGridView();
            this.MSLocalDrivingApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowAppDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCanselApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSechduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStreatTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitel = new System.Windows.Forms.Label();
            this.cobFilterLocal = new System.Windows.Forms.ComboBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labRecodLDLApp = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplication)).BeginInit();
            this.MSLocalDrivingApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLDLApplication
            // 
            this.dgvLDLApplication.AllowUserToAddRows = false;
            this.dgvLDLApplication.AllowUserToDeleteRows = false;
            this.dgvLDLApplication.AllowUserToResizeRows = false;
            this.dgvLDLApplication.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApplication.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApplication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLDLApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplication.ContextMenuStrip = this.MSLocalDrivingApp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApplication.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApplication.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLDLApplication.GridColor = System.Drawing.Color.White;
            this.dgvLDLApplication.Location = new System.Drawing.Point(40, 357);
            this.dgvLDLApplication.MultiSelect = false;
            this.dgvLDLApplication.Name = "dgvLDLApplication";
            this.dgvLDLApplication.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApplication.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLApplication.RowHeadersWidth = 51;
            this.dgvLDLApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApplication.Size = new System.Drawing.Size(1164, 369);
            this.dgvLDLApplication.TabIndex = 94;
            this.dgvLDLApplication.TabStop = false;
            // 
            // MSLocalDrivingApp
            // 
            this.MSLocalDrivingApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSLocalDrivingApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSLocalDrivingApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowAppDetiles,
            this.tsmEditApp,
            this.tsmCanselApp,
            this.tsDeleteApp,
            this.tsSechduleTest,
            this.tsmIssue,
            this.tsmShowLicense,
            this.tsmpersonHistory});
            this.MSLocalDrivingApp.Name = "contextMenuStrip1";
            this.MSLocalDrivingApp.Size = new System.Drawing.Size(352, 336);
           
            // 
            // tsmShowAppDetiles
            // 
            this.tsmShowAppDetiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowAppDetiles.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmShowAppDetiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowAppDetiles.Name = "tsmShowAppDetiles";
            this.tsmShowAppDetiles.Size = new System.Drawing.Size(351, 38);
            this.tsmShowAppDetiles.Text = "Show Application Details";
            // 
            // tsmEditApp
            // 
            this.tsmEditApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmEditApp.Image = global::DVLD_Project.Properties.Resources.edit_32;
            this.tsmEditApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditApp.Name = "tsmEditApp";
            this.tsmEditApp.Size = new System.Drawing.Size(351, 38);
            this.tsmEditApp.Text = "Edit Application";
            // 
            // tsmCanselApp
            // 
            this.tsmCanselApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmCanselApp.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.tsmCanselApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCanselApp.Name = "tsmCanselApp";
            this.tsmCanselApp.Size = new System.Drawing.Size(351, 38);
            this.tsmCanselApp.Text = "Cansel Application";
            this.tsmCanselApp.Click += new System.EventHandler(this.tsmCanselApp_Click);
            // 
            // tsDeleteApp
            // 
            this.tsDeleteApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDeleteApp.Image = global::DVLD_Project.Properties.Resources.Delete_32_2;
            this.tsDeleteApp.Name = "tsDeleteApp";
            this.tsDeleteApp.Size = new System.Drawing.Size(351, 38);
            this.tsDeleteApp.Text = "Delete Application";
            // 
            // tsSechduleTest
            // 
            this.tsSechduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVisionTest,
            this.tsmWrittenTest,
            this.tsmStreatTest});
            this.tsSechduleTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSechduleTest.Image = global::DVLD_Project.Properties.Resources.Schedule_Test_32;
            this.tsSechduleTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSechduleTest.Name = "tsSechduleTest";
            this.tsSechduleTest.Size = new System.Drawing.Size(351, 38);
            this.tsSechduleTest.Text = "Sechdule Test";
            // 
            // tsmVisionTest
            // 
            this.tsmVisionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmVisionTest.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.tsmVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmVisionTest.Name = "tsmVisionTest";
            this.tsmVisionTest.Size = new System.Drawing.Size(248, 38);
            this.tsmVisionTest.Text = "Sechdule Vision Test";
            this.tsmVisionTest.Click += new System.EventHandler(this.sechduleVisionTestToolStripMenuItem_Click);
            // 
            // tsmWrittenTest
            // 
            this.tsmWrittenTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmWrittenTest.Image = global::DVLD_Project.Properties.Resources.Written_Test_32_Sechdule;
            this.tsmWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmWrittenTest.Name = "tsmWrittenTest";
            this.tsmWrittenTest.Size = new System.Drawing.Size(248, 38);
            this.tsmWrittenTest.Text = "Sechdule Written Test";
            // 
            // tsmStreatTest
            // 
            this.tsmStreatTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmStreatTest.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.tsmStreatTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmStreatTest.Name = "tsmStreatTest";
            this.tsmStreatTest.Size = new System.Drawing.Size(248, 38);
            this.tsmStreatTest.Text = "Sechdule Street Test";
            // 
            // tsmIssue
            // 
            this.tsmIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmIssue.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.tsmIssue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmIssue.Name = "tsmIssue";
            this.tsmIssue.Size = new System.Drawing.Size(351, 38);
            this.tsmIssue.Text = "Issue Driving License (Fitst Time)";
            this.tsmIssue.Click += new System.EventHandler(this.tsmIssue_Click);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.tsmShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(351, 38);
            this.tsmShowLicense.Text = "Show License";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // tsmpersonHistory
            // 
            this.tsmpersonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmpersonHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.tsmpersonHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmpersonHistory.Name = "tsmpersonHistory";
            this.tsmpersonHistory.Size = new System.Drawing.Size(351, 38);
            this.tsmpersonHistory.Text = "Show Person License History";
            this.tsmpersonHistory.Click += new System.EventHandler(this.tsmpersonHistory_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(264, 213);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(751, 51);
            this.lblTitel.TabIndex = 95;
            this.lblTitel.Text = "Local Driving License Applications";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cobFilterLocal
            // 
            this.cobFilterLocal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobFilterLocal.BackColor = System.Drawing.SystemColors.Control;
            this.cobFilterLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobFilterLocal.FormattingEnabled = true;
            this.cobFilterLocal.Items.AddRange(new object[] {
            "None",
            "L.D.L.Application",
            "National No.",
            "Full Name",
            "Status"});
            this.cobFilterLocal.Location = new System.Drawing.Point(139, 322);
            this.cobFilterLocal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilterLocal.Name = "cobFilterLocal";
            this.cobFilterLocal.Size = new System.Drawing.Size(163, 26);
            this.cobFilterLocal.TabIndex = 96;
            this.cobFilterLocal.SelectedIndexChanged += new System.EventHandler(this.cobFilterLocal_SelectedIndexChanged);
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(308, 324);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(190, 24);
            this.txbFilter.TabIndex = 97;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 98;
            this.label2.Text = "Filter By :";
            // 
            // labRecodLDLApp
            // 
            this.labRecodLDLApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecodLDLApp.AutoSize = true;
            this.labRecodLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecodLDLApp.Location = new System.Drawing.Point(129, 738);
            this.labRecodLDLApp.Name = "labRecodLDLApp";
            this.labRecodLDLApp.Size = new System.Drawing.Size(36, 20);
            this.labRecodLDLApp.TabIndex = 102;
            this.labRecodLDLApp.Text = "???";
            this.labRecodLDLApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRecords.Location = new System.Drawing.Point(136, 738);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(0, 19);
            this.lblNumberRecords.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 738);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 100;
            this.label5.Text = "Records :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 99;
            this.label4.Text = "#";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(1070, 738);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 103;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewApplication.BackColor = System.Drawing.Color.White;
            this.btnAddNewApplication.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnAddNewApplication.Location = new System.Drawing.Point(1126, 281);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(78, 69);
            this.btnAddNewApplication.TabIndex = 104;
            this.btnAddNewApplication.UseVisualStyleBackColor = false;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Local_32;
            this.pictureBox3.Location = new System.Drawing.Point(676, 70);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.Applications;
            this.picImageUser.Location = new System.Drawing.Point(516, 13);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(195, 178);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 72;
            this.picImageUser.TabStop = false;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 786);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labRecodLDLApp);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cobFilterLocal);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dgvLDLApplication);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picImageUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplication)).EndInit();
            this.MSLocalDrivingApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgvLDLApplication;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ComboBox cobFilterLocal;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecodLDLApp;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.ContextMenuStrip MSLocalDrivingApp;
        private System.Windows.Forms.ToolStripMenuItem tsmShowAppDetiles;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApp;
        private System.Windows.Forms.ToolStripMenuItem tsDeleteApp;
        private System.Windows.Forms.ToolStripMenuItem tsSechduleTest;
        private System.Windows.Forms.ToolStripMenuItem tsmCanselApp;
        private System.Windows.Forms.ToolStripMenuItem tsmIssue;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmpersonHistory;
        private System.Windows.Forms.ToolStripMenuItem tsmVisionTest;
        private System.Windows.Forms.ToolStripMenuItem tsmWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem tsmStreatTest;
    }
}