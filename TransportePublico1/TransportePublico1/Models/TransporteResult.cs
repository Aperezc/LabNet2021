using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportePublico1.Models
{
    public class TransporteResult
    {
        public TransporteResult()
        {
            this.ListaTransportes = new List<TransportePublico>();
        }      
        public List<TransportePublico> ListaTransportes { get; set; }
        public int NumeroUnidad { get; set; }
        
    }
}