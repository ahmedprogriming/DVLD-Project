namespace DVLD_Project
{
    partial class frmListDetainLicense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvListDetainLicense = new System.Windows.Forms.DataGridView();
            this.MSDetainLicenseApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cobFilterDetain = new System.Windows.Forms.ComboBox();
            this.cobIsReleaseed = new System.Windows.Forms.ComboBox();
            this.labRecodDetainLicense = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReleasedDetain = new System.Windows.Forms.Button();
            this.btnAddNewDetainLicense = new System.Windows.Forms.Button();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainLicense)).BeginInit();
            this.MSDetainLicenseApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(465, 198);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(608, 59);
            this.lblTitel.TabIndex = 109;
            this.lblTitel.Text = "List Detain License";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListDetainLicense
            // 
            this.dgvListDetainLicense.AllowUserToAddRows = false;
            this.dgvListDetainLicense.AllowUserToDeleteRows = false;
            this.dgvListDetainLicense.AllowUserToResizeRows = false;
            this.dgvListDetainLicense.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDetainLicense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListDetainLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListDetainLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDetainLicense.ContextMenuStrip = this.MSDetainLicenseApp;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListDetainLicense.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListDetainLicense.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListDetainLicense.GridColor = System.Drawing.Color.White;
            this.dgvListDetainLicense.Location = new System.Drawing.Point(31, 322);
            this.dgvListDetainLicense.MultiSelect = false;
            this.dgvListDetainLicense.Name = "dgvListDetainLicense";
            this.dgvListDetainLicense.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListDetainLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListDetainLicense.RowHeadersWidth = 51;
            this.dgvListDetainLicense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListDetainLicense.Size = new System.Drawing.Size(1398, 369);
            this.dgvListDetainLicense.TabIndex = 110;
            this.dgvListDetainLicense.TabStop = false;
            // 
            // MSDetainLicenseApp
            // 
            this.MSDetainLicenseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSDetainLicenseApp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSDetainLicenseApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetiles,
            this.tsmShowLicense,
            this.tsmpersonHistory,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.MSDetainLicenseApp.Name = "contextMenuStrip1";
            this.MSDetainLicenseApp.Size = new System.Drawing.Size(320, 156);
            this.MSDetainLicenseApp.Opening += new System.ComponentModel.CancelEventHandler(this.MSDetainLicenseApp_Opening);
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
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_322;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(319, 38);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 121;
            this.label2.Text = "Filter By :";
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(298, 291);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(190, 24);
            this.txbFilter.TabIndex = 120;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            this.txbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFilter_KeyPress);
            // 
            // cobFilterDetain
            // 
            this.cobFilterDetain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobFilterDetain.BackColor = System.Drawing.SystemColors.Control;
            this.cobFilterDetain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobFilterDetain.FormattingEnabled = true;
            this.cobFilterDetain.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "National No.",
            "Full Name",
            "Is Released",
            "Release Application ID"});
            this.cobFilterDetain.Location = new System.Drawing.Point(129, 289);
            this.cobFilterDetain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilterDetain.Name = "cobFilterDetain";
            this.cobFilterDetain.Size = new System.Drawing.Size(163, 26);
            this.cobFilterDetain.TabIndex = 119;
            this.cobFilterDetain.SelectedIndexChanged += new System.EventHandler(this.cobFilterDetain_SelectedIndexChanged);
            // 
            // cobIsReleaseed
            // 
            this.cobIsReleaseed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobIsReleaseed.BackColor = System.Drawing.SystemColors.Control;
            this.cobIsReleaseed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobIsReleaseed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobIsReleaseed.FormattingEnabled = true;
            this.cobIsReleaseed.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cobIsReleaseed.Location = new System.Drawing.Point(298, 288);
            this.cobIsReleaseed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobIsReleaseed.Name = "cobIsReleaseed";
            this.cobIsReleaseed.Size = new System.Drawing.Size(163, 26);
            this.cobIsReleaseed.TabIndex = 122;
            this.cobIsReleaseed.SelectedIndexChanged += new System.EventHandler(this.cobIsActive_SelectedIndexChanged);
            // 
            // labRecodDetainLicense
            // 
            this.labRecodDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecodDetainLicense.AutoSize = true;
            this.labRecodDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecodDetainLicense.Location = new System.Drawing.Point(122, 698);
            this.labRecodDetainLicense.Name = "labRecodDetainLicense";
            this.labRecodDetainLicense.Size = new System.Drawing.Size(36, 20);
            this.labRecodDetainLicense.TabIndex = 126;
            this.labRecodDetainLicense.Text = "???";
            this.labRecodDetainLicense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRecords.Location = new System.Drawing.Point(129, 698);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(0, 19);
            this.lblNumberRecords.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 124;
            this.label5.Text = "Records :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 698);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 123;
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
            this.btnClose.Location = new System.Drawing.Point(1295, 698);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 127;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReleasedDetain
            // 
            this.btnReleasedDetain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReleasedDetain.BackColor = System.Drawing.Color.White;
            this.btnReleasedDetain.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_641;
            this.btnReleasedDetain.Location = new System.Drawing.Point(1230, 236);
            this.btnReleasedDetain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReleasedDetain.Name = "btnReleasedDetain";
            this.btnReleasedDetain.Size = new System.Drawing.Size(92, 79);
            this.btnReleasedDetain.TabIndex = 129;
            this.btnReleasedDetain.UseVisualStyleBackColor = false;
            this.btnReleasedDetain.Click += new System.EventHandler(this.btnReleasedDetain_Click);
            // 
            // btnAddNewDetainLicense
            // 
            this.btnAddNewDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnAddNewDetainLicense.Image = global::DVLD_Project.Properties.Resources.Detain_642;
            this.btnAddNewDetainLicense.Location = new System.Drawing.Point(1328, 236);
            this.btnAddNewDetainLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNewDetainLicense.Name = "btnAddNewDetainLicense";
            this.btnAddNewDetainLicense.Size = new System.Drawing.Size(100, 79);
            this.btnAddNewDetainLicense.TabIndex = 128;
            this.btnAddNewDetainLicense.UseVisualStyleBackColor = false;
            this.btnAddNewDetainLicense.Click += new System.EventHandler(this.btnAddNewDetainLicense_Click);
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.Detain_512;
            this.picImageUser.Location = new System.Drawing.Point(655, 13);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(236, 161);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 106;
            this.picImageUser.TabStop = false;
            // 
            // frmListDetainLicense
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 744);
            this.Controls.Add(this.btnReleasedDetain);
            this.Controls.Add(this.btnAddNewDetainLicense);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labRecodDetainLicense);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cobIsReleaseed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cobFilterDetain);
            this.Controls.Add(this.dgvListDetainLicense);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.picImageUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Detain License";
            this.Load += new System.EventHandler(this.frmListDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainLicense)).EndInit();
            this.MSDetainLicenseApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvListDetainLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.ComboBox cobFilterDetain;
        private System.Windows.Forms.ComboBox cobIsReleaseed;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecodDetainLicense;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewDetainLicense;
        private System.Windows.Forms.Button btnReleasedDetain;
        private System.Windows.Forms.ContextMenuStrip MSDetainLicenseApp;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetiles;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmpersonHistory;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}