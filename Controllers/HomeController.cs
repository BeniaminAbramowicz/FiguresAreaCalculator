using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        public JsonResult Count(CalculationData calculationData)
        {
            double figArea = 0;
            double sA;
            double sB;
            double h;
            double rad;
            string[] numbers;
            switch (calculationData.ChosenFigure)
            {
                case "square":
                    Square sq = new Square();
                    sq.sideA = Convert.ToDouble(calculationData.InputData.Trim());
                    figArea = Math.Round(sq.getArea(), 3);
                    break;

                case "rectangle":
                    Rectangle rec = new Rectangle();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    sB = Convert.ToDouble(numbers[1]);
                    rec.sideA = sA;
                    rec.sideB = sB;
                    figArea = Math.Round(rec.getArea(), 3);
                    break;

                case "circle":
                    Circle cir = new Circle();
                    rad = Convert.ToDouble(calculationData.InputData.Trim());
                    cir.radius = rad;
                    figArea = Math.Round(cir.getArea(), 3);
                    break;

                case "triangle":
                    Triangle tri = new Triangle();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    h = Convert.ToDouble(numbers[1]);
                    tri.sideA = sA;
                    tri.height = h;
                    figArea = Math.Round(tri.getArea(), 3);
                    break;

                case "trapezoid":
                    Trapezoid trap = new Trapezoid();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    sB = Convert.ToDouble(numbers[1]);
                    h = Convert.ToDouble(numbers[2]);
                    trap.sideA = sA;
                    trap.sideB = sB;
                    trap.height = h;
                    figArea = Math.Round(trap.getArea(), 3);
                    break;

                case "rhombus":
                    Rhombus rh = new Rhombus();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    h = Convert.ToDouble(numbers[1]);
                    rh.sideA = sA;
                    rh.height = h;
                    figArea = Math.Round(rh.getArea(), 3);
                    break;
            }
            return Json(figArea, JsonRequestBehavior.AllowGet);
        }
   
    }
}