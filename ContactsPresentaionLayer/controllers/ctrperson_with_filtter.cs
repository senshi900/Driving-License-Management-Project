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
    
    public partial class ctrperson_with_filtter : UserControl
    {
        private int _id;
        public clsPerson person;
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }
        public ctrperson_with_filtter()
        {
            InitializeComponent();
        }

        private void ctrperson_with_filtter_Load(object sender, EventArgs e)
        {

        }
        public void SetFilter(bool value)
        {
            gbFilter.Enabled = value;

        }
        public int PersonID
        {
            get { return ctrlUser1.PersonID; }
        }
        public void SetUser(int id)
        {
           
            ctrlUser1.SetUserID(id);
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            ctrlUser1.SetUserID(int.Parse(textBox1.Text));
            person = clsPerson.GetPersonByID(int.Parse(textBox1.Text));
        }

        private void ctrlUser1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add_new_person frm = new add_new_person(-1);
            frm.ShowDialog();
        }
        public int CurrentID
        {
            get { return _id = int.Parse(textBox1.Text); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
