using LabDemoEF.Data;
using LabDemoEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDemoEF.Logic
{
    public class SuppliersLogic: BaseLogic
    {        
        public List<Suppliers> GetSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public bool AddSupplier(Suppliers newSupplier)
        {
            bool success = false;
            var supplierToMap = VmToMapEntity(newSupplier);
            if(newSupplier != null)
            {
                context.Suppliers.Add(supplierToMap);

                context.SaveChanges();
                success = true;
            }
            return success;


        }
        public Suppliers VmToMapEntity (Suppliers supplier)
        {
            Suppliers suppliersEntity = new Suppliers()
            {
                ContactName = supplier.ContactName,
                CompanyName = supplier.CompanyName,
                Phone = supplier.Phone,
                City = supplier.City,
                PostalCode = supplier.PostalCode,
                Address = supplier.Address,
                Fax = supplier.Fax,
                HomePage = supplier.HomePage,
                Region = supplier.Region,
                ContactTitle = supplier.ContactTitle
            };
            return suppliersEntity;

        }
    }
}
