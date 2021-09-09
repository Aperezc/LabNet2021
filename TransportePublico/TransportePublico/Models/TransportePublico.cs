using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportePublico.Models
{
    public abstract class TransportePublico
    {
        public TransportePublico(int cantidadPasajeros)
        {
            this.CantidadPasajeros = cantidadPasajeros;
        }
        public int CantidadPasajeros { get; set; }
        public List<TipoTransportePublico> TipoTransportePublico { get; set; }

        public abstract string Avanzar();
        public abstract string Detenerse();

       
    }
}