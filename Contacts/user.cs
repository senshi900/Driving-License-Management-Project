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
    public partial class ctrlUser : UserControl
    {
     int currentid;
     public  clsPerson person;
     public person_country country;
        public ctrlUser()
        {
            InitializeComponent();
        
        }
        
        public void SetUserID(int ID)
        {
           currentid= ID;
            person = clsPerson.GetPersonByID(currentid);
            country = person_country.getcountrybyid(currentid);
            loaddata();
        }

        private void user_Load(object sender, EventArgs e)
        {
  
        }
        public void loaddata()
        {

            lbid.Text = person.PersonID.ToString();
            lbname.Text = person.FirstName + " " + person.SedoundName + " " + person.ThirdName + " " + person.LastName;
            lbnationalid.Text = person.NationalityNo.ToString();
            lbgendor.Text = person.Gendor.ToString();
            lbphone.Text = person.Phone.ToString(); 
            lbcountry.Text = person.countryname.ToString();
            lbemail.Text = person.Email.ToString();
            lbdate.Text = person.DateOfBirth.ToString();
            lbaddress.Text = person.Address.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\yuno.png";


            if (person.ImagePath == "")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                
            }
            else if (person.ImagePath == "")
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                
            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
                
            }

        }
    }
}
