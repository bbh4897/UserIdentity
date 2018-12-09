using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserIdentity.Identity;

namespace UserIdentity.Controllers
{
    public class AdminController : Controller
    {

        private UserManager<AppIdentityUser> userManager;

        public AdminController()
        {
            var userStore = new UserStore<AppIdentityUser>(new AppIdentityDbContext());
            userManager = new UserManager<AppIdentityUser>(userStore);
        }

        // GET: Admin
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}