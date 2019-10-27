using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Figures;

namespace WebApplication1.Controllers
{
    public class AreaController : Controller
    {
        // GET: Area/Form
        public ActionResult Form()
        {  
            return View();
        }

        [HttpPost]
        [ActionName("Count")]
        public ActionResult Count(string sides)
        {
            Rectangle rec = new Rectangle();
            rec.sideA = Convert.ToInt32(sides);
            rec.sideB = Convert.ToInt32(sides);

            var cResult1 = new CalcResult { Result = 3 };

            return RedirectToAction("Calr", cResult1);

        }
        public ActionResult Calr(CalcResult newResult)
        {
            return View(newResult);
        }

      
    }
}