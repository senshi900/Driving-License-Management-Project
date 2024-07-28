using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBusinessLayer
{
    public  class clsLicenseApplication: clsApplications
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        //public clsLicenseClass LicenseClassInfo;
        public string PersonFullName
        {
           set; get;

        }


        private bool _AddNewLocalDrivingLicenseApplication()
        {
            //call DataAccess Layer 

            this.LocalDrivingLicenseApplicationID = clsLicenseApplicationData.AddNewLocalDrivingLicenseApplication
                (
                this.ApplicationsTypeID, this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

    }
}
