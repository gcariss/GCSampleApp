using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Look for TempData variable called success.
            // If Index is called on a redirect from the form submission,
            // the success variable will be set. 
            // Display success message on screen.
            string success = TempData["success"]?.ToString() ?? "false";

            if (success.ToUpper() == "true".ToUpper())
            {
                ViewBag.Result = "that worked";
            }

            //testing

            // build make drop down list            
            IndexModel Name = new IndexModel();
            Name.Makes.Add(new SelectListItem { Text = "Ford", Value = "0" });
            Name.Makes.Add(new SelectListItem { Text = "Chevy", Value = "1" });
            Name.Makes.Add(new SelectListItem { Text = "Audi", Value = "2" });
            Name.Makes.Add(new SelectListItem { Text = "Freightliner", Value = "3" });

 

            return View(Name);
        }
        public ActionResult Submit(String FirstName)
        {
            return Content(FirstName);
        }
        public ActionResult SelectCategory(IndexModel model)
        {
            bool success = true;
            TempData["success"] = success;
            return RedirectToAction("Index");
        }

    }
}