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
    public partial class newform : Form
    {
        public delegate void resultback(object sender, int result);
        public event resultback resultt;
        public newform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBox1.Text);
            resultt?.Invoke(this, result);
            this.Close();
        }
    }
}
