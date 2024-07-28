using ContactBusinessLayer;
using Contacts.Applecations;
using Contacts.license;
using Contacts.user;
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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }

        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managePepoleForm frm = new managePepoleForm();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(Global.currentUser.PersonInfo.PersonID);
                frm.Show();
        }

        private void iNFORMATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcountInfo frm = new frmAcountInfo(Global.currentUser.PersonInfo.PersonID);
            frm.ShowDialog();
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMangeApplecationTypes frm = new frmMangeApplecationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void localLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewLocalLicense frm = new frmNewLocalLicense();
            frm.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
