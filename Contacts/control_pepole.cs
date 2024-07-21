using ContactBusinessLayer;
using ContactsBusinessLayer;
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
    public partial class control_pepole : UserControl
    {
        DataTable table1;

        public control_pepole()
        {
            InitializeComponent();

            tbid.Visible = false;
        }

        internal void ShowDialog()
        {
            throw new NotImplementedException();
            
        }

        private void control_pepole_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPerson.GetAllPersons();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0){
                tbid.Visible = true;
            }
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPerson.GetAllPersonsByID(tbid.Text);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_new_person frm = new add_new_person((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_info frim = new person_info((int)dataGridView1.CurrentRow.Cells[0].Value);
            frim.ShowDialog();
        }
    }
}
