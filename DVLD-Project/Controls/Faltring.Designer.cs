namespace DVLD_Project
{
    partial class Faltring
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobFilter = new System.Windows.Forms.ComboBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.btnsearchPerson = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearchPerson);
            this.groupBox1.Controls.Add(this.btnAddNewPerson);
            this.groupBox1.Controls.Add(this.txbFilter);
            this.groupBox1.Controls.Add(this.cobFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Urdu Typesetting", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By :";
            // 
            // cobFilter
            // 
            this.cobFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cobFilter.FormattingEnabled = true;
            this.cobFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "National No",
            "FirstName",
            "scoendName",
            "Thirdname",
            "LastName",
            "Gendor"});
            this.cobFilter.Location = new System.Drawing.Point(94, 44);
            this.cobFilter.Name = "cobFilter";
            this.cobFilter.Size = new System.Drawing.Size(193, 24);
            this.cobFilter.TabIndex = 5;
            // 
            // txbFilter
            // 
            this.txbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbFilter.Location = new System.Drawing.Point(293, 44);
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(199, 24);
            this.txbFilter.TabIndex = 6;
            // 
            // btnsearchPerson
            // 
            this.btnsearchPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsearchPerson.BackColor = System.Drawing.Color.White;
            this.btnsearchPerson.Image = global::DVLD_Project.Properties.Resources.SearchPerson;
            this.btnsearchPerson.Location = new System.Drawing.Point(520, 28);
            this.btnsearchPerson.Name = "btnsearchPerson";
            this.btnsearchPerson.Size = new System.Drawing.Size(60, 47);
            this.btnsearchPerson.TabIndex = 14;
            this.btnsearchPerson.UseVisualStyleBackColor = false;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddNewPerson.BackColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = global::DVLD_Project.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.Location = new System.Drawing.Point(586, 28);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(60, 47);
            this.btnAddNewPerson.TabIndex = 13;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            // 
            // Faltring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Faltring";
            this.Size = new System.Drawing.Size(657, 104);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobFilter;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Button btnsearchPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
    }
}
