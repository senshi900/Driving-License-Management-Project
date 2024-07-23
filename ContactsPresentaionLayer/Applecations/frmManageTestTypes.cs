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
    public partial class frmManageTestTypes : Form
    {

        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationTestUpdate frm =new frmApplicationTestUpdate((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsTestTypes.GetAllTestType();
        }

        //private void frmManageTestTypes_Load(object sender, EventArgs e)
        //{
        //    dataGridView1.DataSource= clsTestTypes.GetAllTestTypes();
        //    label3.Text =dataGridView1.RowCount.ToString();
        //}
    }
}
