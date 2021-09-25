using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Linq.Data;

namespace tp5.Linq.Logic
{
    public class LogicBase
    {
        protected readonly NorthWindContext context;

        public LogicBase()
        {
            context = new NorthWindContext();
        }


    }
}
