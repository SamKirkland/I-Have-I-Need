using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeController()
        {
            HomeController homeController = new HomeController();
            ActionResult index = homeController.Index();
            ActionResult about = homeController.About();
            ActionResult contact = homeController.Contact();
        }
    }
}
