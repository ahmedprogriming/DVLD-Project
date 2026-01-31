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
using DVLD_Project.Class_Global;
using DVLD_Project.Properties;

namespace DVLD_Project
{

    public partial class frmNewLocalLicenesApplicatio : Form
    {
        private int _Selectedperson = -1;
        private int _LocalDrivingLicenseApplicationsID = -1;
        private clsLocalDrivingLicenseApplications _clsLDLApp;
        enum enMode { Addnew = 0, Updata = 1 };
        enMode Mode;
        public frmNewLocalLicenesApplicatio()
        {
            InitializeComponent();
            Mode = enMode.Addnew;
        }

        public frmNewLocalLicenesApplicatio(int ID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationsID=ID;
        }

        private void _FillCombClassName()
        {
            DataTable dataTable = clsLicenseClass.GettAllLicenseClass();
            foreach (DataRow dr in dataTable.Rows)
            {
                cobTypeCliss.Items.Add(dr["ClassName"]);
            }
        }

        private void _ReasultDefult()
        {
            _FillCombClassName();
            if (Mode == enMode.Addnew)
            {
                lblTitel.Text = "New Local Driving License Applications";
                this.Text = "New Local Driving License Applications";
                _clsLDLApp = new clsLocalDrivingLicenseApplications();
                crlCardInfoWithFalter1.FilterFocus();
                tbApplicationInfo.Enabled = false;
                cobTypeCliss.SelectedIndex = 2;

                lblAppdate.Text = DateTime.Now.ToShortDateString();
                lblAppFees.Text =clsApplicatonType.FindAppTypeID((int)clsApplication.enApplicationType.NewLocalDrivinLicenseService).AppTypeFees.ToString();
                lblUserBy.Text = clsGlobel.CurrentUser.UserName;
            }
            else
            {
                lblTitel.Text = "Update Local Driving License Applications";
                this.Text = "Update Local Driving License Applications";
                tbApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
            }

          
        }

        //private void DataBackEvent(object sender, int PersonID)
        //{
        //    _Selectedperson = PersonID;
        //    crlCardInfoWithFalter1.LoadPersonInfo(PersonID);
        //}
        private void _LoadData()
        {
            crlCardInfoWithFalter1.FiltrEnbled = false;
            _clsLDLApp=clsLocalDrivingLicenseApplications.FindLocalDrivingLicenseApplicationsDataByID(_LocalDrivingLicenseApplicationsID);
            if (_clsLDLApp == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationsID, "Application not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            crlCardInfoWithFalter1.LoadPersonInfo(_Selectedperson);
            lblDLAppID.Text=_clsLDLApp.LocalDrivingLicenseApplicationID.ToString();
            lblAppdate.Text = clsFormat.DateToShort(_clsLDLApp.ApplicationDate);
            lblAppFees.Text = _clsLDLApp.PaidFees.ToString();
            cobTypeCliss.SelectedIndex =cobTypeCliss.FindString( clsLicenseClass.Find(_clsLDLApp.LicenseClassID).LicenseName);
            lblUserBy.Text=clsUser.FindByUserID(_clsLDLApp.CreatedByUserID).UserName;


        }
        private void frmNewLocalLicenesApplicatio_Load(object sender, EventArgs e)
        {
            _ReasultDefult();
            if (Mode == enMode.Updata)
                _LoadData();
           
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some filed are not valide, put the mous over the read icon", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int LinceseClassID=clsLicenseClass.Find(cobTypeCliss.Text).LicenseClassID;

            int ActiveApplication = clsLocalDrivingLicenseApplications.GetActiveApplicationByLicenseClassID(_Selectedperson, clsApplication.enApplicationType.NewInternationalLicense, LinceseClassID);
            if (ActiveApplication !=-1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplication, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cobTypeCliss.Focus();
                return;
            }

            if (clsLicense.IsExstesLicenseByPersonID(crlCardInfoWithFalter1.PersonID, LinceseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _clsLDLApp.ApplicantPersonID = crlCardInfoWithFalter1.PersonID;
            _clsLDLApp.ApplicationDate=DateTime.Now;
            _clsLDLApp.LastStatusDate=DateTime.Now;
            _clsLDLApp.ApplicationTypeID = 1;
            _clsLDLApp.CreatedByUserID=clsGlobel.CurrentUser.UserID;
            _clsLDLApp.ApplicationStatus = clsApplication.enApplicationStatue.New;
            _clsLDLApp.LicenseClassID = LinceseClassID;
            _clsLDLApp.PaidFees=Convert.ToSingle(lblAppFees.Text);
         

            if (_clsLDLApp.Save())
            {

                lblDLAppID.Text = _clsLDLApp.LocalDrivingLicenseApplicationID.ToString();
                Mode = enMode.Updata;
                lblTitel.Text = "Update Local Driving License Applications";
                MessageBox.Show(" Data Saved Successfully", "True", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro:Data is not Saved Successfully", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(Mode==enMode.Updata)
            {
                btnSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tbNewLocal.SelectedTab = tbApplicationInfo;
                return;
            }

            if(crlCardInfoWithFalter1.PersonID!=-1)
            {
                btnSave.Enabled = true;
                tbApplicationInfo.Enabled = true;
                tbNewLocal.SelectedTab = tbApplicationInfo;
            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                crlCardInfoWithFalter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cobTypeCliss_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cobTypeCliss.Text.Trim()))
            {
               
                errorProvider1.SetError(cobTypeCliss, "This filed is required!");
                return;
            }
            else
            {
                //e.Cancel = fales;
                errorProvider1.SetError(cobTypeCliss, null);
            }

        }

        private void crlCardInfoWithFalter1_OnPersonSelected(int obj)
        {
            _Selectedperson = obj;
        }

        private void frmNewLocalLicenesApplicatio_MdiChildActivate(object sender, EventArgs e)
        {

        }

        private void frmNewLocalLicenesApplicatio_Activated(object sender, EventArgs e)
        {
            crlCardInfoWithFalter1.FilterFocus();
        }
    }
}
