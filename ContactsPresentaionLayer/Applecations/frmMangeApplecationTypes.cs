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
    public partial class frmMangeApplecationTypes : Form
    {
        public frmMangeApplecationTypes()
        {
            InitializeComponent();
        }

        private void frmMangeApplecationTypes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource=clsApplicationTypres.GetAllApplications();
            label3.Text=dataGridView1.RowCount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplication frm = new frmUpdateApplication((int)dataGridView1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
        }
    }
}
