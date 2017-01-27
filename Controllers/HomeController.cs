using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Moni Holasz";
            var viewModel = new AboutModels
            {
                Author = "Moni Holasz",
                Message =" this is my about page"
            };
            return View(viewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public double Average()
        {
            Random rand = new Random();
            int[] randomList = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomList[i] = rand.Next(9);
            }

            double average = randomList.Average();
            return average;
        }

        public ContentResult HelloWorld()
        {
            return Content("Hello World!");
        }
    }
}