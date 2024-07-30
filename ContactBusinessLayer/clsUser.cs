using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class clsUser 
    {
        public enum enMode { Add=1,Update=2}
        public enMode Mode=enMode.Add;
        public int UserID {  get; set; }
        public int PersonID {  get; set; }
        public clsPerson PersonInfo { get; set; }
        public string UserName { get; set; } 
        public string Password { get; set; }
       public bool IsActive { get; set; }


      public  clsUser() {
            this.IsActive = true;
         
            this.UserID = 0;
            this.UserName = "";
            this.Password = "";
            Mode = enMode.Add;
           
        }
      public  clsUser(int userID, string userName, int personID, string password, bool isActive)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.PersonID = personID;
            this.PersonInfo =  clsPerson.GetPersonByID(personID);
            this.Password = password;
            this.IsActive = isActive;
            Mode = enMode.Update;
        }

        private bool _AddnewUser()
        {
             this.UserID= clsUserData.AddNewUser(this.PersonInfo.PersonID,this.UserName,this.Password,this.IsActive);
            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.PersonID, this.UserName,
                this.Password, this.IsActive);
        }
        public static bool IsUserExsist(int personId)
        {
           return clsUserData.IsUSerExisist(personId);
        }
        public static clsUser GetUserByID(int personID)
        {
            int UserID = -1;
            string username = "";
            string password = "";
            bool isActive = false;
            if (clsUserData.GetUserInfoByID(personID, ref UserID, ref username, ref password, ref isActive))
            {
                return new clsUser(UserID, username,personID, password, isActive);
            }
            else
            {
                return null;
            }


        }
        public bool ChangePassword(int userid,string password)
        {
            return clsUserData.ChangePassword(userid,password);
        }
        public static clsUser CheckLogin(string username,string password )
        {
            int UserID=-1;
            int PersonID = -1;
            bool isActive = false;

            if(clsUserData.CheckLogin(username,password,ref UserID,ref PersonID,ref isActive))
            {
                return new clsUser(UserID, username, PersonID, password, isActive);
            }
            else
            {
                return null;
            }
            

           
        }
       
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    if (_AddnewUser())
                    {
                        Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
return false;
                    }
                    case enMode.Update:
                   if(_UpdateUser())
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                    

            }
            return false;
        }
    }
}
