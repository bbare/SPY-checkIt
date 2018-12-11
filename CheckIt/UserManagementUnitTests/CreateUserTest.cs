using CheckIt.UserManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace CheckIt.UserManagementTests

{
    [TestClass]
    public class CreateUserTest
    {
        [TestMethod]
        public void create_user_success()
        {
            //Creating a user should be successful because all inputs requirements are met
            //Arrange
            string email = "HannahL@gmail.com";
            string fname = "Hannah";
            string lname = "Lemasters";
            DateTime dob = new DateTime(1998, 5, 1, 8, 30, 52);
            string atype = "Consumer";
            string city = "Long Beach";
            string state = "CA";
            string country = "USA";

            CreateUser create = new CreateUser();
            bool expected = true;
            bool actual;

            //Act //make sure createUser returns a bool
            actual = create.createUser(email, fname, lname, dob, atype, city, state, country);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void create_user_fail()
        {
            //Creating a user should be unsuccesful because the email should already exist in the system.
            //Arrange
            string email = "HannahL@gmail.com";
            string fname = "Kris";
            string lname = "Cahall";
            DateTime dob = new DateTime(1997, 4, 1, 8, 30, 52);
            string atype = "Consumer";
            string city = "Los Angeles";
            string state = "CA";
            string country = "USA";

            CreateUser create = new CreateUser();
            bool expected = false;
            bool actual;

            //Act
            actual = create.createUser(email, fname, lname, dob, atype, city, state, country);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void register_user_success()
        {
            //Registering a user should be successful because requirements are met
            //Arrange
            string email = "321abc@gmal.com";
            string password = "banana12345";
            string q1 = "What was your childhood nickname?";
            string q2 = "In what city or town did your mother and father meet?";
            string q3 = "What is your favorite sports team?";
            string a1 = "Mana";
            string a2 = "Sacramento";
            string a3 = "New England Patriots";

            CreateUser register = new CreateUser();
            bool expected = true;
            bool actual;

            //Act
            actual = register.RegisteredUser(email, password, q1, a1, q2, a2, q3, a3);


            //Assert
            Assert.AreEqual(expected, actual);

        }
        public void register_user_fail()
        {
            //Registering a user should fail because email should already be in the system
            //Arrange
            string email = "321abc@gmal.com";
            string password = "bananas5432";
            string q1 = "What was your childhood nickname?";
            string q2 = "What is your favorite movie?";
            string q3 = "What is your favorite sports team?";
            string a1 = "Joy";
            string a2 = "Moana";
            string a3 = "Golden State Warriors";

            CreateUser register = new CreateUser();
            bool expected = false; //a failed registerUser, what does it return?
            bool actual;

            //Act
            actual = register.RegisteredUser(email, password, q1, a1, q2, a2, q3, a3);


            //Assert
            Assert.AreEqual(expected, actual);

        }





    }
}