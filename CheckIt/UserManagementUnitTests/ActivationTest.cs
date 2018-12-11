using CheckIt.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CheckIt.UserManagementTests
{
    [TestClass]
    public class ActivationTest
    {
        [TestMethod]
        public void sysadmin_activate_admin()
        {
            //Activate should pass because sysadmin is able to activate admin
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "admin_account@gmail.com";

            bool expected = true;
            bool actual;

            //Act
            actual = act.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void sysadmin_deactivate_admin()
        {
            //Activate should pass because sysadmin is able to deactivate admin
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "admin_account@gmail.com";

            bool expected = true;
            bool actual;

            //Act
            actual = act.Activate(token, "Dectivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void sysadmin_activate_user()
        {
            //Activate should pass because email1 has the proper actions
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "user_account@gmail.com";
             
            bool expected = true;
            bool actual;

            //Act
            actual = act.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void admin_activate_admin()
        {
            //activating should fail because admin should not be able to activate another admin
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "admin1_accountn@gmail.com";
            string email2 = "admin2_accountt@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void admin_deactivate_admin()
        {
            //activating should fail because admin1 should not be able to deactivate another admin
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "admin1_accountn@gmail.com";
            string email2 = "admin2_accountt@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        public void user_activate_admin()
        {
            //activating should fail because email1 does have not the right actions to activate accounts
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "user_accountn@gmail.com";
            string email2 = "admin_accountt@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void admin_deactivate_user()
        {
            //Deactivating should pass because email1 has the required actions
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "admin_account@gmail.com";
            string email2 = "user_account@gmail.com";

            bool expected = true;
            bool actual;

            //Act
            actual = act.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void user_deactivate_admin_test_()//necessary?
        {
            //Deactiving should fail because email1 does not have the required actions
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); //FIX: class token needs to be public
            string email1 = "user_account@gmail.com";
            string email2 = "admin_account@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void user_already_active_test()
        {
            //Activating should fail because the target user is ALREADY active
            //Arrange
            Activation act = new Activation();
            Token token = new Token();
            string email1 = "admin_account@gmail.com";
            string email2 = "user_account@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void user_already_deactive_test()
        {
            //Deactivating should fail because the target user is ALREADY deactive
            //Arrange
            Activation act = new Activation();
            Token token = new Token(); 
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "user_account@gmail.com";

            bool expected = false;
            bool actual;

            //Act
            actual = act.Activate(token, "Dectivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        
    }
}
