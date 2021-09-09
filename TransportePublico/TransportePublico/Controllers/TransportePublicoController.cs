using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransportePublico.Models;
namespace TransportePublico.Controllers
{
    public class TransportePublicoController : Controller
    {
        // GET: TransportePublico
        public ActionResult Index()
        {
                       
            return View();

        }
        [HttpPost]
        public ActionResult AgregarTransporte(int cantidadPasajeros)
        {

            return null;
        }
    }
}