using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tp6.html.Models
{
    public class Empresa
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
    }
}