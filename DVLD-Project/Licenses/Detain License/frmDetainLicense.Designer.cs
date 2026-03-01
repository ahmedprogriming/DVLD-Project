namespace DVLD_Project
{
    partial class frmDetainLicense
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseWithFilter1 = new DVLD_Project.ctrlDriverLicenseWithFilter();
            this.groDetainInfo = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblCreatedUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkShowLicenseHisTory = new System.Windows.Forms.LinkLabel();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnClos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groDetainInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(102, 9);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(751, 51);
            this.lblTitel.TabIndex = 98;
            this.lblTitel.Text = "Detain License";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlDriverLicenseWithFilter1
            // 
            this.ctrlDriverLicenseWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseWithFilter1.FilterEnbled = true;
            this.ctrlDriverLicenseWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseWithFilter1.Location = new System.Drawing.Point(12, 63);
            this.ctrlDriverLicenseWithFilter1.Name = "ctrlDriverLicenseWithFilter1";
            this.ctrlDriverLicenseWithFilter1.Size = new System.Drawing.Size(923, 450);
            this.ctrlDriverLicenseWithFilter1.TabIndex = 99;
            this.ctrlDriverLicenseWithFilter1.OnLicesneSelected += new System.Action<int>(this.ctrlDriverLicenseWithFilter1_OnLicesneSelected);
            // 
            // groDetainInfo
            // 
            this.groDetainInfo.Controls.Add(this.txtFineFees);
            this.groDetainInfo.Controls.Add(this.pictureBox5);
            this.groDetainInfo.Controls.Add(this.lblCreatedUser);
            this.groDetainInfo.Controls.Add(this.label3);
            this.groDetainInfo.Controls.Add(this.pictureBox1);
            this.groDetainInfo.Controls.Add(this.pictureBox7);
            this.groDetainInfo.Controls.Add(this.lblLicenseID);
            this.groDetainInfo.Controls.Add(this.lblDetainID);
            this.groDetainInfo.Controls.Add(this.pictureBox3);
            this.groDetainInfo.Controls.Add(this.label1);
            this.groDetainInfo.Controls.Add(this.lblDetainDate);
            this.groDetainInfo.Controls.Add(this.pictureBox9);
            this.groDetainInfo.Controls.Add(this.label8);
            this.groDetainInfo.Controls.Add(this.label9);
            this.groDetainInfo.Controls.Add(this.label10);
            this.groDetainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groDetainInfo.Location = new System.Drawing.Point(12, 510);
            this.groDetainInfo.Name = "groDetainInfo";
            this.groDetainInfo.Size = new System.Drawing.Size(923, 137);
            this.groDetainInfo.TabIndex = 100;
            this.groDetainInfo.TabStop = false;
            this.groDetainInfo.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineFees.Location = new System.Drawing.Point(250, 99);
            this.txtFineFees.Multiline = true;
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(126, 26);
            this.txtFineFees.TabIndex = 184;
            this.txtFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFineFees_Validating);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(593, 64);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 174;
            this.pictureBox5.TabStop = false;
            // 
            // lblCreatedUser
            // 
            this.lblCreatedUser.AutoSize = true;
            this.lblCreatedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedUser.Location = new System.Drawing.Point(632, 65);
            this.lblCreatedUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedUser.Name = "lblCreatedUser";
            this.lblCreatedUser.Size = new System.Drawing.Size(68, 25);
            this.lblCreatedUser.TabIndex = 173;
            this.lblCreatedUser.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 172;
            this.label3.Text = "Created By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_Project.Properties.Resources.Calendar_32;
            this.pictureBox1.Location = new System.Drawing.Point(206, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(206, 32);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 168;
            this.pictureBox7.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(631, 29);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(68, 25);
            this.lblLicenseID.TabIndex = 164;
            this.lblLicenseID.Text = "[????]";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetainID.Location = new System.Drawing.Point(244, 32);
            this.lblDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(74, 25);
            this.lblDetainID.TabIndex = 159;
            this.lblDetainID.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_Project.Properties.Resources.Renew_Driving_License_322;
            this.pictureBox3.Location = new System.Drawing.Point(593, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 151;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 141;
            this.label1.Text = "Detain ID:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(245, 62);
            this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(68, 25);
            this.lblDetainDate.TabIndex = 155;
            this.lblDetainDate.Text = "[????]";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.money_321;
            this.pictureBox9.Location = new System.Drawing.Point(206, 99);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 152;
            this.pictureBox9.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 144;
            this.label8.Text = "License ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 143;
            this.label9.Text = "Fine Fees:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 142;
            this.label10.Text = "Detain Date:";
            // 
            // linkShowLicenseInfo
            // 
            this.linkShowLicenseInfo.AutoSize = true;
            this.linkShowLicenseInfo.Enabled = false;
            this.linkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseInfo.Location = new System.Drawing.Point(313, 666);
            this.linkShowLicenseInfo.Name = "linkShowLicenseInfo";
            this.linkShowLicenseInfo.Size = new System.Drawing.Size(172, 25);
            this.linkShowLicenseInfo.TabIndex = 207;
            this.linkShowLicenseInfo.TabStop = true;
            this.linkShowLicenseInfo.Text = "Show License Info";
            this.linkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseInfo_LinkClicked);
            // 
            // linkShowLicenseHisTory
            // 
            this.linkShowLicenseHisTory.AutoSize = true;
            this.linkShowLicenseHisTory.Enabled = false;
            this.linkShowLicenseHisTory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowLicenseHisTory.Location = new System.Drawing.Point(66, 666);
            this.linkShowLicenseHisTory.Name = "linkShowLicenseHisTory";
            this.linkShowLicenseHisTory.Size = new System.Drawing.Size(200, 25);
            this.linkShowLicenseHisTory.TabIndex = 206;
            this.linkShowLicenseHisTory.TabStop = true;
            this.linkShowLicenseHisTory.Text = "Show License History";
            this.linkShowLicenseHisTory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowLicenseHisTory_LinkClicked);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnDetainLicense.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetainLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetainLicense.Image = global::DVLD_Project.Properties.Resources.Detain_322;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDetainLicense.Location = new System.Drawing.Point(808, 656);
            this.btnDetainLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(133, 41);
            this.btnDetainLicense.TabIndex = 208;
            this.btnDetainLicense.Text = "    Detain";
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnClos
            // 
            this.btnClos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClos.BackColor = System.Drawing.Color.White;
            this.btnClos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClos.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClos.Location = new System.Drawing.Point(655, 656);
            this.btnClos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(133, 41);
            this.btnClos.TabIndex = 209;
            this.btnClos.Text = "    Close";
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AcceptButton = this.btnDetainLicense;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 701);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.linkShowLicenseInfo);
            this.Controls.Add(this.linkShowLicenseHisTory);
            this.Controls.Add(this.groDetainInfo);
            this.Controls.Add(this.ctrlDriverLicenseWithFilter1);
            this.Controls.Add(this.lblTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetainLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Activated += new System.EventHandler(this.frmDetainLicense_Activated);
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.groDetainInfo.ResumeLayout(false);
            this.groDetainInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private ctrlDriverLicenseWithFilter ctrlDriverLicenseWithFilter1;
        private System.Windows.Forms.GroupBox groDetainInfo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblCreatedUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.LinkLabel linkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel linkShowLicenseHisTory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}