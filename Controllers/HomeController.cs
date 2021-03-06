﻿using System;
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

        [HttpPost]
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
                    sq.SideA = Convert.ToDouble(calculationData.InputData.Trim());
                    figArea = Math.Round(sq.GetArea(), 3);
                    break;

                case "rectangle":
                    Rectangle rec = new Rectangle();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    sB = Convert.ToDouble(numbers[1]);
                    rec.SideA = sA;
                    rec.SideB = sB;
                    figArea = Math.Round(rec.GetArea(), 3);
                    break;

                case "circle":
                    Circle cir = new Circle();
                    rad = Convert.ToDouble(calculationData.InputData.Trim());
                    cir.Radius = rad;
                    figArea = Math.Round(cir.GetArea(), 3);
                    break;

                case "triangle":
                    Triangle tri = new Triangle();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    h = Convert.ToDouble(numbers[1]);
                    tri.SideA = sA;
                    tri.Height = h;
                    figArea = Math.Round(tri.GetArea(), 3);
                    break;

                case "trapezoid":
                    Trapezoid trap = new Trapezoid();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    sB = Convert.ToDouble(numbers[1]);
                    h = Convert.ToDouble(numbers[2]);
                    trap.SideA = sA;
                    trap.SideB = sB;
                    trap.Height = h;
                    figArea = Math.Round(trap.GetArea(), 3);
                    break;

                case "rhombus":
                    Rhombus rh = new Rhombus();
                    numbers = calculationData.InputData.Trim().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    sA = Convert.ToDouble(numbers[0]);
                    h = Convert.ToDouble(numbers[1]);
                    rh.SideA = sA;
                    rh.Height = h;
                    figArea = Math.Round(rh.GetArea(), 3);
                    break;
            }
            return Json(figArea);
        }
   
    }
}