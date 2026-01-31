using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class Person_Details : Form
    {
     
        
        public Person_Details(int PersonID)
        {
            InitializeComponent();
     
     
            clrInformtionPople1.LoadPersonInfo(PersonID);
        }

        public Person_Details(string NationalNo)
        {
            InitializeComponent();
            clrInformtionPople1.LoadPersonInfo(NationalNo);
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Person_Details_Load(object sender, EventArgs e)
        {

        }

        private void crlPersonInformition1_Load(object sender, EventArgs e)
        {

        }
    }
}
