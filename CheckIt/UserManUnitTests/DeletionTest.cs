using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UserManagement;
namespace UserManagementTests
{
    [TestClass]
    public class DeletionTest
    {

        [TestMethod]
        public void delete_test_pass()
        {
            //Arrange
            User user1 = new User();
            User user2 = new User();
            var email1 = user1.email;
            var email2 = user2.email;
            bool expected = true;
            bool actual;


            //Act
            

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void delete_test_fail()
        {
            //Arrange
            User user1 = new User();
            User user2 = new User();
            var email1 = user1.email;
            var email2 = user2.email;
            bool expected = false;
            bool actual;


            //Act
            

            //Assert
            Assert.AreEqual(expected, actual);
        }





    }
}