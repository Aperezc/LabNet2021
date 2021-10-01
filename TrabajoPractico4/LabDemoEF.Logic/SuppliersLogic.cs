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
            
            if(newSupplier != null)
            {
                context.Suppliers.Add(newSupplier);

                context.SaveChanges();
                success = true;
            }
            return success;


        }
        public bool UpdateSupplier(Suppliers supplier)
        {
            var supplierUpdate = context.Suppliers.Find(supplier.SupplierID);
                       

            bool succes = false;
            if (supplier != null)
            {
                supplierUpdate.ContactName = supplier.ContactName;
                supplierUpdate.CompanyName = supplier.CompanyName;
                supplierUpdate.City = supplier.City;
                supplierUpdate.Country = supplier.Country;
                supplierUpdate.Phone = supplier.Phone;
                supplierUpdate.Address = supplier.Address;

                context.SaveChanges();
                succes = true;


            }
            return succes;

        }
        public bool Delete(int id)
        {
            var supplier = context.Suppliers.Find(id);
            bool success = false;
            try
            {
                context.Suppliers.Remove(supplier);
                success = true;
                context.SaveChanges();
            }
            catch(Exception e)
            {
                success = false;
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
                Address = supplier.Address
                
            };
            return suppliersEntity;

        }
    }
}
