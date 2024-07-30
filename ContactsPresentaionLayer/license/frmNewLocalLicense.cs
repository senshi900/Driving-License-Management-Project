using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.license
{
    public partial class frmNewLocalLicense : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        public frmNewLocalLicense()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmNewLocalLicense(int id)
        {
            InitializeComponent();
            ctrperson_with_filtter1.SetFilter(false);

            _LocalDrivingLicenseApplicationID = id;
            _Mode = enMode.Update;
           

        }


        private void _LoadData()
        {
          _FillLicenseClassesInComoboBox();
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            comboBox1.SelectedIndex = comboBox1.FindString(_LocalDrivingLicenseApplication.LicenseClassInfo.ClassName);
            lbcreatedby.Text = _LocalDrivingLicenseApplication.CreatedByUserInfo.UserName.ToString();
            ctrperson_with_filtter1.SetUser(_LocalDrivingLicenseApplication.ApplicantPersonID);
            //lbcreatedby.Text=_LocalDrivingLicenseApplication.CreatedByUserInfo.UserName.ToString();
            lbDate.Text=_LocalDrivingLicenseApplication.ApplicationDate.ToString();
            lbfees.Text=_LocalDrivingLicenseApplication.PaidFees.ToString();
            lbID.Text=_LocalDrivingLicenseApplication.ApplicationID.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            tabControl1.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tbApplication"];
            lbDate.Text = DateTime.Now.ToString();
          
            lbcreatedby.Text = Global.currentUser.UserName;
            _SelectedPersonID = ctrperson_with_filtter1.PersonID;
           
            lbfees.Text = "15";
        }
        private void _FillLicenseClassesInComoboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                comboBox1.Items.Add(row["ClassName"]);
            }
        }

        private void tbApplication_Click(object sender, EventArgs e)
        {

        }

        private void tbinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnsSave_Click(object sender, EventArgs e)
        {
           // application= new clsApplication(ctrperson_with_filtter1.person.PersonID, DateTime.Now, comboBox1.SelectedIndex+1, 1, DateTime.Now,20,Global.currentUser.UserID);
            clsLocalDrivingLicenseApplication local =new clsLocalDrivingLicenseApplication();
            local.LicenseClassID = comboBox1.SelectedIndex + 1;
           // application.AddnewLocalLicense();
           // local.AddNewLocalDrivingLicenseApplication();
            lbID.Text=local.LocalDrivingLicenseApplicationID.ToString();
            
        }

        private void frmNewLocalLicense_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
           
        }
    }
}
