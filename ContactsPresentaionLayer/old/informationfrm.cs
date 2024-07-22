using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBusinessLayer;

namespace Contacts
{
    public partial class informationfrm : Form
    {
        public informationfrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void informationfrm_Load(object sender, EventArgs e)
        {

           dataGridView1.DataSource= information.getallcontact();


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etirinfofrm form = new etirinfofrm((int)dataGridView1.CurrentRow.Cells[0].Value);
            form.ShowDialog();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            etirinfofrm form = new etirinfofrm(-1);
            form.ShowDialog();
        }
    }
}
