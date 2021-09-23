using LabDemoEF.Logic;
using LabDemoEF.UI.Models.Shippers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabDemoEF.UI.Controllers
{
   
    public class ShippersController : Controller
    {
        private ShippersLogic _shippersLogic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShippersDetail()
        {
            ViewBag.Message = "Agregar Nuevo Proveedor";
            return View();
        }

        [HttpPost]
        public ActionResult AddShippers(ShippersDetail detail)
        {

            var result = _shippersLogic.AddShipper(detail);
            return View("Index");
        }
    }
}