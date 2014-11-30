using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Main;

namespace Main.Controllers
{
    public class PostsController : Controller
    {
        private CSCI4830Entities db = new CSCI4830Entities();

        // GET: Posts
        public ActionResult Index(String search)
        {
            ViewBag.UserID = User.Identity.Name;

            var posts = db.Posts.Include(p => p.AspNetUser).Include(p => p.Category).OrderByDescending(p => p.PostDate);

            if (!String.IsNullOrEmpty(search)) {
                ViewBag.search = search;
                posts = posts.Where(p => p.Description.Contains(search) || p.Title.Contains(search)).OrderByDescending(p => p.PostDate);
            }

            return View(posts.ToList());
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            post.ViewCount = Convert.ToInt32(post.ViewCount) + 1;
            db.Entry(post).State = EntityState.Modified;
            db.SaveChanges();

            ViewData["comments"] = db.Comments.Include(p => p.AspNetUser).Where(p => p.PostID == post.PostID).ToList();

            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.AspNetUsers, "Id", "Email");
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,PostDate,Title,Description,ViewCount,CategoryID,Removed,Longitude,Latitude")] Post post)
        {
            post.PostDate = DateTime.Now;
            post.UserID = User.Identity.GetUserId();

            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.AspNetUsers, "Id", "Email", post.UserID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", post.CategoryID);
            return View(post);
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            // if the user is not an admin or the original poster, deny them access
            if (post.AspNetUser.Email != User.Identity.Name) {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            ViewBag.UserID = new SelectList(db.AspNetUsers, "Id", "Email", post.UserID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", post.CategoryID);
            return View(post);
        }

        // POST: Posts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PostID,UserID,PostDate,Title,Description,CategoryID,Removed,Longitude,Latitude")] Post post)
        {
            post.PostDate = DateTime.Now;
            post.UserID = User.Identity.GetUserId();

            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.AspNetUsers, "Id", "Email", post.UserID);
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "CategoryName", post.CategoryID);
            return View(post);
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }
            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
