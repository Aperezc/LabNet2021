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
        public ActionResult TransportePublicoAgregar(int cantidadPasajeros, string tipoTransporte)
        {
              List<TransportePublico> transportePublico = new List<TransportePublico>();
              TransporteResult transporteResultado = new TransporteResult();

            var cantidadMaximaTransporte = 10;
            if (tipoTransporte == "Taxi")
            {
                
                for (int i = 0; i < cantidadMaximaTransporte/2; i++)
                {
                    var taxi = new Taxi(cantidadPasajeros, tipoTransporte);
                    taxi.NumeroUnidad = i + 1;
                    transportePublico.Add(taxi);

                }
            }
            else
            {
               
                for (int i = 0; i < cantidadMaximaTransporte / 2; i++)
                {
                    var omnibus = new Omnibus(cantidadPasajeros, tipoTransporte);
                    omnibus.NumeroUnidad = i+1;
                    transportePublico.Add(omnibus);

                }
            }

            transporteResultado.ListaTransportes = transportePublico;          


            return View("~/Views/Home/Index.cshtml", transporteResultado);
        }
    }
}