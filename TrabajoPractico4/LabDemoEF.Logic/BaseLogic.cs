using LabDemoEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDemoEF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthWindContexto context;

        public BaseLogic()
        {
            context = new NorthWindContexto();
        }

    }
}
