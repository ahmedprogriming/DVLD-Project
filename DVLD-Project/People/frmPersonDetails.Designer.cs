namespace DVLD_Project
{
    partial class Person_Details
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.crlPersonInformition1 = new DVLD_Project.crlPersonInformition();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(342, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = " Person Details";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(847, 491);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 39);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // crlPersonInformition1
            // 
            this.crlPersonInformition1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crlPersonInformition1.Location = new System.Drawing.Point(86, 123);
            this.crlPersonInformition1.Name = "crlPersonInformition1";
            this.crlPersonInformition1.Size = new System.Drawing.Size(869, 362);
            this.crlPersonInformition1.TabIndex = 47;
            this.crlPersonInformition1.Load += new System.EventHandler(this.crlPersonInformition1_Load);
            // 
            // Person_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 542);
            this.Controls.Add(this.crlPersonInformition1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Name = "Person_Details";
            this.ShowIcon = false;
            this.Text = "Person_Details";
            this.Load += new System.EventHandler(this.Person_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
    
        private System.Windows.Forms.Button btnClose;
        private crlPersonInformition crlPersonInformition1;
    }
}