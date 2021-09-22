using LabDemoEF.Logic;
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
        public ActionResult Index(SuppliersModel modelo)
        {
            modelo = new SuppliersModel();
            List<LabDemoEF.Entities.Suppliers> resultado = new List<LabDemoEF.Entities.Suppliers>();
            List<SelectListItem> lista = new List<SelectListItem>(); 
            
            foreach (var supplier in _suppliersLogic.GetSuppliers().ToList())
            {
                lista.Add(new SelectListItem()
                {
                    Text = supplier.ContactName,
                    Value = supplier.SupplierID.ToString(),
                    Selected = false
                     
                });
                resultado.Add(new SuppliersModel()
                {
                    SupplierID= supplier.SupplierID,
                    ContactName= supplier.ContactName,
                    City = supplier.City,
                    Address = supplier.Address,
                    Phone = supplier.Phone,
                    CompanyName = supplier.CompanyName
                }
                );
                
            }
            
            modelo.SuppliersFilter = lista;
            modelo.Suppliers = resultado;
            
            return View(modelo);
        }
        [HttpPost]
        public ActionResult ReadSuppliers(SuppliersModel filtro)
        {
            SuppliersModel resultadoBusqueda = new SuppliersModel();
            
            resultadoBusqueda.Suppliers = _suppliersLogic.GetSuppliers().Where(f => f.SupplierID == filtro.SupplierID).ToList();
            
            return RedirectToAction("Index", "Home", resultadoBusqueda);
        }
       
        public ActionResult SuppliersDetail()
        {
            ViewBag.Message = "Agregar Nuevo Proveedor";
            return View();
        }

        [HttpPost]
        public ActionResult AddSuppliers(SuppliersDetail detail)
        {
            var ultimoId = _suppliersLogic.GetSuppliers().Count();
            detail.SupplierID = ultimoId + 1;
            var result = _suppliersLogic.AddSupplier(detail);
            return View("Index");
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