using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AreaController : Controller
    {
        // GET: Area/Form
        public ActionResult Form()
        {
            var cResult = new CalcResult() { Result = 4 };
            return View(cResult);
        }
    }
}