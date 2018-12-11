using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserManagementTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void activate_test_pass()
        {
            //Arrange
            Activate act = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = true; 
            bool actual; 
            
            //Act
            actual = active.Activate(token, "Activate_User", email1,email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void activate_test_fail()
        {
            //Arrange
            Activate act = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = true; 
            bool actual; 
            
            //Act
            actual = active.Activate(token, "Activate_User", email1,email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void deactivate_test_pass()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = true; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    
        public void deactivate_test_fail()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = fail; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void already_active_test_pass()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = true; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void already_active_test_fail()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = false; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Activate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void already_deactive_test_pass()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = true; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void already_deactive_test_fail()
        {
            //Arrange
            Activate deact = new Activate();
            var user1 = act.user1;
            var user2 = act.user2;
            bool expected = false; 
            bool actual; 
            
            //Act
            actual = deact.Activate(token, "Deactivate_User", email1, email2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    

    }    
}