using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class TestHomeController : Controller
    {

        // GET: TestHome
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult TestHome()
        {
            return View();
        }

        //Go to testhome/somemethodname -> observe and discuss What should be modified to fix the issue from step 3?
        //[ActionName("some")]
        public ActionResult SomeMethodName()
        {
            return View();
        }

        // testhome/calc
        // this is a non action
        [NonAction]
        public ActionResult Calc()
        {
            return View();
        }

        // testhome/VerbsTestPut
        // this is a http post request - doesn not return anything
        [HttpPost]
        public ContentResult VerbsTestPut()
        {
            return Content("Hello - Post");
        }

        // testhome/VerbsTestGet
        // get http request - returns message
        [HttpGet]
        public ContentResult VerbsTestGet()
        {
            return Content("Hello  - Get");
        }

        // testhome/ThisMethodNeedsAuthorization
        // redirects to log in page if not authorized
        [Authorize]
        public ContentResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello - ThisMethodNeedsAuthorization ");
        }

        // testhome/ThisMethodNeedsAuthorizationAdmin
        // redirects to log in page if not authorized - requires admin rights
        [Authorize(Roles ="Admin")]
        public ContentResult ThisMethodNeedsAuthorizationAdmin()
        {
            return Content("Hello - ThisMethodNeedsAuthorizationAdmin");
        }
    }
}
