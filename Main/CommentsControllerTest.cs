using Main;
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
            ActionResult edit1 = commentsController.Edit(5);

            Comment testComment = new Comment();
            testComment.CommentDescription = "This is a comment.";
            testComment.PostID = 5;
            testComment.UserID = "1";

            ActionResult edit2 = commentsController.Create(testComment);
        }

        public void testIndex()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult index = commentsController.Index();
        }

        public void testCreate()
        {
            CommentsController commentsController = new CommentsController();
            ActionResult create1 = commentsController.Create();

            Comment testComment = new Comment();
            testComment.CommentDescription = "This is a comment.";
            testComment.PostID = 5;
            testComment.UserID = "1";

            ActionResult create2 = commentsController.Create(testComment);
        }
    }
}
