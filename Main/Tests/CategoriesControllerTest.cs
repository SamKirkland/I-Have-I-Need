using Main;
using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class CategoriesControllerTest
    {
        [TestMethod]
        public void testCreate()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult create1 = categoriesController.Create();

            Category category = new Category();
            category.CategoryID = 5;
            category.CategoryName = "Clothing";

            ActionResult create2 = categoriesController.Create(category);
        }

        [TestMethod]
        public void testIndex()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult index = categoriesController.Index();
        }

        public void testEdit()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult edit1 = categoriesController.Edit(5);

            Category category = new Category();
            category.CategoryID = 5;
            category.CategoryName = "Clothing";

            ActionResult edit2 = categoriesController.Edit(category);
        }

        public void testDelete()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult delete = categoriesController.Delete(5);
        }

        public void testDeleteConfirmed()
        {
            CategoriesController categoriesController = new CategoriesController();
            ActionResult deleteConfirmed = categoriesController.DeleteConfirmed(5);
        }
    }
}
