using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaLogic.ExtensionMethods;

namespace PracticaLogic
{
    public class GestorDeExcepciones : Exception
    {
        public GestorDeExcepciones(string mensaje) : base(mensaje)
        {
           
        }
        

        public string Dividir(decimal divisor, decimal dividendo, int accion)
        {
            var mensaje = "";
            decimal resultadoOperacion = 0;
            try
            {
                resultadoOperacion = divisor.Dividir(dividendo);
                mensaje = string.Format("El resultado de la División es: {0}", resultadoOperacion);

            }catch (Exception e)
            {
                if(accion ==1 )
                {
                    mensaje = string.Format("Se recibió una excepcion {0}", e.Message);
                }
                else
                {
                    mensaje = string.Format("Un pueblo Ignorante es un Instrumento Ciego de Su propia Destruccion, no puedes dividir un numero entre 0. El mensaje de la excepcion es: {0}", e.Message);
                }
                
            }
            return mensaje;

        }
        
        
    }
}
