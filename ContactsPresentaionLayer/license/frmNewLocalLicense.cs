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
        clsLocalDrivingApplication application;
        public frmNewLocalLicense()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           
            tabControl1.Enabled = true;
            tabControl1.SelectedTab = tabControl1.TabPages["tbApplication"];
            lbDate.Text = DateTime.Now.ToString();
           lbcurrentuser.Text= ctrperson_with_filtter1.person.FirstName.ToString();
            lbcreatedby.Text = Global.currentUser.UserName;
           
            lbfees.Text = "15";
        }

        private void tbApplication_Click(object sender, EventArgs e)
        {

        }

        private void tbinfo_Click(object sender, EventArgs e)
        {

        }

        private void btnsSave_Click(object sender, EventArgs e)
        {
           // application= new clsLocalDrivingApplication(ctrperson_with_filtter1.person.PersonID, DateTime.Now,1,2, DateTime.Now,20,1);
            //application.AddnewLocalLicense();
            lbID.Text=comboBox1.SelectedIndex.ToString();
            
        }
    }
}
