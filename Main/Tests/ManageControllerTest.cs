using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace Main
{
    [TestClass]
    public class ManageControllerTest
    {
        [TestMethod]
        public void testAddPhoneNumber()
        {
            ManageController manageController = new ManageController();
            ActionResult addPhoneNumber = manageController.AddPhoneNumber();
        }

        public void testSetPW()
        {
            ManageController manageController = new ManageController();
            ActionResult setPassword = manageController.SetPassword();
        }

        public void testChangeAvatar()
        {
            ManageController manageController = new ManageController();
            ActionResult changeAvatar = manageController.ChangeAvatar("HaveNeed");
        }

        public void testViewUser()
        {
            ManageController manageController = new ManageController();
            ActionResult viewUser = manageController.ViewUser("HaveNeed");
        }

        public void testRemoveLogin()
        {
            ManageController manageController = new ManageController();
            ActionResult removeLogin1 = manageController.RemoveLogin();

           var removeLogin2 = manageController.RemoveLogin("HaveNeed", "HaveNeed");
        }

        public void testRemovePhoneNumber()
        {
            ManageController manageController = new ManageController();
            var removePhoneNumber = manageController.RemovePhoneNumber();
        }

        public void testChangePW()
        {
            ManageController manageController = new ManageController();
            ActionResult changePW = manageController.ChangePassword();
        }

        public void testLinkLogin()
        {
            ManageController manageController = new ManageController();
            ActionResult linkLogin = manageController.LinkLogin("abpadan");
        }

        public void testLinkLoginCallback()
        {
            ManageController manageController = new ManageController();
            var linkLoginCallback = manageController.LinkLoginCallback();
        }
    }
}
