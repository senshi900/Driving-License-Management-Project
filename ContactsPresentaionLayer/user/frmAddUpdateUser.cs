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
        public frmAddUpdateUser()
        {
            InitializeComponent();
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

        private void tbLoginInfo_Click(object sender, EventArgs e)
        {
            lbuser.Text = ctrperson_with_filtter1.PersonID.ToString();

        }
        public void save()
        {
            person= clsPerson.GetPersonByID(ctrperson_with_filtter1.PersonID);
            user = new clsUser();
            user.UserName = tbusername.Text;
            user.Password = tbpassword.Text;
            user.PersonInfo = person;
            user.IsActive = chbActive.Checked;
            user.AddnewUser();


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
    }
}
