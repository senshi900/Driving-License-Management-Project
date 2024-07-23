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
    public partial class frmApplicationTestUpdate : Form
    {
        public clsTestTypes testtype;
        int currentid;
        public frmApplicationTestUpdate(int id)
        {
            InitializeComponent();
            currentid= id;
        }

        private void frmApplicationTestUpdate_Load(object sender, EventArgs e)
        {
            lbID.Text = currentid.ToString();
            testtype= clsTestTypes.getTestTypeByID(currentid);
            textBox1.Text = testtype.Title;
            textBox2.Text = testtype.Description;
            textBox3.Text = testtype.fees.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
       
            if(testtype.ChangeTypeAndFees(currentid,textBox1.Text,textBox2.Text,decimal.Parse(textBox3.Text)))
            {
                MessageBox.Show("update sucsusful", "done", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("update fail", "fail", MessageBoxButtons.OK);
            }
        }
    }
}
