using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportePublico1.Models
{
    public abstract class TransportePublico
    {
        public TransportePublico(int cantidadPasajeros, string tipoTransporte)
        {
            this.CantidadPasajeros = cantidadPasajeros;
            this.TipoTransporte = tipoTransporte;
          
        }
        public int NumeroUnidad { get; set; }
        public int CantidadPasajeros { get; set; }
        public string TipoTransporte { get; set; }
      

        public abstract string Avanzar(int cantidadPasajeros);
        public abstract string Detenerse(int cantidadPasajeros);
        

    }
}