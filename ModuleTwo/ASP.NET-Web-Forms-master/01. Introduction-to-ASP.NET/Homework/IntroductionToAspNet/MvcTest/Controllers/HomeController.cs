using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(FormCollection form)
        {
            return View();
        }


        public ActionResult CalculateSum(FormCollection form)
        {
            decimal firstNumber = decimal.Parse(form["FirstNumber"].ToString());
            decimal secondNumber = decimal.Parse(form["SecondNumber"].ToString());

            ViewBag.Result = firstNumber + secondNumber;
            return View("Index");
        }
    }
}