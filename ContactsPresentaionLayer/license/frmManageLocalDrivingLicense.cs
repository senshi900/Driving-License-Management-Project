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
    public partial class frmManageLocalDrivingLicense : Form
    {
       // clsLocalDrivingApplication application;
        public frmManageLocalDrivingLicense()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox1.Visible = false;
        }

        private void frmManageLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex !=0)
            {
                textBox1.Visible=true;
            }
            else {
                dataGridView1.DataSource = clsApplication.GetAllApplications(); textBox1.Visible=false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedItem== "NationalNO")
            //{
            //    dataGridView1.DataSource = clsApplication.GetAllApplications();
            //}
            //else if(comboBox1.SelectedItem== "Status")
            //{
            //    dataGridView1.DataSource = clsApplication.GetAllApplications();
            //}
            //else
            //{
               
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNewLocalLicense frm = new frmNewLocalLicense();
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalLicense frm = new frmNewLocalLicense((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
