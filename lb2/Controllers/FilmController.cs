using lb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace lb2.Controllers
{
    public class FilmController : Controller
    {
        [HttpGet]
        public ViewResult GetInfo(Models.FilmData filmData)
        {
            ViewBag.Title = "Film";
            return View("Film", filmData);
        }
    }
}
