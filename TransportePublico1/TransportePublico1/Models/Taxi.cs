using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportePublico1.Models
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros,  string tipoTransporte): base(cantidadPasajeros, tipoTransporte)
        {

        }
        public override string Avanzar(int cantidadPasajeros)
        {
            throw new NotImplementedException();
        }

        public override string Detenerse(int cantidadPasajeros)
        {
            throw new NotImplementedException();
        }
    }
}