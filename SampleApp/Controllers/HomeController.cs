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
            string success = TempData["success"]?.ToString() ?? "false";

            if (success.ToUpper() == "true".ToUpper())
            {
                ViewBag.Result = "that worked";
            }

            
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Ford", Value = "0" });

            items.Add(new SelectListItem { Text = "Chevy", Value = "1" });

            items.Add(new SelectListItem { Text = "Audi", Value = "2" });

            items.Add(new SelectListItem { Text = "Freightliner", Value = "3" });

            ViewBag.VehMake = items;

            return View();
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