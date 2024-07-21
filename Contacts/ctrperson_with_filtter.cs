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
        public ctrperson_with_filtter()
        {
            InitializeComponent();
        }

        private void ctrperson_with_filtter_Load(object sender, EventArgs e)
        {

        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            ctrlUser1.SetUserID(int.Parse(textBox1.Text));
        }
    }
}
