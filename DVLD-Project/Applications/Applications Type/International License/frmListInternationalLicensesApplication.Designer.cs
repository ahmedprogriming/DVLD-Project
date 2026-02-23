namespace DVLD_Project
{
    partial class frmListInternationalLicensesApplication
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
            this.labRecodINLApp = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cobFilterinternational = new System.Windows.Forms.ComboBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvINLApplication = new System.Windows.Forms.DataGridView();
            this.MSInternationalLicenseApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNewApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.cobIsActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINLApplication)).BeginInit();
            this.MSInternationalLicenseApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labRecodINLApp
            // 
            this.labRecodINLApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecodINLApp.AutoSize = true;
            this.labRecodINLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecodINLApp.Location = new System.Drawing.Point(135, 698);
            this.labRecodINLApp.Name = "labRecodINLApp";
            this.labRecodINLApp.Size = new System.Drawing.Size(36, 20);
            this.labRecodINLApp.TabIndex = 115;
            this.labRecodINLApp.Text = "???";
            this.labRecodINLApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRecords.Location = new System.Drawing.Point(142, 698);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(0, 19);
            this.lblNumberRecords.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 113;
            this.label5.Text = "Records :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 698);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 112;
            this.label4.Text = "#";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 111;
            this.label2.Text = "Filter By :";
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(311, 293);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(190, 24);
            this.txbFilter.TabIndex = 110;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            // 
            // cobFilterinternational
            // 
            this.cobFilterinternational.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobFilterinternational.BackColor = System.Drawing.SystemColors.Control;
            this.cobFilterinternational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterinternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobFilterinternational.FormattingEnabled = true;
            this.cobFilterinternational.Items.AddRange(new object[] {
            "None",
            "Int.License ID",
            "Driver ID",
            "L.Licenes ID",
            "IsActive"});
            this.cobFilterinternational.Location = new System.Drawing.Point(142, 291);
            this.cobFilterinternational.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilterinternational.Name = "cobFilterinternational";
            this.cobFilterinternational.Size = new System.Drawing.Size(163, 26);
            this.cobFilterinternational.TabIndex = 109;
            this.cobFilterinternational.SelectedIndexChanged += new System.EventHandler(this.cobFilterinternational_SelectedIndexChanged);
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(181, 197);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(821, 59);
            this.lblTitel.TabIndex = 108;
            this.lblTitel.Text = "List International Licenses Application";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // dgvINLApplication
            // 
            this.dgvINLApplication.AllowUserToAddRows = false;
            this.dgvINLApplication.AllowUserToDeleteRows = false;
            this.dgvINLApplication.AllowUserToResizeRows = false;
            this.dgvINLApplication.BackgroundColor = System.Drawing.Color.White;
            this.dgvINLApplication.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvINLApplication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvINLApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINLApplication.ContextMenuStrip = this.MSInternationalLicenseApp;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvINLApplication.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvINLApplication.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvINLApplication.GridColor = System.Drawing.Color.White;
            this.dgvINLApplication.Location = new System.Drawing.Point(48, 323);
            this.dgvINLApplication.MultiSelect = false;
            this.dgvINLApplication.Name = "dgvINLApplication";
            this.dgvINLApplication.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvINLApplication.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvINLApplication.RowHeadersWidth = 51;
            this.dgvINLApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvINLApplication.Size = new System.Drawing.Size(1092, 369);
            this.dgvINLApplication.TabIndex = 107;
            this.dgvINLApplication.TabStop = false;
            this.dgvINLApplication.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvINLApplication_CellContentClick);
            // 
            // MSInternationalLicenseApp
            // 
            this.MSInternationalLicenseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSInternationalLicenseApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSInternationalLicenseApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetiles,
            this.tsmShowLicense,
            this.tsmpersonHistory});
            this.MSInternationalLicenseApp.Name = "contextMenuStrip1";
            this.MSInternationalLicenseApp.Size = new System.Drawing.Size(320, 118);
            this.MSInternationalLicenseApp.Opening += new System.ComponentModel.CancelEventHandler(this.MSInternationalLicenseApp_Opening);
            // 
            // tsmShowPersonDetiles
            // 
            this.tsmShowPersonDetiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowPersonDetiles.Image = global::DVLD_Project.Properties.Resources.PersonDetails_32;
            this.tsmShowPersonDetiles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowPersonDetiles.Name = "tsmShowPersonDetiles";
            this.tsmShowPersonDetiles.Size = new System.Drawing.Size(319, 38);
            this.tsmShowPersonDetiles.Text = "Show Person Details";
            this.tsmShowPersonDetiles.Click += new System.EventHandler(this.tsmShowPersonDetiles_Click);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmShowLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.tsmShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(319, 38);
            this.tsmShowLicense.Text = "Show License Details";
            this.tsmShowLicense.Click += new System.EventHandler(this.tsmShowLicense_Click);
            // 
            // tsmpersonHistory
            // 
            this.tsmpersonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmpersonHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.tsmpersonHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmpersonHistory.Name = "tsmpersonHistory";
            this.tsmpersonHistory.Size = new System.Drawing.Size(319, 38);
            this.tsmpersonHistory.Text = "Show Person License History";
            this.tsmpersonHistory.Click += new System.EventHandler(this.tsmpersonHistory_Click);
            // 
            // btnAddNewApplication
            // 
            this.btnAddNewApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewApplication.BackColor = System.Drawing.Color.White;
            this.btnAddNewApplication.Image = global::DVLD_Project.Properties.Resources.New_Application_64;
            this.btnAddNewApplication.Location = new System.Drawing.Point(1062, 247);
            this.btnAddNewApplication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewApplication.Name = "btnAddNewApplication";
            this.btnAddNewApplication.Size = new System.Drawing.Size(78, 69);
            this.btnAddNewApplication.TabIndex = 117;
            this.btnAddNewApplication.UseVisualStyleBackColor = false;
            this.btnAddNewApplication.Click += new System.EventHandler(this.btnAddNewApplication_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1006, 698);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 116;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.International_321;
            this.pictureBox3.Location = new System.Drawing.Point(623, 57);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.Applications;
            this.picImageUser.Location = new System.Drawing.Point(440, 7);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(237, 186);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 105;
            this.picImageUser.TabStop = false;
            this.picImageUser.Click += new System.EventHandler(this.picImageUser_Click);
            // 
            // cobIsActive
            // 
            this.cobIsActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobIsActive.BackColor = System.Drawing.SystemColors.Control;
            this.cobIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobIsActive.FormattingEnabled = true;
            this.cobIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cobIsActive.Location = new System.Drawing.Point(311, 293);
            this.cobIsActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobIsActive.Name = "cobIsActive";
            this.cobIsActive.Size = new System.Drawing.Size(163, 26);
            this.cobIsActive.TabIndex = 118;
            this.cobIsActive.SelectedIndexChanged += new System.EventHandler(this.cobIsActive_SelectedIndexChanged);
            // 
            // frmListInternationalLicensesApplication
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 752);
            this.Controls.Add(this.cobIsActive);
            this.Controls.Add(this.btnAddNewApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labRecodINLApp);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cobFilterinternational);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dgvINLApplication);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picImageUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListInternationalLicensesApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International Licenses Application";
            this.Load += new System.EventHandler(this.frmListInternationalLicensesApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvINLApplication)).EndInit();
            this.MSInternationalLicenseApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecodINLApp;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.ComboBox cobFilterinternational;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvINLApplication;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.ContextMenuStrip MSInternationalLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetiles;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmpersonHistory;
        private System.Windows.Forms.ComboBox cobIsActive;
    }
}