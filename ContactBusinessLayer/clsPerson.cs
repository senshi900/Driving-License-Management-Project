using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ContactsBusinessLayer;
using ContactsDataAccessLayer;

namespace ContactBusinessLayer
{
    public class clsPerson
    {

      public  enum enSave {Add=0,update=1 }
       private  enSave _mood;
        public int PersonID { get; set; }
        public string NationalityNo { get; set; }
        public string FirstName { get; set; }
        public string SedoundName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
       
        public int NationalityCountryID { get; set; }
        public string countryname {  get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalityNo = "";
            this.FirstName = "";
            this.SedoundName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Email = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.NationalityCountryID = 0;
            this.ImagePath = "";
            this.countryname = "";
            _mood = enSave.Add;
        }

        public clsPerson(int personID, string nationalityNo, string firstName, string sedoundName, string thirdName, string lastName, string email, DateTime dateOfBirth, int gendor, string address, string phone, int nationalityCountryID, string imagePath,string countryname)
        {
            this.PersonID = personID;
            this.NationalityNo = nationalityNo;
            this.FirstName = firstName;
            this.SedoundName = sedoundName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.NationalityCountryID = nationalityCountryID;
            this.countryname = countryname;
            this.ImagePath = imagePath;
            _mood=enSave.update;
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonContact.GetAllContacts();
        }

        public static clsPerson GetPersonByID(int id)
        {
            string nationalityNo = "";
            string firstName = "";
            string sedoundName = "";
            string thirdName = "";
            string lastName = "";
            string email = "";
            DateTime dateOfBirth = DateTime.MinValue;
            int gendor = 0;
            string address = "";
            string phone = "";
            int nationalityCountryID = 0;
            string imagePath = "";
            string countryname = "";

            clsperson_countrys.GetCountryInfoByID(id, ref countryname);
            

            

            if (clsPersonContact.GetContactInfoByID(id, ref nationalityNo, ref firstName, ref sedoundName, ref thirdName, ref lastName, ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(id, nationalityNo, firstName, sedoundName, thirdName, lastName, email, dateOfBirth, gendor, address, phone, nationalityCountryID, imagePath,countryname);
            }
            else
            {
                return null;
            }

           
        }

        public static DataTable GetAllPersonsByID(string id)
        {
            return clsPersonContact.GetAllContactsByID(id);
        }
        public bool addperson()
        {
           this.PersonID=clsPersonContact.AddNewContact(this.NationalityNo, this.FirstName, this.SedoundName, this.ThirdName, this.LastName, this.Email, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != -1);
        }
        public bool updateperson(int id)
        {
            return clsPersonContact.UpdateContact(id, this.NationalityNo, this.FirstName, this.SedoundName, this.ThirdName, this.LastName, this.Email, this.DateOfBirth, this.Gendor, this.Address, this.Phone, this.NationalityCountryID, this.ImagePath);
        }


        public bool Save()
        {
            switch (_mood)
            {
                case enSave.Add:

                    if (addperson())
                    {
                        _mood = enSave.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   

                    

                case enSave.update:
                  return  updateperson(this.PersonID);
                    
                    
            }
            return false;
        }
    }
}
