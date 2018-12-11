using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UserManagement;
namespace UserManagementTests
{
    [TestClass]
    public class CreateUserTest
    {

        [TestMethod]
        public void create_user_pass()
        {
            //Arrange
            CreateUser create = new CreateUser();
            create.email = "abc123@gmail.com";
            create.fName = "Hannah";
            create.
            
            bool expected = true;
            bool actual;


            //Act
            

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void create_user_fail()
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