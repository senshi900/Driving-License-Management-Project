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
    public partial class simplecalc : UserControl
    {
        public delegate void sendresultback(object sender, int result);
        public event sendresultback backresult;
        public simplecalc()
        {
            InitializeComponent();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            lbresult.Text = ( num1+num2).ToString();
           
        }
        public int reault
        {
            get { return int.Parse( lbresult.Text); }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            int result = int.Parse(lbresult.Text);
           backresult?.Invoke(this, result);
         
        }

        private void simplecalc_Load(object sender, EventArgs e)
        {

        }
    }
}
