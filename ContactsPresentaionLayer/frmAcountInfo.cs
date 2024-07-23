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

namespace Contacts
{
    public partial class frmAcountInfo : Form
    {
       public clsUser user;
        public int currentid;
        public frmAcountInfo(int id)
        {
            InitializeComponent();
            currentid = id;
        }

        private void ctrlUser1_Load(object sender, EventArgs e)
        {
             user =  clsUser.GetUserByID(currentid);
            ctrlUser1.SetUserID(currentid);
            lbusername.Text = user.UserName;
            lbid.Text=user.UserID.ToString();
            

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAcountInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
