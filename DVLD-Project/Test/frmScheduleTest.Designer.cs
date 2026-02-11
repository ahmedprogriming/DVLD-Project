namespace DVLD_Project
{
    partial class frmScheduleTest
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
            this.btnClos = new System.Windows.Forms.Button();
            this.crlScheduleTest1 = new DVLD_Project.crlScheduleTest();
            this.SuspendLayout();
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
            this.btnClos.Location = new System.Drawing.Point(259, 677);
            this.btnClos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(133, 41);
            this.btnClos.TabIndex = 187;
            this.btnClos.Text = "    Close";
            this.btnClos.UseVisualStyleBackColor = false;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // crlScheduleTest1
            // 
            this.crlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.crlScheduleTest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crlScheduleTest1.Location = new System.Drawing.Point(12, 12);
            this.crlScheduleTest1.Name = "crlScheduleTest1";
            this.crlScheduleTest1.Size = new System.Drawing.Size(601, 658);
            this.crlScheduleTest1.TabIndex = 188;
            this.crlScheduleTest1.TestType = Bissens_layer.clsTestType.enTestType.VisionTest;
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 732);
            this.Controls.Add(this.crlScheduleTest1);
            this.Controls.Add(this.btnClos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClos;
        private crlScheduleTest crlScheduleTest1;
    }
}