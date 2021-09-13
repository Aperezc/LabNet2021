using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaLogic.ExtensionMethods
{
    public static class MyExtensionMethods 
    {      
        
        public static decimal Dividir(this decimal divisor, decimal dividendo)
        {            
            var resultadoOperacion = dividendo/divisor;           
            return resultadoOperacion;
        }
    }
}