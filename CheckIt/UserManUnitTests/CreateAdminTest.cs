using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UserManagement;
namespace UserManagementTests
{
    [TestClass]
    public class CreateAdminTest
    {

        [TestMethod]
        public void create_admin_pass()
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

        public void create_admin_fail()
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