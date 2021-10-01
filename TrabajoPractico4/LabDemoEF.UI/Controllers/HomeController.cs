using LabDemoEF.Entities;
using LabDemoEF.Logic;
using LabDemoEF.UI.Models.Shippers;
using LabDemoEF.UI.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabDemoEF.UI.Controllers
{
    public class HomeController : Controller
    {
        private SuppliersLogic _suppliersLogic = new SuppliersLogic();
       
        public ActionResult Index()
        {
            ViewBag.Message = "Your home description page.";

            return View();
        }      

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}