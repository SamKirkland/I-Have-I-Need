using Main;
using Main.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;

namespace MainTest
{
    [TestClass]
    public class PostsControllerTest
    {
        public void testIndex()
        {
            PostsController postControl = new PostsController();
            ActionResult index = postControl.Index("HaveNeed");
        }

        public void testDetails()
        {
            PostsController postControl = new PostsController();
            ActionResult details = postControl.Details(5);
        }

        [TestMethod]
        public void testCreate()
        {
            PostsController postControl = new PostsController();
            ActionResult create = postControl.Create();

            Post post = new Post();
            post.PostDate = DateTime.Now;
            postControl.Create(post);
        }

        public void testEdit()
        {
            PostsController postControl = new PostsController();
            ActionResult edit = postControl.Edit(5);

            Post post = new Post();
            post.PostDate = DateTime.Now;
            postControl.Edit(post);
        }

        public void testDelete()
        {
            PostsController postControl = new PostsController();
            ActionResult delete = postControl.Delete(5);
        }

        public void testDeleteConfirmed()
        {
            PostsController postControl = new PostsController();
            ActionResult deleteConfirmed = postControl.Delete(5);
        }
    }
}
