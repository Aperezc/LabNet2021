using LabDemoEF.Entities;
using LabDemoEF.Logic;
using LabDemoEF.UI.Models.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabDemoEF.UI.Controllers
{
    public class SuppliersController : Controller
    {
        private SuppliersLogic _suppliersLogic = new SuppliersLogic();

        public ActionResult Index(int? IDSupplier)
        {
            SuppliersViewModel suppliersView = new SuppliersViewModel();

            List<LabDemoEF.Entities.Suppliers> suppliers = _suppliersLogic.GetSuppliers().ToList();
            List<SelectListItem> lista = new List<SelectListItem>();

            lista.Add(new SelectListItem()
            {
                Text = "Seleccione",
                Value = null,
                Selected = true
            });
            foreach (var supplier in suppliers)
            {
                lista.Add(new SelectListItem()
                {
                    Text = supplier.ContactName,
                    Value = supplier.SupplierID.ToString(),
                    Selected = false

                });

            }
            if (IDSupplier != null)
            {

                suppliersView.Suppliers = suppliers.Where(s => s.SupplierID == IDSupplier).Select(s => new SuppliersDetailViewModel
                {
                    IDSupplier = s.SupplierID,
                    ContactName = s.ContactName,
                    CompanyName = s.CompanyName,
                    Address = s.Address,
                    City = s.City,
                    Phone = s.Phone,
                }).ToList();
            }
            else
            {
              
                suppliersView.Suppliers = suppliers.Select(s => new SuppliersDetailViewModel
                {
                    IDSupplier = s.SupplierID,
                    ContactName = s.ContactName,
                    CompanyName = s.CompanyName,
                    Address = s.Address,
                    City = s.City,
                    Phone = s.Phone,
                }).ToList();
            }


            suppliersView.SuppliersFilter = lista;


            return View(suppliersView);
        }

        public ActionResult AddModifySuppliers(int idSupplier)
        {
            SuppliersDetailViewModel detail;
            if (idSupplier != 0)
            {

                Suppliers supplier = _suppliersLogic.GetSuppliers().Where(f => f.SupplierID == idSupplier).FirstOrDefault();
                detail = new SuppliersDetailViewModel()
                {
                    IDSupplier = idSupplier,
                    ContactName = supplier.ContactName,
                    CompanyName = supplier.CompanyName,
                    Phone = supplier.Phone,
                    City = supplier.City,
                    Address = supplier.Address

                };



            }
            else
            {
                detail = new SuppliersDetailViewModel();
            }
            ViewBag.Message = "Agregar Nuevo Proveedor";
            return View(detail);
        }

        [HttpPost]
        public ActionResult AddModifySuppliers(SuppliersDetailViewModel detail)
        {
            var suppliersMap = VmToMapEntity(detail);
            bool result = false;
            if (detail.IDSupplier == 0)
            {
                result = _suppliersLogic.AddSupplier(suppliersMap);
            }
            else
            {
                result = _suppliersLogic.UpdateSupplier(suppliersMap);
            }


            return Redirect("Index");
        }

        public ActionResult DeleteSupplier(int idSupplier)
        {
            var resultado = _suppliersLogic.Delete(idSupplier);

            return Redirect("Index");

        }

       
        public Suppliers VmToMapEntity(SuppliersDetailViewModel supplier)
        {
            Suppliers suppliersEntity = new Suppliers()
            {
                SupplierID = supplier.IDSupplier,
                ContactName = supplier.ContactName,
                CompanyName = supplier.CompanyName,
                Phone = supplier.Phone,
                City = supplier.City,
                Address = supplier.Address

            };
            return suppliersEntity;

        }
    }
}