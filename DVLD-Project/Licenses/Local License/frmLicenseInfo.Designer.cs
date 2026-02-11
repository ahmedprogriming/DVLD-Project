namespace DVLD_Project
{
    partial class frmLicenseInfo
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
            this.lblTitel = new System.Windows.Forms.Label();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.btnClos = new System.Windows.Forms.Button();
            this.ctrlDriverLicenseInfo1 = new DVLD_Project.ctrlDriverLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Red;
            this.lblTitel.Location = new System.Drawing.Point(251, 183);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(411, 51);
            this.lblTitel.TabIndex = 96;
            this.lblTitel.Text = "Driver License Info";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImageUser
            // 
            this.picImageUser.Image = global::DVLD_Project.Properties.Resources.LicenseView_400;
            this.picImageUser.Location = new System.Drawing.Point(367, 25);
            this.picImageUser.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(195, 131);
            this.picImageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageUser.TabIndex = 73;
            this.picImageUser.TabStop = false;
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
            this.btnClos.Location = new System.Drawing.Point(809, 632);
            this.btnClos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(133, 41);
            this.btnClos.TabIndex = 197;
            this.btnClos.Text = "    Close";
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(22, 274);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(920, 351);
            this.ctrlDriverLicenseInfo1.TabIndex = 198;
            // 
            // frmLicenseInfo
            // 
            this.AcceptButton = this.btnClos;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 680);
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.picImageUser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicenseInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.frmLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageUser;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnClos;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
    }
}