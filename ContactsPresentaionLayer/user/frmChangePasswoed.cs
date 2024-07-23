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
    public partial class frmChangePass : Form
    {
        public clsUser user;
        public int currentid;
        public frmChangePass(int id)
        {
            InitializeComponent();
            currentid = id;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            user=clsUser.GetUserByID(currentid);
            ctrlUser1.SetUserID(user.PersonInfo.PersonID);
            lbid.Text=user.UserID.ToString();
            lbusername.Text = user.UserName;


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (tbcurrentpasswoed.Text != user.Password)
            {
                MessageBox.Show("current password is wrong", "password error", MessageBoxButtons.OK);
            }else if(tbnewpass.Text !=tbconfirmpass.Text ) {
                MessageBox.Show("Password dosent match", "password error", MessageBoxButtons.OK);
            }
            else
            {
                if (user.ChangePassword(currentid, tbconfirmpass.Text))
                {
                    MessageBox.Show("password has changed", "password changed", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("something went worng", "password error", MessageBoxButtons.OK);

                }
            }
        }
    }
}
