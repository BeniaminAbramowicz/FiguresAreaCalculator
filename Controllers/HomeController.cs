using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using WebApplication1.Models;
using WebApplication1.Figures;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Area/Form
        public ActionResult Form()
        {
            return View();
        }

        [WebMethod]
        [ActionName("Count")]
        public JsonResult Count(string sides, string figure)
        {
            int figArea = 0;
            int sA = 0;
            int sB = 0;
            int h = 0;
            int rad = 0;
            string[] numbers;
            switch (figure)
            {
                case "square":
                    Square sq = new Square();
                    sq.sideA = Convert.ToInt32(sides);
                    figArea = sq.getArea();
                    break;

                case "rectangle":
                    Rectangle rec = new Rectangle();
                    numbers = sides.Split(null);
                    sA = Convert.ToInt32(numbers[0]);
                    sB = Convert.ToInt32(numbers[1]);
                    rec.sideA = sA;
                    rec.sideB = sB;
                    figArea = rec.getArea();
                    break;

                case "circle":
                    Circle cir = new Circle();
                    rad = Convert.ToInt32(sides);
                    cir.radius = rad;
                    figArea = cir.getArea();
                    break;

                case "triangle":
                    Triangle tri = new Triangle();
                    numbers = sides.Split(null);
                    sA = Convert.ToInt32(numbers[0]);
                    h = Convert.ToInt32(numbers[1]);
                    tri.sideA = sA;
                    tri.height = h;
                    figArea = tri.getArea();
                    break;
                    
            } 

            var cResult1 = new CalcResult { Result = figArea };


            //return Json(new { success = true, message = "Pole powierzchni figury wynosi: " + figArea }, JsonRequestBehavior.AllowGet);
            return Json(figArea, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Calr(CalcResult newResult)
        {
            return View(newResult);
        }
    }
}