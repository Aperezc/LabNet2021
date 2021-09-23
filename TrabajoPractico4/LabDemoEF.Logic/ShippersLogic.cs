using LabDemoEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDemoEF.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public List<Shippers> GetShippers()
        {
            return context.Shippers.ToList();
        }
        public bool AddShipper(Shippers newShipper)
        {

            var mappinVm = VmToEntytyMapper(newShipper);
           
            bool success = false;
            if (newShipper != null)
            {
                context.Shippers.Add(mappinVm);

                context.SaveChanges();
                success = true;
            }
            return success;


        }
        public Shippers VmToEntytyMapper(Shippers vm)
        {
            Shippers shipperEntity = new Shippers()
            {
                CompanyName = vm.CompanyName,
                Phone = vm.Phone

            };
            return shipperEntity;
            

        }

    }
}
