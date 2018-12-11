using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UserManagement;
namespace UserManagementTests
{
    [TestClass]
    public class ConfigurationTest
    {
        [TestMethod]
        public void configure_user_test_pass()
        {
            //Arrange
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.start();
            Configuration config = new Configuration();
            User user1 = new User();
            User user2 = new User();
            var email1 = user1.email;
            var email2 = user2.email;
            bool expected = true;
            bool actual;


            //Act
            config.Authorize(user1,user2);
            config.retrieveActions(user2);
            config.updateActions(user2);
            

            //Assert
            Assert.AreEqual(expected, actual);

            stopwatch.stop();
        
        }

        public void configure_test_fail()
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







    }
}