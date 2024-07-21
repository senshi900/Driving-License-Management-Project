using ContactBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class add_new_person : Form
    {
        public enum Enmood { Add=0,update=1};
        private Enmood _mood;
        clsPerson person;
        int CurrentId;
        public add_new_person(int id)
        {
            InitializeComponent();
            
            CurrentId = id;
            if (id == -1)
            {
                _mood=Enmood.Add;
            }
            else
            {
                _mood = Enmood.update;
            }
        }

        private void add_new_person_Load(object sender, EventArgs e)
        {
            if (_mood == Enmood.update)
            {
                person = clsPerson.GetPersonByID(CurrentId);
                LoadData();
                fillcountrys();
            }else if(_mood == Enmood.Add)
            {
                person = new clsPerson();
                LoadData();
            }
            
            
               







        }
        public void fillcountrys()
        {
            DataTable per= person_country.getallcountrys();
            foreach (DataRow row in per.Rows)
            {
                cbcountry.Items.Add(row["CountryName"]);
            }

            cbcountry.SelectedIndex = cbcountry.FindString(person_country.getcountrybyid(person.NationalityCountryID).countryname);
                
        }
        public void LoadData()
        {
            if (person.PersonID == -1)
            {
                lbID.Text = "??";
            }
            else
            {
                lbID.Text=person.PersonID.ToString();
            }
            tbfirst.Text = person.FirstName;
            tbsecond.Text = person.SedoundName;
            tbthird.Text = person.ThirdName;
            tblast.Text = person.LastName;
            tbNationalNo.Text = person.NationalityNo;
            dateTimePicker1.Value = person.DateOfBirth;
            if (person.Gendor == 0)
            {
                rdmale.Select();
            }
            else
            {
                rdfemale.Select();
            }
            tbphone.Text = person.Phone;
            tbemail.Text=person.Email;
            tbadrees.Text = person.Address;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            if (person.ImagePath== ""&&rdfemale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\male.jpg";
                btnremove.Visible = false;
            }else if(person.ImagePath == "" && rdmale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                btnremove.Visible = false;
            }
            else
            {
                pictureBox1.ImageLocation=person.ImagePath;
                btnremove.Visible = true;
            }


            
            
            




        }
        private void llOpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
               // ... 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                person.ImagePath = selectedFilePath;
                pictureBox1.Load(person.ImagePath);
                // ...
                btnremove.Visible = true;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            person.ImagePath = "";
            pictureBox1.ImageLocation = null;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            save();
            lbID.Text = person.PersonID.ToString();
           
        }

        public void save()
        {
           
            person.FirstName = tbfirst.Text;
            person.SedoundName = tbsecond.Text;
            person.ThirdName = tbthird.Text;
            person.LastName = tblast.Text;
            person.NationalityNo = tbNationalNo.Text;
            person.DateOfBirth = dateTimePicker1.Value;
            person.Gendor = rdmale.Checked ? 0 : 1;
            person.Phone = tbphone.Text;
            person.Email = tbemail.Text;
            person.Address = tbadrees.Text;
            person.NationalityCountryID = 1;
          //  person.ImagePath = pictureBox1.ImageLocation;
            // person.addperson();
            person.Save();
             _HandelPersonImage();
            

                                                                  
        }
        private  bool _HandelPersonImage()
        {
            if (person.ImagePath != pictureBox1.ImageLocation)
            {
                if (person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(person.ImagePath);
                    }
                    catch (Exception ex)
                    {

                    }

                }
                if (pictureBox1.ImageLocation != null)
                {
                    string SourceImageFile = pictureBox1.ImageLocation.ToString();
                    if (CopyToImageProjectFolders(ref SourceImageFile))
                    {
                        pictureBox1.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("error");
                        return false;
                    }

                }



            }
            return true;
        }
        public static bool CopyToImageProjectFolders(ref string sourceFile)
        {
            string DestnationFolder = @"C:\DVLD-People-Images\";
            string DestnationFile = DestnationFolder + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, DestnationFile, true);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            sourceFile = DestnationFile;
            return true;
        }


        public static string ReplaceFileNameWithGUID(string sourceFile)
        {
            string fileName= sourceFile;
            FileInfo info = new FileInfo(fileName);
            string extn= info.Extension;
            return Guid.NewGuid().ToString() + extn;
        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
            if (person.ImagePath == "" && rdfemale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\male.jpg";
                btnremove.Visible = false;
            }
            else if (person.ImagePath == "" && rdmale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                btnremove.Visible = false;
            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
                btnremove.Visible = true;
            }

        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
            if (person.ImagePath == "" && rdfemale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                btnremove.Visible = false;
            }
            else if (person.ImagePath == "" && rdmale.Checked)
            {
                pictureBox1.ImageLocation = "C:\\Users\\sensh\\OneDrive\\Desktop\\images\\female.jpg";
                btnremove.Visible = false;
            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
                btnremove.Visible = true;
            }

        }
    }
}
