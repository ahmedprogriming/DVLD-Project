namespace DVLD_Project
{
    partial class frmAppointementsTypeTest
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.dgvAppointements = new System.Windows.Forms.DataGridView();
            this.tmsAppointements = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.labRecodCount = new System.Windows.Forms.Label();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddAppointements = new System.Windows.Forms.Button();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.crlApplicationInfo1 = new DVLD_Project.crlApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointements)).BeginInit();
            this.tmsAppointements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(163, 97);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(628, 51);
            this.lblTitel.TabIndex = 108;
            this.lblTitel.Text = "Vision Test Appointements";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAppointements
            // 
            this.dgvAppointements.AllowUserToAddRows = false;
            this.dgvAppointements.AllowUserToDeleteRows = false;
            this.dgvAppointements.AllowUserToResizeRows = false;
            this.dgvAppointements.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppointements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAppointements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointements.ColumnHeadersHeight = 29;
            this.dgvAppointements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointements.ContextMenuStrip = this.tmsAppointements;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointements.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAppointements.GridColor = System.Drawing.Color.White;
            this.dgvAppointements.Location = new System.Drawing.Point(14, 569);
            this.dgvAppointements.MultiSelect = false;
            this.dgvAppointements.Name = "dgvAppointements";
            this.dgvAppointements.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointements.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointements.RowHeadersWidth = 51;
            this.dgvAppointements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointements.Size = new System.Drawing.Size(868, 149);
            this.dgvAppointements.TabIndex = 111;
            this.dgvAppointements.TabStop = false;
            // 
            // tmsAppointements
            // 
            this.tmsAppointements.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tmsAppointements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.tackToolStripMenuItem});
            this.tmsAppointements.Name = "tmsAppointements";
            this.tmsAppointements.Size = new System.Drawing.Size(154, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.edit_322;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tackToolStripMenuItem
            // 
            this.tackToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.Test_32;
            this.tackToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tackToolStripMenuItem.Name = "tackToolStripMenuItem";
            this.tackToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.tackToolStripMenuItem.Text = "Take Test";
            this.tackToolStripMenuItem.Click += new System.EventHandler(this.tackToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 532);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 147;
            this.label6.Text = "Appointements:";
            // 
            // labRecodCount
            // 
            this.labRecodCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labRecodCount.AutoSize = true;
            this.labRecodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecodCount.Location = new System.Drawing.Point(100, 730);
            this.labRecodCount.Name = "labRecodCount";
            this.labRecodCount.Size = new System.Drawing.Size(36, 20);
            this.labRecodCount.TabIndex = 151;
            this.labRecodCount.Text = "???";
            this.labRecodCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberRecords.Location = new System.Drawing.Point(37, 729);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(0, 19);
            this.lblNumberRecords.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 731);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 149;
            this.label5.Text = "Records :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 152;
            this.label1.Text = "#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(745, 730);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 41);
            this.btnClose.TabIndex = 148;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddAppointements
            // 
            this.btnAddAppointements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAppointements.BackColor = System.Drawing.Color.White;
            this.btnAddAppointements.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAppointements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAppointements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddAppointements.Image = global::DVLD_Project.Properties.Resources.AddAppointment_32;
            this.btnAddAppointements.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddAppointements.Location = new System.Drawing.Point(832, 521);
            this.btnAddAppointements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAppointements.Name = "btnAddAppointements";
            this.btnAddAppointements.Size = new System.Drawing.Size(46, 41);
            this.btnAddAppointements.TabIndex = 153;
            this.btnAddAppointements.UseVisualStyleBackColor = false;
            this.btnAddAppointements.Click += new System.EventHandler(this.btnAddAppointements_Click);
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.Vision_512;
            this.picImageUser.Location = new System.Drawing.Point(370, 1);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(176, 79);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 109;
            this.picImageUser.TabStop = false;
            // 
            // crlApplicationInfo1
            // 
            this.crlApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.crlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crlApplicationInfo1.Location = new System.Drawing.Point(14, 150);
            this.crlApplicationInfo1.Name = "crlApplicationInfo1";
            this.crlApplicationInfo1.Size = new System.Drawing.Size(869, 364);
            this.crlApplicationInfo1.TabIndex = 154;
            // 
            // frmAppointementsTypeTest
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 774);
            this.Controls.Add(this.crlApplicationInfo1);
            this.Controls.Add(this.btnAddAppointements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labRecodCount);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvAppointements);
            this.Controls.Add(this.picImageUser);
            this.Controls.Add(this.lblTitel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAppointementsTypeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appointements";
            this.Load += new System.EventHandler(this.frmAppointementsTypeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointements)).EndInit();
            this.tmsAppointements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.DataGridView dgvAppointements;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labRecodCount;
        private System.Windows.Forms.Label lblNumberRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAppointements;
        private System.Windows.Forms.ContextMenuStrip tmsAppointements;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tackToolStripMenuItem;
        private crlApplicationInfo crlApplicationInfo1;
    }
}