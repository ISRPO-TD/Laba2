using lb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lb2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "MyCafe";
            return View();
        }

        [HttpGet]
        public ViewResult DrinkForm()
        {
            ViewBag.Title = "Drinks";
            return View();
        }

        [HttpPost]
        public ViewResult DrinkForm(DrinkData drinkData)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Title = "Bill";
                ViewBag.Cost = drinkData.getPrice();
                return View("Bill", drinkData);
            }
            else
            {
                return View();
            }
        }
    }
}