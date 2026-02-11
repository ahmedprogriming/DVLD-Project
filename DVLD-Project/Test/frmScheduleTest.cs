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
    public partial class frmScheduleTest : Form
    {
       
        private clsTestType.enTestType _TestType =clsTestType.enTestType.VisionTest;
       
      
        private int _AppointemntsTestsID=-1;
  
        private int _LocalDrivingID = -1;
        public frmScheduleTest(int LocalDrivingID, enTestType TestType,int AppointemntsTestsID=-1)
        {
            InitializeComponent();
            _AppointemntsTestsID = AppointemntsTestsID;
            _TestType =TestType;
            _LocalDrivingID = LocalDrivingID;
        }
  
       private void frmScheduleTest_Load(object sender, EventArgs e)
        {
           crlScheduleTest1.TestType=_TestType;
            crlScheduleTest1.LoadInfo(_LocalDrivingID, _AppointemntsTestsID);
       
        }


        private void btnClos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
