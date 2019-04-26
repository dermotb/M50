using M50.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M50.Controllers
{
    public class TollController : Controller
    {
        // GET: Toll
        public ActionResult Index()
        {
            return RedirectToAction("Calculate");
        }

   
        // GET: Toll/Create
        public ActionResult Calculate()
        {
            ViewBag.TollCost = 0.00;
            return View();
        }

        // POST: Toll/Create
        [HttpPost]
        public ActionResult Calculate(TollVehicle vehicle)
        {
            try
            {
                ViewBag.TollCost = vehicle.CalculateCharge();
                return View(vehicle);
            }
            catch
            {
                return View();
            }
        }
    }
}
