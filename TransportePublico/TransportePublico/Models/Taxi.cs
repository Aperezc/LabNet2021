using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportePublico.Models
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {

        }
        public override string Avanzar()
        {
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}