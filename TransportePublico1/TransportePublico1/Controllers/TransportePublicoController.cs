using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportePublico1.Models;

namespace TransportePublico1.Controllers
{
    
    public class TransportePublicoController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult TransportePublicoAgregar(int cantidadPasajeros, string tipoTransporte, int ultimoRegistro)
        {
            List<TransportePublico> transportePublico = new List<TransportePublico>();                 
           
            if (tipoTransporte == "Taxi")
            {
                var taxi = new Taxi(cantidadPasajeros, tipoTransporte);
                taxi.NumeroUnidad = ultimoRegistro+1;
                transportePublico.Add(taxi);               
               
            }
            else
            {
                var omnibus = new Omnibus(cantidadPasajeros, tipoTransporte);
                omnibus.NumeroUnidad=ultimoRegistro + 1;
                transportePublico.Add(omnibus);                
            }
            
            return Json(transportePublico, JsonRequestBehavior.AllowGet);
            
        }
    }
}