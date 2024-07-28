using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public class clsLocalDrivingApplication
    {
        public int ApplicationID {  get; set; }
        public int ApplicantPersonID {  get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }


        public clsLocalDrivingApplication()
        {
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0;
            ApplicationStatus = 0;
            CreatedByUserID = 0;
            ApplicationStatus = 0;
            LastStatusDate = DateTime.Now;
        }

        public clsLocalDrivingApplication(int ApplicantPersonID,DateTime ApplicationDate, int ApplicationTypeID,int ApplicationStatus,DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID)
        {
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;


        }

        public  int AddnewLocalLicense()
        {
            return this.ApplicationID= clsLocalDrivingApplicationData.AddNewLocalDrivingLicence(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }




    }
}
