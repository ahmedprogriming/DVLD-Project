namespace DVLD_Project
{
    partial class frmListDriverscs
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
            this.labRecodLDLApp = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.cobFilterDrivers = new System.Windows.Forms.ComboBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvManagerDrivers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.MSDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowPersonDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.MSDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // labRecodLDLApp
            // 
            this.labRecodLDLApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecodLDLApp.AutoSize = true;
            this.labRecodLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecodLDLApp.Location = new System.Drawing.Point(111, 658);
            this.labRecodLDLApp.Name = "labRecodLDLApp";
            this.labRecodLDLApp.Size = new System.Drawing.Size(36, 20);
            this.labRecodLDLApp.TabIndex = 113;
            this.labRecodLDLApp.Text = "???";
            this.labRecodLDLApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRecords.Location = new System.Drawing.Point(62, 664);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(0, 19);
            this.lblNumberRecords.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 111;
            this.label5.Text = "Records :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 23);
            this.label4.TabIndex = 110;
            this.label4.Text = "#";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Filter By :";
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(268, 281);
            this.txbFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(190, 24);
            this.txbFilter.TabIndex = 108;
            this.txbFilter.TextChanged += new System.EventHandler(this.txbFilter_TextChanged);
            // 
            // cobFilterDrivers
            // 
            this.cobFilterDrivers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobFilterDrivers.BackColor = System.Drawing.SystemColors.Control;
            this.cobFilterDrivers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFilterDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobFilterDrivers.FormattingEnabled = true;
            this.cobFilterDrivers.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "National No.",
            "Full Name",
            "Person ID"});
            this.cobFilterDrivers.Location = new System.Drawing.Point(99, 279);
            this.cobFilterDrivers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cobFilterDrivers.Name = "cobFilterDrivers";
            this.cobFilterDrivers.Size = new System.Drawing.Size(163, 26);
            this.cobFilterDrivers.TabIndex = 107;
            this.cobFilterDrivers.SelectedIndexChanged += new System.EventHandler(this.cobFilterDrivers_SelectedIndexChanged);
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(417, 212);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(423, 51);
            this.lblTitel.TabIndex = 106;
            this.lblTitel.Text = "Manager Drivers";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvManagerDrivers
            // 
            this.dgvManagerDrivers.AllowUserToAddRows = false;
            this.dgvManagerDrivers.AllowUserToDeleteRows = false;
            this.dgvManagerDrivers.AllowUserToResizeRows = false;
            this.dgvManagerDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvManagerDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagerDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerDrivers.ContextMenuStrip = this.MSDrivers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerDrivers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagerDrivers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvManagerDrivers.GridColor = System.Drawing.Color.White;
            this.dgvManagerDrivers.Location = new System.Drawing.Point(18, 309);
            this.dgvManagerDrivers.MultiSelect = false;
            this.dgvManagerDrivers.Name = "dgvManagerDrivers";
            this.dgvManagerDrivers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagerDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManagerDrivers.RowHeadersWidth = 51;
            this.dgvManagerDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagerDrivers.Size = new System.Drawing.Size(1164, 342);
            this.dgvManagerDrivers.TabIndex = 105;
            this.dgvManagerDrivers.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(1048, 658);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.Driver_Main;
            this.picImageUser.Location = new System.Drawing.Point(444, 13);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(352, 186);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 104;
            this.picImageUser.TabStop = false;
            // 
            // MSDrivers
            // 
            this.MSDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSDrivers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MSDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowPersonDetiles,
            this.tsmpersonHistory});
            this.MSDrivers.Name = "contextMenuStrip1";
            this.MSDrivers.Size = new System.Drawing.Size(320, 80);
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
            // frmListDriverscs
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 718);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labRecodLDLApp);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFilter);
            this.Controls.Add(this.cobFilterDrivers);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.dgvManagerDrivers);
            this.Controls.Add(this.picImageUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListDriverscs";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Driverscs";
            this.Load += new System.EventHandler(this.frmListDriverscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.MSDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecodLDLApp;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.ComboBox cobFilterDrivers;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.DataGridView dgvManagerDrivers;
        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.ContextMenuStrip MSDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonDetiles;
        private System.Windows.Forms.ToolStripMenuItem tsmpersonHistory;
    }
}