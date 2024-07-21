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
    public partial class person_info : Form
    {
        int currentid;
        clsPerson person;
        person_country country;
        public person_info(int ID)
        {
            InitializeComponent();
            currentid = ID;

        }

        private void person_info_Load(object sender, EventArgs e)
        {
           person =  clsPerson.GetPersonByID(currentid);
            country =  person_country.getcountrybyid(currentid);
            
            
            loaddata();
        }

        public void loaddata()
        {
            lbid.Text = person.PersonID.ToString();
            lbname.Text = person.FirstName+" "+person.SedoundName + " " + person.ThirdName + " " + person.LastName;
            lbnationalid.Text = person.NationalityNo.ToString();
            lbgendor.Text=person.Gendor.ToString();
            lbphone.Text = person.Phone.ToString();
            lbcountry.Text=country.countryname.ToString();
            lbemail.Text=person.Email.ToString();
            lbdate.Text=person.DateOfBirth.ToString();
            lbaddress.Text=person.Address.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\yuno.png";




        }
    }
}
