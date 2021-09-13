using PracticaLogic;
using PracticaLogic.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace TrabajoPracticoExtensionMethods.Controllers
{
    

    public class HomeController : Controller
    {
        
        private ControlExcepcionesLogic _controlExcepcionesLogic = new ControlExcepcionesLogic();
        private GestorDeExcepciones _gestorDeExcepciones = new GestorDeExcepciones(string.Empty);
        
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public string DividirConCero(int dividendo)
        {
            int divisor = 0;
            int accion = 1;
            var mensaje = _gestorDeExcepciones.Dividir(divisor, dividendo, accion).ToString();
            return mensaje;
        }
        [HttpPost]
        public string Dividir(int divisor, int dividendo)
        {
            string resultado = "";
            int accion = 2;            
            resultado = _gestorDeExcepciones.Dividir(divisor, dividendo, accion);
            return resultado;
        }
        public string ControlDeExcepciones(int accion)
        {
            
            string mensaje = "";
           

            if (accion ==3)
            {
                Exception excepcion = _controlExcepcionesLogic.ControlExcepcion();
                mensaje = string.Format("Se recibio una excepcion tipo {0} con un mensaje {1}", excepcion.GetType(), excepcion.Message);
                
            }else
            {
            
                GestorDeExcepciones excepcionCustom = _controlExcepcionesLogic.ManejadorDeExcepcionesCustom();
                mensaje = excepcionCustom.Message;
            }
            
           
            return mensaje;
        }
    }
}