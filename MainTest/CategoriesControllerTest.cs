using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class CategoriesControllerTest
    {
        [TestMethod]
        public void CategoriesController()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult result = categoriesController.Create();
        }
    }
}
