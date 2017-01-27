using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class RedirectToActionInHomeController : Controller
    {
        // GET: RedirectToActionInHome
        public ActionResult Index()
        {
            return View();
        }

        // RedirectToActionInHome/RedirectToActionInHome
        // redirects to homepage
        public RedirectToRouteResult RedirectToActionInHome()
        {
            return RedirectToAction("Index", "Home");
        }

        // RedirectToActionInHome/RedirectToAboutInHome
        // redirects to about page from home controller
        public RedirectToRouteResult RedirectToAboutInHome()
        {
            return RedirectToAction("About", "Home");
        }

        // RedirectToActionInHome/ReturnFile
        // redirects to CSS file of the site
        public RedirectResult ReturnFile()
        {
            return Redirect("/Content/Site.css");
        }
    }
}