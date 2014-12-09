using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class PostsControllerTest
    {
        [TestMethod]
        public void PostsController()
        {
            PostsController postControl = new PostsController();
            ActionResult create = postControl.Create();
        }
    }
}
