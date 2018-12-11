using CheckIt.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CheckIt.UserManagementTests

namespace UserManagementTests
{
    [TestClass]
    public class DeletionTest
    {
        [TestMethod]
        public void delete_self()
        {
            //user can request to delete self
            //Arrange
            User usr = new User();
            Deletion delete = new Delete();
           
            bool expected = true;
            bool actual;

            //Act
            actual = delete.DeleteSelf(usr);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void admin_delete_user()
        {
            //Admin can delete user
            //Arrange
            Deletion delete = new Delete();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "admin_account@gmail.com";
            string email2 = "user_account@gmail.com";
            string action = "Delete_action"; //placeholder, which action goes here?

            bool expected = true;
            bool actual;

            //Act
            actual = delete.DeleteUser(token, email1, email2,action);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void admin_delete_admin()
        {
            //Admin cannot delete admin
            //Arrange
            Deletion delete = new Delete();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "admin1_account@gmail.com";
            string email2 = "admin2_account@gmail.com";
            string action = "Delete_action"; //placeholder, which action goes here?

            bool expected = false;
            bool actual;

            //Act
            actual = delete.DeleteUser(token, email1, email2, action);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void sysadmin_delete_admin()
        {
            //Sysadmin can delete admin
            //Arrange
            Deletion delete = new Delete();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "admin2_account@gmail.com";
            string action = "Delete_action"; //placeholder, which action goes here?

            bool expected = true;
            bool actual;

            //Act
            actual = delete.DeleteUser(token, email1, email2, action);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
