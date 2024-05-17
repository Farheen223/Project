using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
       

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
        public clsStaff ThisStaff { get; set; }
    }
}