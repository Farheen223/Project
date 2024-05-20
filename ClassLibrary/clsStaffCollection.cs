using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //Private data member for the list
        List<clsStaff> staffList = new List<clsStaff>();
        //private data member for thisStaff
        clsStaff mThisStaff = new clsStaff();
       

        public clsStaffCollection()
        {
            //Variable for the index
            Int32 Index = 0;
            //variable for record count
            Int32 RecordCount = 0;
            //Object for data connect
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //Get the record count
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                clsStaff Staff = new clsStaff();
                //read in files for the current record
                Staff.FullTime = Convert.ToBoolean(DB.DataTable.Rows[Index]["FullTime"]);
                Staff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                Staff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Staff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                Staff.Hours = Convert.ToString(DB.DataTable.Rows[Index]["HoursWorked"]);
                Staff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                Staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                //Add record to the private data member
                mStaffList.Add(Staff);
                Index++;
            }
        }
        

        //private data member for the list
        public List<clsStaff> mStaffList  = new List<clsStaff>();
        public List<clsStaff> StaffList 
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value;
            }
           }
        public int Count 
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {
                //do later
            }
        
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a record to the database 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffName", mThisStaff.Name);
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@HoursWorked", mThisStaff.Hours);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@FullTime", mThisStaff.FullTime);

            //return the primary key
            return DB.Execute("sproc_tblStaff_Insert");

        }
    }
}