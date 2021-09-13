using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLogic.Contracts
{
    public interface IControlExcepcionesLogic
    {
        GestorDeExcepciones ManejadorDeExcepcionesCustom();
        Exception ControlExcepcion();

    }
}
