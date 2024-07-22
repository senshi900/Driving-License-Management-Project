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
    public partial class frm_person_info : Form
    {
        private int id;
        public frm_person_info(int ID)
        {
            InitializeComponent();
            this.id = ID;
        }

        private void frm_person_info_Load(object sender, EventArgs e)
        {
           user2.SetUserID(id);
        }

        private void user2_Load(object sender, EventArgs e)
        {

        }
    }
}
