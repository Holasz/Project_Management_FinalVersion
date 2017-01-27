using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        private string message;
        List<string> cities = new List<string>();
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ContentResult DoAnAction()
        {
            return Content("Hello World!");
        }

        public string SayHello()
        {
            string name = "Moni Holasz";
            return "Hello, " + name;
        }

        // eg. project/hellouser/moni
        [Route("project/hellouser/{yourname}")]
        public string HelloUser(string yourname)
        {

            if (!String.IsNullOrEmpty(yourname))
            {
                string user = Server.HtmlEncode(yourname);
                return "Hello, " + user;
            }
            else return "Hello!";
        }

        // eg. project/new     project/berlin
        [Route("project/{alpha}")]
        public string SearchCities(string alpha)
        {
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");
            cities.Add("Istanbul");
            cities.Add("Bucharest");
            cities.Add("Cluj");

            string searchString = Server.HtmlEncode(alpha);

            if (!String.IsNullOrEmpty(searchString))
            {
                foreach (string item in cities)//Iterate through each item.
                {
                    if (item.ToString().ToLower().Contains(searchString)) // checking if any item contains searched text
                    {
                        return message = item.ToString();//Return the matched item.
                    }
                    else message = "City not found!";
                }
            }

            return message;

        }
    }
}