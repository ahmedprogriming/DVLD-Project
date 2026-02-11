namespace DVLD_Project
{
    partial class ctrlDriverLicenseWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilterLicense = new System.Windows.Forms.GroupBox();
            this.txtFilterLicenseID = new System.Windows.Forms.TextBox();
            this.btnFindLicenseID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfo1 = new DVLD_Project.ctrlDriverLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilterLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterLicense
            // 
            this.gbFilterLicense.Controls.Add(this.txtFilterLicenseID);
            this.gbFilterLicense.Controls.Add(this.btnFindLicenseID);
            this.gbFilterLicense.Controls.Add(this.label1);
            this.gbFilterLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterLicense.Location = new System.Drawing.Point(3, 3);
            this.gbFilterLicense.Name = "gbFilterLicense";
            this.gbFilterLicense.Size = new System.Drawing.Size(455, 89);
            this.gbFilterLicense.TabIndex = 190;
            this.gbFilterLicense.TabStop = false;
            this.gbFilterLicense.Text = "Filter";
            // 
            // txtFilterLicenseID
            // 
            this.txtFilterLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterLicenseID.Location = new System.Drawing.Point(115, 42);
            this.txtFilterLicenseID.Name = "txtFilterLicenseID";
            this.txtFilterLicenseID.Size = new System.Drawing.Size(228, 28);
            this.txtFilterLicenseID.TabIndex = 3;
            this.txtFilterLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterLicenseID_KeyPress);
            this.txtFilterLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterLicenseID_Validating);
            // 
            // btnFindLicenseID
            // 
            this.btnFindLicenseID.BackColor = System.Drawing.Color.White;
            this.btnFindLicenseID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindLicenseID.Image = global::DVLD_Project.Properties.Resources.License_View_323;
            this.btnFindLicenseID.Location = new System.Drawing.Point(364, 27);
            this.btnFindLicenseID.Name = "btnFindLicenseID";
            this.btnFindLicenseID.Size = new System.Drawing.Size(64, 56);
            this.btnFindLicenseID.TabIndex = 0;
            this.btnFindLicenseID.UseVisualStyleBackColor = false;
            this.btnFindLicenseID.Click += new System.EventHandler(this.btnFindLicenseID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "LicenseID:";
            // 
            // ctrlDriverLicenseInfo1
            // 
            this.ctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenseInfo1.Location = new System.Drawing.Point(3, 98);
            this.ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            this.ctrlDriverLicenseInfo1.Size = new System.Drawing.Size(920, 351);
            this.ctrlDriverLicenseInfo1.TabIndex = 191;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlDriverLicenseInfo1);
            this.Controls.Add(this.gbFilterLicense);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ctrlDriverLicenseWithFilter";
            this.Size = new System.Drawing.Size(923, 450);
            this.gbFilterLicense.ResumeLayout(false);
            this.gbFilterLicense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilterLicense;
        private System.Windows.Forms.TextBox txtFilterLicenseID;
        private System.Windows.Forms.Button btnFindLicenseID;
        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
