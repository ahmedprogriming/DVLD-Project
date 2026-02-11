using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bissens_layer;
using Business_Layer;
using static Bissens_layer.clsTestType;

namespace DVLD_Project
{
    public partial class frmTakeTest : Form
    {
        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        private int _TestID = -1;
        private clsTest _Test;

        private int _AppointemntsTestsID = -1;
        public frmTakeTest(int AppointemntsTestsID, enTestType TestType)
        {
            InitializeComponent();
            _AppointemntsTestsID= AppointemntsTestsID;
            _TestType= TestType;
        }

     

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTest1.TestType = _TestType;
            ctrlScheduledTest1.LoadInfo(_AppointemntsTestsID);

            if(ctrlScheduledTest1.AppointemntsTestsID==-1)
                btnSave.Enabled= false;
            else
                btnSave.Enabled= true;

            int TestID = ctrlScheduledTest1.TestID;
            if(TestID != -1)
            {
                _Test=clsTest.Find(TestID);
                if (_Test.ResulteTest)
                {
                    rdbPass.Checked = true;
                    rdbPass.Enabled = false;
                    rdbFial.Enabled = false;
                    btnSave.Enabled = false;
                }     
                else
                {
                    rdbFial.Checked = true;
                    rdbFial.Enabled = false;
                    rdbPass.Enabled = false;
                    btnSave.Enabled = false;
                    txtNots.Text = _Test.Notes;
                    lblUserMassege.Visible = true;
                }

              

            }
            else
            {
                _Test=new clsTest();
                lblUserMassege.Visible = false;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you sure of saved this Resulte?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                _Test.AppointementID = _AppointemntsTestsID;
                _Test.Notes = txtNots.Text;
                _Test.ResulteTest=rdbPass.Checked?true:false;
                _Test.CreatedUser=clsGlobel.CurrentUser.UserID;
               

                if (_Test.Save())
                {
                    MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
