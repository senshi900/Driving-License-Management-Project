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

namespace Contacts.Applecations
{
    public partial class frmUpdateApplication : Form
    {
        clsApplicationTypres applications;
        int currentid;
        public frmUpdateApplication(int id)
        {
            InitializeComponent();
            currentid = id;
        }

        private void frmUpdateApplication_Load(object sender, EventArgs e)
        {
            applications= clsApplicationTypres.GetApplicationByID(currentid);
            textBox1.Text = applications.ApplicationsTypeTitle;
            textBox2.Text = applications.ApplicationsFees.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           if( applications.ChangeTypeAndFees(currentid, textBox1.Text,decimal.Parse(textBox2.Text)))
            {
                MessageBox.Show("updated", "updade", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("not updated", "fail", MessageBoxButtons.OK);
            }
        }
    }
}
