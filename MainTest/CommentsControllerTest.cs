using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class CommentsControllerTest
    {
        [TestMethod]
        public void testDetails()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult details = commentsController.Details(5);
        }

        public void testEdit()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult edit = commentsController.Edit(5);
        }

        public void testIndex()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult index = commentsController.Index();
        }

        public void testCreate()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult create = commentsController.Create();
        }


    }
}
