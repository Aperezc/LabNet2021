using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tp6.html.Models
{
    public class Persona
    {
        [Display(Name ="Nombre")]
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        [Required]
        public string Apellido { get; set; }
        [Display(Name = "Número de Documento")]
        [Required]
        public string Dni { get; set; }
        public Empresa Empresa { get; set; }
    }
}