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

namespace Contacts.user
{
    public partial class frmAddUpdateUser : Form
    {
        public clsUser user;
        clsPerson person;
        public int currentID;
        public enum enMode{add=1,update=2};
        public enMode Mode;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            Mode = enMode.add;
        }
        public frmAddUpdateUser(int id)
        {
            InitializeComponent();
            ctrperson_with_filtter1.SetFilter(false);
            currentID = id;
            ctrperson_with_filtter1.SetUser(id);
            Mode = enMode.update;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (clsUser.IsUserExsist(ctrperson_with_filtter1.CurrentID))
            {
                MessageBox.Show("the user alredy exsist", "warning", MessageBoxButtons.OK);
            }
            else
            {
                tbLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbLoginInfo"];
            }
            
            //label4.Text= ctrperson_with_filtter1.CurrentID.ToString();
        }
        public void load()
        {
            user = clsUser.GetUserByID(currentID);
                lbuser.Text=user.UserID.ToString();
            tbusername.Text = user.UserName;
            tbpassword.Text = user.Password;
            tbconfirmpassword.Text = user.Password;
            chbActive.Checked = user.IsActive;
        }

        private void tbLoginInfo_Click(object sender, EventArgs e)
        {
            lbuser.Text = ctrperson_with_filtter1.PersonID.ToString();

        }
        public void save()
        {
            if(Mode == enMode.add)
            {
                person = clsPerson.GetPersonByID(ctrperson_with_filtter1.PersonID);
                user = new clsUser();
            }
           
            user.UserName = tbusername.Text;
            user.Password = tbpassword.Text;
            user.PersonInfo = person;
            user.IsActive = chbActive.Checked;
            user.Save();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
            MessageBox.Show("updated sucssuflly","save",MessageBoxButtons.OK);
            lbuser.Text=user.UserID.ToString();
        }

        private void chbActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPersonInfo_Click(object sender, EventArgs e)
        {

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.update)
            {
                load();
            }
           

        }

        private void ctrperson_with_filtter1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
