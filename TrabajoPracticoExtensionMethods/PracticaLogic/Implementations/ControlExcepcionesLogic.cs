using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaLogic.Contracts;

namespace PracticaLogic.Implementations

{
    public class ControlExcepcionesLogic : IControlExcepcionesLogic
    {
        public GestorDeExcepciones ManejadorDeExcepcionesCustom()
        {

            string mensaje = "este es un mensaje personalizado de mi gestor de Excepciones";
          
            GestorDeExcepciones excepcionCustom = new GestorDeExcepciones(mensaje);
            return excepcionCustom;          
            
            
        }
        public Exception ControlExcepcion()
        {
            Exception exception = new Exception();
            int valor = 7;
            try
            {
                int numero = valor / 0;
            }
            catch (Exception e)
            {
                return e;
            }


            return exception;
        }
    }
}
