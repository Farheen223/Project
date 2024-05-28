using System;

namespace ClassLibrary
{
    public class clsStaffUser
    {

        //Private data members
        private Int32 mUserID;
        private String mUserName;
        private String mPassword;
        private String mDepartment;


        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }


        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }


        public string Password
        {
            get
            {
                return mPassword;

            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //executing stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePswd");
            //if one record is found there should be one or none
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything works ok
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}