using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LabDemoEF.UI.Models.Suppliers
{
    public class SuppliersViewModel : SuppliersDetailViewModel
    {
        
        public List<SelectListItem> SuppliersFilter { get; set; }
        public List<SuppliersDetailViewModel> Suppliers { get; set; }
        
        



  
    }
}