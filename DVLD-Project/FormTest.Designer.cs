namespace DVLD_Project
{
    partial class FormTest
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
            //this.crlPersonInformition1 = new DVLD_Project.crlPersonInformition();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crlPersonInformition1
            // 
            this.crlPersonInformition1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.crlPersonInformition1.Location = new System.Drawing.Point(104, 108);
            this.crlPersonInformition1.Name = "crlPersonInformition1";
            this.crlPersonInformition1.Size = new System.Drawing.Size(874, 396);
            this.crlPersonInformition1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(363, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 66);
            this.label2.TabIndex = 9;
            this.label2.Text = " Person Details";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 515);
            this.Controls.Add(this.crlPersonInformition1);
            this.Controls.Add(this.label2);
            this.Name = "FormTest";
            this.ShowIcon = false;
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private crlPersonInformition crlPersonInformition1;
        private System.Windows.Forms.Label label2;
    }
}