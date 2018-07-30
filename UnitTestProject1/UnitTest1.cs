using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment2Movies;
using System.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Database myDatabase = new Database();
        [TestMethod]
        public void TestConnection()
        {
            Assert.IsInstanceOfType(myDatabase.FillDGVCustomerWithCustomers(), typeof(DataTable));
        }
        [TestMethod]
        public void TestRentalCost_Old()
        {
            var oldDate = DateTime.Today.AddYears(-6).Year.ToString();
            Assert.AreEqual(2, myDatabase.GetRentalCost(oldDate));
        }
        [TestMethod]
        public void TestRentalCost_New()
        {
            var newDate = DateTime.Today.AddYears(2).Year.ToString();
            Assert.AreEqual(5, myDatabase.GetRentalCost(newDate));
        }
    }
}
