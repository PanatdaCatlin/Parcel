using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Parcels() 
        {
            return View("parcels");
        }
        [Route("/results")]
        public ActionResult Results() 
        {
            ParcelVariables myParcelVariable = new ParcelVariables(Int32.Parse(Request.Query["Length"]),Int32.Parse(Request.Query["Width"]),Int32.Parse(Request.Query["Height"]),Int32.Parse(Request.Query["Weight"]));
            Console.WriteLine(Int32.Parse(Request.Query["Length"]));
            return View("results", myParcelVariable);

        }
    }
}