using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabDemoEF.UI.Models.Suppliers
{
    public class SuppliersDetailViewModel 
    {
        public int IDSupplier { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public List<SelectListItem> ListaFiltro { get; set; }

    }
}