using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserManagementTests
{
    [TestClass]
    public class CreateAdminTest
    {
        [TestMethod]
        public void sysadmin_create_admin()
        {
            //This test should pass becausC:\Users\Alex Philayvanh\Desktop\CheckIt\CheckIt\CheckIt\UserManagementTests\CreateAdminTest.cse all inputs are met
            //Arrange
            string email = "admin1@gmail.com";
            string fname = "Chae";
            string lname = "Hargett";
            DateTime dob = new DateTime(1994, 4, 7, 8, 30, 52);
            string atype = "Admin";
            string city = "Long Beach";
            string state = "CA";
            string country = "USA";

            CreateAdmin create = new CreateAdmin();
            bool expected = true;
            bool actual;

            //Act
            actual = create.adminMadeUser(email, fname, lname, dob, atype, city, state, country);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void admin_create_admin()
        {
            //This test should fail because admin cannot create admin
            //Arrange
            string email = "admin2@gmail.com";
            string fname = "Twanna";
            string lname = "Wentzell";
            DateTime dob = new DateTime(1996, 4, 2, 7, 30, 52);
            string atype = "Admin";
            string city = "Irvine";
            string state = "CA";
            string country = "USA";

            CreateAdmin create = new CreateAdmin();
            bool expected = false;
            bool actual;

            //Act
            actual = create.adminMadeUser(email, fname, lname, dob, atype, city, state, country);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void register_user_pass()
        {
            //This test should pass because requirements are met
            //Arrange
            string email = "pearl1234@gmal.com";
            string password = "banana12345";
            string q1 = "What was your childhood nickname?";
            string q2 = "In what city or town did your mother and father meet?";
            string q3 = "What is your favorite sports team?";
            string a1 = "Mana";
            string a2 = "Sacramento";
            string a3 = "New England Patriots";

            CreateAdmin register = new CreateAdmin();
            bool expected = false;
            bool actual;

            //Act
            actual = register.RegisteredUser(email, password, q1, a1, q2, a2, q3, a3);


            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void register_user_fail()
        {
            //This registering this user should fail because email is already be in the system
            //Arrange
            string email = "pearl1234@gmal.com";
            string password = "bananas5432";
            string q1 = "What was your childhood nickname?";
            string q2 = "What is your favorite movie?";
            string q3 = "What is your favorite sports team?";
            string a1 = "Joy";
            string a2 = "Moana";
            string a3 = "Golden State Warriors";

            CreateAdmin register = new CreateAdmin();
            bool expected = false;
            bool actual;

            //Act
            actual = register.RegisteredUser(email, password, q1, a1, q2, a2, q3, a3);


            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}
