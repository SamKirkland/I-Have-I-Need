using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void testIndex()
        {
            HomeController homeController = new HomeController();
            ActionResult index = homeController.Index();
        }

        [TestMethod]
        public void testAbout()
        {
            HomeController homeController = new HomeController();
            ActionResult about = homeController.About();
        }

        [TestMethod]
        public void testContact()
        {
            HomeController homeController = new HomeController();
            ActionResult index = homeController.Contact();
        }
    }
}
