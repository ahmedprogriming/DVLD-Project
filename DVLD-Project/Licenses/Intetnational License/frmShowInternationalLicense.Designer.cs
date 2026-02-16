namespace DVLD_Project
{
    partial class frmShowInternationalLicense
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
            this.ctrDriverInternationalLicenseInfo1 = new DVLD_Project.ctrDriverInternationalLicenseInfo();
            this.lblTitel = new System.Windows.Forms.Label();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDriverInternationalLicenseInfo1
            // 
            this.ctrDriverInternationalLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrDriverInternationalLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrDriverInternationalLicenseInfo1.Location = new System.Drawing.Point(6, 273);
            this.ctrDriverInternationalLicenseInfo1.Name = "ctrDriverInternationalLicenseInfo1";
            this.ctrDriverInternationalLicenseInfo1.Size = new System.Drawing.Size(922, 296);
            this.ctrDriverInternationalLicenseInfo1.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(85, 207);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(751, 51);
            this.lblTitel.TabIndex = 96;
            this.lblTitel.Text = "Driver International License Info";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.LicenseView_400;
            this.picImageUser.Location = new System.Drawing.Point(348, 13);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(237, 178);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 97;
            this.picImageUser.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.International_32;
            this.pictureBox9.Location = new System.Drawing.Point(376, 34);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 186;
            this.pictureBox9.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(788, 576);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 41);
            this.btnClose.TabIndex = 187;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowInternationalLicense
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 628);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.picImageUser);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.ctrDriverInternationalLicenseInfo1);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowInternationalLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Driver Info";
            this.Load += new System.EventHandler(this.frmShowInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrDriverInternationalLicenseInfo ctrDriverInternationalLicenseInfo1;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnClose;
    }
}