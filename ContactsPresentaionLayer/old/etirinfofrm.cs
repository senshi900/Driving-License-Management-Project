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
    public partial class etirinfofrm : Form
    {
        int ccurrentId;
        information _contacts;
       public enum enmood {add=1,update=2}
      private  enmood _mood;
        public etirinfofrm(int id)
        {
            InitializeComponent();
            ccurrentId = id;
            if (ccurrentId ==-1)
            {
                _mood=enmood.add;

            }
            else
            {
                _mood=enmood.update;
            }
            

        }

        public void loadpage()
        {
            if(_mood==enmood.add)
            {
                _contacts = new information();

                
            }
            else if(_mood==enmood.update)
            {
                _contacts = information.getinfobyid(ccurrentId);

               
            }

          lbid.Text= _contacts.id.ToString();
          tbname.Text= _contacts.name.ToString();
          tbphone.Text= _contacts.phone.ToString();


           

            
          
            
        }

        private void etirinfofrm_Load(object sender, EventArgs e)
        {
          loadpage();
           

        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            _contacts.name = tbname.Text;
            _contacts.phone = tbphone.Text;
        bool n=  _contacts.save();
            MessageBox.Show($"{n}.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(simplecalc1.reault.ToString() );
        }
    }
}
