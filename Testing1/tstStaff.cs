using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);
        }
    }
}
