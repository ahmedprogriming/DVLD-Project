namespace DVLD_Project
{
    partial class frmShowLocalDrivingLincenseApp
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
            this.crlApplicationInfo1 = new DVLD_Project.crlLocalDrivingLicenseApplicationInfo();
            this.btnClos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crlApplicationInfo1
            // 
            this.crlApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.crlApplicationInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crlApplicationInfo1.Location = new System.Drawing.Point(12, 38);
            this.crlApplicationInfo1.Name = "crlApplicationInfo1";
            this.crlApplicationInfo1.Size = new System.Drawing.Size(869, 364);
            this.crlApplicationInfo1.TabIndex = 0;
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
            this.btnClos.Location = new System.Drawing.Point(748, 409);
            this.btnClos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(133, 41);
            this.btnClos.TabIndex = 188;
            this.btnClos.Text = "    Close";
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // frmShowLocalDrivingLincenseApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 456);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.crlApplicationInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowLocalDrivingLincenseApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Local Driving Lincense Application";
            this.Load += new System.EventHandler(this.frmShowLocalDrivingLincenseApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private crlLocalDrivingLicenseApplicationInfo crlApplicationInfo1;
        private System.Windows.Forms.Button btnClos;
    }
}