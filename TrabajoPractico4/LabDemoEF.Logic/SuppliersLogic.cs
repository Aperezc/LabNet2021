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

        public bool AddSupplier(Suppliers newSuplier)
        {
            bool success = false;
            if(newSuplier != null)
            {
                context.Suppliers.Add(newSuplier);

                context.SaveChanges();
                success = true;
            }
            return success;


        }
    }
}
