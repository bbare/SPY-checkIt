using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserManagementTests
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void admin_configure_user()
        {
            //Configuring a user should pass because admin can configure user
            //Arrange
            Token token = new Token();
            string action = "Give_Access";
            string email1 = "admin_account@gmail.com";
            string email2 = "user_account@gmail.com";

            Configuration config = new Configuration();
            bool expected = true;
            bool actual;

            //Act
            actual = config.Configure(token, action, email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void admin_configure_admin()
        {
            //An admin cannot configure another admin
            //Arrange
            Token token = new Token();
            string action = "Give_Access";
            string email1 = "admin1_account@gmail.com";
            string email2 = "admin2_account@gmail.com";

            Configuration config = new Configuration();
            bool expected = false;
            bool actual;

            //Act
            actual = config.Configure(token, action, email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void sysadmin_configure_admin()
        {
            //A sysadmin can configure another admin
            //Arrange
            Token token = new Token();
            string action = "Give_Access";
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "admin1_account@gmail.com";

            Configuration config = new Configuration();
            bool expected = true;
            bool actual;

            //Act
            actual = config.Configure(token, action, email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void admin_configure_sysadmin()
        {
            //An admin cannot configure a sysadmin
            //Arrange
            Token token = new Token();
            string action = "Give_Access";
            string email1 = "sysadmin_account@gmail.com";
            string email2 = "admin1_account@gmail.com";

            Configuration config = new Configuration();
            bool expected = false;
            bool actual;

            //Act
            actual = config.Configure(token, action, email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
