using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Main
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new UserProfile(), 0);

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
    public class UserProfile : ActionFilterAttribute
    {
        private CSCI4830Entities db = new CSCI4830Entities();

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var currentUser = db.AspNetUsers.Where(u => u.Email == filterContext.HttpContext.User.Identity.Name);

            if (currentUser.Count() != 1)
            {
                filterContext.Controller.ViewBag.IsAdmin = 0;
                filterContext.Controller.ViewBag.avatar = "";
            }
            else
            {
                filterContext.Controller.ViewBag.IsAdmin = currentUser.First().Role;
                filterContext.Controller.ViewBag.avatar = currentUser.First().Avatar;
            }
        }

    }
}
