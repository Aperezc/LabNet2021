using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using LabDemoEF.Entities;

namespace LabDemoEF.UI.Models.Suppliers
{
    public class SuppliersFilter
    {
        public int? IDSupplier { get; set; }
        public List<SelectListItem> SuppliersNames { get; set; }
        [Display(Name ="Nombre de Contacto")]
        public string ContactName { get; set; }
    }
   
}