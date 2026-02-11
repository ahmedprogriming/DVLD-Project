namespace DVLD_Project
{
    partial class frmTakeTest
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbPass = new System.Windows.Forms.RadioButton();
            this.rdbFial = new System.Windows.Forms.RadioButton();
            this.txtNots = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClos = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblUserMassege = new System.Windows.Forms.Label();
            this.ctrlScheduledTest1 = new DVLD_Project.ctrlScheduledTest();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 581);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 188;
            this.label7.Text = "Notes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 546);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 189;
            this.label8.Text = "Resulte:";
            // 
            // rdbPass
            // 
            this.rdbPass.AutoSize = true;
            this.rdbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPass.Location = new System.Drawing.Point(171, 548);
            this.rdbPass.Name = "rdbPass";
            this.rdbPass.Size = new System.Drawing.Size(68, 24);
            this.rdbPass.TabIndex = 192;
            this.rdbPass.TabStop = true;
            this.rdbPass.Text = "Pass";
            this.rdbPass.UseVisualStyleBackColor = true;
            // 
            // rdbFial
            // 
            this.rdbFial.AutoSize = true;
            this.rdbFial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFial.Location = new System.Drawing.Point(251, 546);
            this.rdbFial.Name = "rdbFial";
            this.rdbFial.Size = new System.Drawing.Size(57, 24);
            this.rdbFial.TabIndex = 193;
            this.rdbFial.TabStop = true;
            this.rdbFial.Text = "Fial";
            this.rdbFial.UseVisualStyleBackColor = true;
            // 
            // txtNots
            // 
            this.txtNots.Location = new System.Drawing.Point(171, 585);
            this.txtNots.Multiline = true;
            this.txtNots.Name = "txtNots";
            this.txtNots.Size = new System.Drawing.Size(402, 108);
            this.txtNots.TabIndex = 194;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.Save_321;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(440, 700);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 41);
            this.btnSave.TabIndex = 195;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
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
            this.btnClos.Location = new System.Drawing.Point(292, 700);
            this.btnClos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(133, 41);
            this.btnClos.TabIndex = 196;
            this.btnClos.Text = "    Close";
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DVLD_Project.Properties.Resources.Notes_32;
            this.pictureBox9.Location = new System.Drawing.Point(120, 580);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 26);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 191;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_Project.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(117, 546);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 190;
            this.pictureBox8.TabStop = false;
            // 
            // lblUserMassege
            // 
            this.lblUserMassege.AutoSize = true;
            this.lblUserMassege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMassege.ForeColor = System.Drawing.Color.Red;
            this.lblUserMassege.Location = new System.Drawing.Point(315, 548);
            this.lblUserMassege.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserMassege.Name = "lblUserMassege";
            this.lblUserMassege.Size = new System.Drawing.Size(265, 22);
            this.lblUserMassege.TabIndex = 197;
            this.lblUserMassege.Text = "You cannot Change the Resulte";
            // 
            // ctrlScheduledTest1
            // 
            this.ctrlScheduledTest1.BackColor = System.Drawing.Color.White;
            this.ctrlScheduledTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlScheduledTest1.Location = new System.Drawing.Point(22, 12);
            this.ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            this.ctrlScheduledTest1.Size = new System.Drawing.Size(564, 518);
            this.ctrlScheduledTest1.TabIndex = 198;
            this.ctrlScheduledTest1.TestType = Bissens_layer.clsTestType.enTestType.VisionTest;
            // 
            // frmTakeTest
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 750);
            this.Controls.Add(this.ctrlScheduledTest1);
            this.Controls.Add(this.lblUserMassege);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNots);
            this.Controls.Add(this.rdbFial);
            this.Controls.Add(this.rdbPass);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Test";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.RadioButton rdbPass;
        private System.Windows.Forms.RadioButton rdbFial;
        private System.Windows.Forms.TextBox txtNots;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.Label lblUserMassege;
        private ctrlScheduledTest ctrlScheduledTest1;
    }
}