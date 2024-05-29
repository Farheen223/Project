using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection



    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create test data to assign to the property
            //This time it is a list
            List<clsStaff> TestList = new List<clsStaff>();
            //Add Item to the list
            clsStaff TestItem = new clsStaff();
            //Set the properties
            TestItem.StaffId = 2;
            TestItem.FullTime = true;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //Add the items to the list
            TestList.Add(TestItem);
            //Assign data to the property
            AllStaff.StaffList = TestList;
            //Test to see that the values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create new instance of class
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.FullTime = true;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmuac.uk";
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.FullTime = false;
            TestItem.Name = "Josh";
            TestItem.Email = "Josh@gmail.com";
            TestItem.Hours = "12";
            TestItem.PhoneNumber = "06543271823";
            TestItem.DateAdded = DateTime.Now;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

  

        [TestMethod]
        public void ThisStaffProperty()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff StaffTest = new clsStaff();
            //Set properties of test object
            StaffTest.StaffId = 2;
            StaffTest.FullTime = true;
            StaffTest.Name = "JohnHayes";
            StaffTest.Hours = "21";
            StaffTest.PhoneNumber = "07894447379";
            StaffTest.DateAdded = DateTime.Now;
            StaffTest.Email = "p2774538@my365.dmuac.uk";
            //assign the data
            AllStaff.ThisStaff = StaffTest;
            Assert.AreEqual(AllStaff.ThisStaff, StaffTest);
        }

        [TestMethod]
        public void ListAndCount()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //Create the test data
            clsStaff TestItem = new clsStaff();
            //Set the properties
            TestItem.StaffId = 2;
            TestItem.FullTime = true;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //Add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 Primarykey = 0;
            //set properties
            TestItem.FullTime = true;
            TestItem.StaffId = 2;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            Primarykey = AllStaff.Add();
            //Set the primary key
            TestItem.StaffId = Primarykey;
            //find the record
            AllStaff.ThisStaff.Find(Primarykey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.FullTime = true;
            TestItem.StaffId = 2;
            TestItem.Name = "JohnHayes";
            TestItem.Hours = "21";
            TestItem.PhoneNumber = "07894447379";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Email = "p2774538@my365.dmu.ac.uk";
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }




        [TestMethod]
        public void ReportByIDMethodOK()
        {
            clsStaffCollection Staff = new clsStaffCollection();
            //create new instance of filtered data
            clsStaffCollection FilteredID = new clsStaffCollection();
            //apply a blank string returns all records
            FilteredID.ReportByID("");
            //test to see that the two values are the same
            Assert.AreEqual(Staff.Count, FilteredID.Count);


        }

        [TestMethod]
        public void ReportByIDNotFound()
        {
            clsStaffCollection FilteredName = new clsStaffCollection();
            //apply a name that doesnt exist
            FilteredName.ReportByID("xxx xxx");
            //Test to see that there are no records
            Assert.AreEqual(0, FilteredName.Count);

        }

        [TestMethod]
        public void ReportByIDTestDataFound()
        {
            clsStaffCollection FilteredID = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredID.ReportByID("3");
            //check that the correct number of records are found
            if (FilteredID.Count == 2)
            {
                //check to see that the first record is 2
                if (FilteredID.StaffList[0].StaffId != 66)
                {
                    OK = false;
                }
                //check to see if the first record is 13
                if (FilteredID.StaffList[1].StaffId != 67)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
       


    }
}
