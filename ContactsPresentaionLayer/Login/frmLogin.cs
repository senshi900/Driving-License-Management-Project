﻿using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.CheckLogin(textBox1.Text, textBox2.Text);

          if(user!=null)  {
                MessageBox.Show("welcome");
          
                frmhome frmhome = new frmhome();
                this.Hide();
                frmhome.ShowDialog();
            }
            else
            {
                MessageBox.Show("not authrized");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
