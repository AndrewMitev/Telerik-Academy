using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationalApp.Controllers
{
    public class DetailsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Addition()
        {
            return PartialView("_DetailsPartial");
        }
    }
}