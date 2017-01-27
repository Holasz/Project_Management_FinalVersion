using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ActionResultController : Controller
    {
        // GET: ActionResult  ActionResult/
        public ActionResult Index()
        {
            return Content("This message is sent from the Index action!");
        }

        // ActionResult/RedirectPermanent
        // redirects to google home page
        public RedirectResult RedirectPermanent()
        {
            return Redirect("http://www.google.com");
        }

        //  ActionResult/RedirectToActionInTheSameController
        // redirects to index
        public RedirectToRouteResult RedirectToActionInTheSameController()
        {
            return RedirectToAction("Index");
        }
    }
}