using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsDataAccessLayer;

namespace ContactBusinessLayer
{
    
        public class information
        {
        enum enMood { Add=1, Update=2}
        enMood mood;
            public int id
            {
                set;
                get;
            }
            public string name {set;get;}
            public string phone
            {
                set;
                get;
            }


            public information()
            {
                id = -1;
                name = "";
                phone = "";

         mood=   enMood.Add;
            }
            public information(int id, string name, string phone)
            {
                this.id = id;
                this.name = name;
                this.phone = phone;
            mood = enMood.Update;

            }
        private int adduser()
        {
           return clsinfo.AddNewContact(this.name, this.phone);

        }


            public static information getinfobyid(int id)

            {
                string name = "te";
                string  phone = "test";

               if( clsinfo.GetInformationById(id, ref name,ref phone))
            {
                return new information(id, name, phone);
            }
              
            else 
                return new information(id, "l", "l");
            }

            public static DataTable getallcontact()
            {
                return clsPersonContact.GetAllContacts();
            }
        public  bool updateuser()
        {
            return clsinfo.UpdateContact(this.id,this.name,this.phone);
        }
        public bool save()
        {
            switch (mood)
            {
                case enMood.Add:

                  int i=  adduser();
                    if (i != -1)
                    {
                        return true;
                    }

                    break;

                case enMood.Update:
                bool n=    updateuser();
                    return n;
                    break;
            }
            return false;

        }

    }
  
        
     
    }

