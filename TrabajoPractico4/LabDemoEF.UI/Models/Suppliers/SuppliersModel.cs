using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LabDemoEF.UI.Models.Suppliers
{
    public class SuppliersModel : LabDemoEF.Entities.Suppliers
    {
        
        public List<SelectListItem> SuppliersFilter { get; set; }
        public List<LabDemoEF.Entities.Suppliers> Suppliers { get; set; }
        
        



  
    }
}