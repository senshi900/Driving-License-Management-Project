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
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public clsPerson PersonInfo {  get; set; }
        
        public string Password { get; set; }
       public bool IsActive { get; set; }


      public  clsUser() {
            this.IsActive = true;
            this.UserID = 0;
            this.UserName = "";
            this.Password = "";
           
        }
      public  clsUser(int userID, string userName, int personID, string password, bool isActive)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.PersonInfo =  clsPerson.GetPersonByID(personID);
            this.Password = password;
            this.IsActive = isActive;
        }

        public static DataTable GetAllUsers()
        {
           return clsUserData.GetAllUsers();
        }
        public int AddnewUser()
        {
            return this.UserID= clsUserData.AddNewUser(this.PersonInfo.PersonID,this.UserName,this.Password,this.IsActive);
        }
        public static bool IsUserExsist(int personId)
        {
           return clsUserData.IsUSerExisist(personId);
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
       
    }
}
