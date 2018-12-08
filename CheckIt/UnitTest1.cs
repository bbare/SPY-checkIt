using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckIt.Authorizations;
using CheckIt.DataAccessLayer;

namespace AuthorizationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /*This test checks to see if an action is authorized  */
        public void TestAuthorizeActionPass()
        {
            //Arrange
            string email = "example@gmail.com";
            List<string> actions = new List<string>()
            {
                "login",
                "adduser",
                "search"
            };
            int height = 2;
            string action = "adduser";

            IToken token = new Token(email, actions, height);
            //Act
            bool expected = true;
            bool actual = Authorization.AuthorizeAction(token, action);
            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        /*This test checks to see if a user can perform an admin action  */
        public void TestAuthorizeActionAddUserFail()
        {
            //Arrange
            string email = "example@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_Item_To_Watchlist",
                "Update_Profile",
                "Edit_Price_Threshold",
                "View_Watchlist",
                "Update_Password",
                "Delete_Self"
            };
            //changed from 2 to 3, probably not necessary b/c AuthorizeAction only tests the actions list, not height
            int height = 3; 
            string action = "Add_User";
            IToken token = new Token(email, actions, height);

            //Act
            bool expected = false;
            bool actual = Authorization.AuthorizeAction(token, action);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }       

        [TestMethod]
        /*This test checks NULL action against an actions list */
        public void TestAuthorizeNULLActionFail()
        {
            //Arrange
            string email = "example@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_Item_To_Watchlist",
                "Update_Profile",
                "Edit_Price_Threshold",
                "View_Watchlist",
                "Update_Password",
                "Delete_Self"
            };
            
            int height = 3; 
            string action = NULL;
            IToken token = new Token(email, actions, height);

            //Act
            bool expected = false;
            bool actual = Authorization.AuthorizeAction(token, action);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }           

        [TestMethod]
        /*This test checks empty action against an actions list */
        public void TestAuthorizeNOActionFail()
        {
            //Arrange
            string email = "example@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_Item_To_Watchlist",
                "Update_Profile",
                "Edit_Price_Threshold",
                "View_Watchlist",
                "Update_Password",
                "Delete_Self"
            };
            
            int height = 3; 
            string action = "";
            IToken token = new Token(email, actions, height);

            //Act
            bool expected = false;
            bool actual = Authorization.AuthorizeAction(token, action);

            //Assert
            Assert.AreEqual(expected, actual);
            
        } 
        
        [TestMethod]
        /*This test checks if an under age(<18) user can be authorized*/
        public void TestAuthorizeUnderAgeFail()
        {   
            // Creates DateTime object with information such as year, month,
            // day, hour, minute, second and milliseconds
            //Arrange
            DateTime dob = new DateTime(2001,11,6,1,30,8);
        
            //Act
            bool expected = false;
            bool actual = Authorization.authorizAge(dob);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        /*This test checks if an 18 year old user is authorized */
        public void TestAuthorizeOfAgePass()
        {
            //Arrange
            DateTime dob = new DateTime(2000,12,6,2,30,7);

            //Act
            bool expected = true;
            bool actual = Authorization.authorizAge(dob);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        /*This test checks if a user > 18 years old is authorized */
        public void TestAuthorizeOverAgePass(1994,11,6,7,30,9)
        {
            //Arrange
            DateTime dob = new DateTime();
            
            //Act
            bool expected = true;
            bool actual = Authorization.authorizAge(dob);

            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        /*This test checks if height 2 can Deactivate user2email, of height 3 */
        public void TestUUPermissionToDeactivatePass()
        {
            //Arrange
            string email = "example1000@gmail.com";
            List<string> actions = new List<string>()
            {
                "Activate_User",
                "Deactivate_User",
                "Delete_Account"
            };
            int height = 2;
            string action = "Deactivate_User";
            IToken token = new Token(email, actions, height);
            string user2email = "example@gmail.com"; //should have height 3 in db

            //Act
            bool expected = true;
            bool actual = AuthorizationManager.AuthorizeUserToUser(token, user2email,action);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        /*This test checks if sysadmin of height 1, can add EULA for height 3 user */
        public void TestUUAuthorizeAddEULAPass()
        {
            //Arrange
            string email = "example1000@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_EULA",
                "Update_EULA",
                "Delete_EULA"
            };
            int height = 1;
            string action = "Add_EULA";
            IToken token = new Token(email, actions, height);
            string user2email = "example@gmail.com"; //should have height 3 in db

            //Act
            bool expected = true;
            bool actual = AuthorizationManager.AuthorizeUserToUser(token, user2email,action);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        /*This test checks if user of height 3, can add Update profile for height 2 user */
        public void TestUUPermissionToUpdateFail()
        {
            //Arrange
            string email = "example1000@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_Item_To_Watchlist",
                "Update_Profile",
                "Edit_Price_Threshold",
                "View_Watchlist",
                "Update_Password",
                "Delete_Self"
            };
            int height = 3;
            string action = "Update_Profile"; //NOTE: contains action, but not authorized height
            IToken token = new Token(email, actions, height);
            string user2email = "admin_account@gmail.com"; //NOTE: Use account with height 2 in db

            //Act
            bool expected = false;
            bool actual = AuthorizationManager.AuthorizeUserToUser(token, user2email,action);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        /*This test checks if user of height 3, can self delete*/  
        //This test should fail according to the current code. It will return false. AuthorizeUserToUser(() does not have a case for user of height 3 to self delete
        public void TestUUPermissionToSelfDeletePass()
        {
            //Arrange
            string email = "user_height_3@gmail.com";
            List<string> actions = new List<string>()
            {
                "Add_Item_To_Watchlist",
                "Update_Profile",
                "Edit_Price_Threshold",
                "View_Watchlist",
                "Update_Password",
                "Delete_Self"
            };
            int height = 3;
            string action = "Delete_Self"; //contains action
            IToken token = new Token(email, actions, height);
            string user2email = email; // should have height 3 in db

            //Act
            bool expected = true;
            bool actual = AuthorizationManager.AuthorizeUserToUser(token, user2email,action);

            //Assert
            Assert.AreEqual(expected, actual);
        }
 

        // [TestMethod]
        // public void TestUUPermissionDiffHeightPass()
        // {
        //     //Arrange
        //     string email = "example1000@gmail.com";
        //     List<string> actions = new List<string>()
        //     {
        //         "Login",
        //         "Update",
        //         "Search"
        //     };
        //     int height = 1;
            
        //     IToken token = new Token(email, actions, height);
        //     string user2email = "example@gmail.com";
        //     //Act
        //     bool expected = true;
        //     bool actual = Authorization.UserToUserPermission(token, user2email);
        //     //Assert
        //     Assert.AreEqual(expected, actual);


        // }


        // [TestMethod]
        // public void TestUUPermissionDiffHeightFail()
        // {
        //     //Arrange
        //     string email = "example1000@gmail.com";
        //     List<string> actions = new List<string>()
        //     {
        //         "Login",
        //         "Update",
        //         "Search"
        //     };
        //     int height = 2;
        //     string action = "adduser";
        //     IToken token = new Token(email, actions, height);
        //     string user2email = "example1@gmail.com";
        //     //Act
        //     bool expected = true;
        //     bool actual = Authorization.UserToUserPermission(token, user2email);
        //     //Assert
        //     Assert.AreNotEqual(expected, actual);


        // }
    }
}