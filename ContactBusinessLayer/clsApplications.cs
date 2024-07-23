using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class clsApplications
    {
        public int ApplicationsTypeID { set; get; }
        public string ApplicationsTypeTitle{set;get;}
        public decimal ApplicationsFees { set; get; }



        public clsApplications()
        {
            this.ApplicationsTypeID = 0;
            this.ApplicationsTypeTitle = "";
            this.ApplicationsFees = 0;
        }
        public clsApplications(int applicationID,string ApplicationTitle, decimal ApplicationFees)
        {
            this.ApplicationsTypeID = applicationID;
            this.ApplicationsTypeTitle = ApplicationTitle;
            this.ApplicationsFees = ApplicationFees;
        }
        public bool ChangeTypeAndFees(int id, string type, decimal fees)
        {
            return clsApplicationsData.ChangeTypeAndFees(id, type, fees);
        }
        public static DataTable GetAllApplications()
        {
            return clsApplicationsData.GetAllApplications();
        }

        public static clsApplications GetApplicationByID(int applicationID)
        {
            string application = "";
            decimal feed = 0;
            if (clsApplicationsData.GetApplicationTypeByID(applicationID,ref application,ref feed ))
            {
                return new clsApplications(applicationID, application,feed);

            }
            else
            {
                return null;
            }
        }

      

    }
}
