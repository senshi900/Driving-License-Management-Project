using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class clsTestTypes
    {
        public int TestID {  get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public decimal fees { get; set; }

        public clsTestTypes() {
            this.TestID = 0;
            this.Title = "";
            this.Description = "";
            this.fees = 0;
        }

        public clsTestTypes(int testID,string title,string Description,decimal fees)
        {
            this.TestID = testID;
            this.Title = title;
            this.Description = Description;
            this.fees = fees;


        }


     public bool ChangeTypeAndFees(int id, string Title,string Description, decimal fees)
     {
         return clsTestTypeData.ChangeTestType(id, Title, Description, fees);
     }
  

        public static clsTestTypes getTestTypeByID(int id)
        {
            string testtype = "";
            string testtypedescription = "";
            decimal fees = 0;
          if(  clsTestTypeData.GetTestTypeByID(id, ref testtype, ref testtypedescription, ref fees))
            {
                return new clsTestTypes(id, testtype, testtypedescription, fees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllTestType()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

    }


  
}
