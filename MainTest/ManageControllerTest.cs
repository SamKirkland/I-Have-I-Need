using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class ManageControllerTest
    {
        [TestMethod]
        public void ManageController()
        {
            ManageController manageController = new ManageController();
            ActionResult addPhoneNumber = manageController.AddPhoneNumber();
            ActionResult setPassword = manageController.SetPassword();
        }
    }
}
