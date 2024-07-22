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
    public partial class managePepoleForm : Form
    {
        public managePepoleForm()
        {
            InitializeComponent();
        }

        private void control_pepole1_Load(object sender, EventArgs e)
        {
            
        }

        private void managePepoleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPerson.GetAllPersons();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_new_person frm = new add_new_person(-1);
            frm.ShowDialog();
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPerson.GetAllPersonsByID(tbid.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tbid.Visible = true;
            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_person_info frm = new frm_person_info((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_new_person frm = new add_new_person((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void infowithfilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindWithFillters frm = new frmFindWithFillters();
            frm.ShowDialog();


        }
    }
}
