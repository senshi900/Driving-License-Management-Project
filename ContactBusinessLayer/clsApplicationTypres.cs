using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class clsApplicationTypres
    {
        public int ApplicationsTypeID { set; get; }
        public string ApplicationsTypeTitle{set;get;}
        public decimal ApplicationsFees { set; get; }



        public clsApplicationTypres()
        {
            this.ApplicationsTypeID = 0;
            this.ApplicationsTypeTitle = "";
            this.ApplicationsFees = 0;
        }
        public clsApplicationTypres(int applicationID,string ApplicationTitle, decimal ApplicationFees)
        {
            this.ApplicationsTypeID = applicationID;
            this.ApplicationsTypeTitle = ApplicationTitle;
            this.ApplicationsFees = ApplicationFees;
        }
        public bool ChangeTypeAndFees(int id, string type, decimal fees)
        {
            return clsApplicationTypesData.ChangeTypeAndFees(id, type, fees);
        }
        public static DataTable GetAllApplications()
        {
            return clsApplicationTypesData.GetAllApplications();
        }

        public static clsApplicationTypres GetApplicationByID(int applicationID)
        {
            string application = "";
            decimal feed = 0;
            if (clsApplicationTypesData.GetApplicationTypeByID(applicationID,ref application,ref feed ))
            {
                return new clsApplicationTypres(applicationID, application,feed);

            }
            else
            {
                return null;
            }
        }

      

    }
}
