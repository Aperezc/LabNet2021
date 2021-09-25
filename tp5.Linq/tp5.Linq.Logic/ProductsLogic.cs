using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Linq.Entities;

namespace tp5.Linq.Logic
{
    public class ProductsLogic : LogicBase
    {
        public List<Products> ProductosSinStock()
        {
            var query = context.Products.Where(p => p.UnitsInStock == 0).ToList();

            return query;
        }
        public List<Products> ProductosEnStockConPrecio()
        {
            var query = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
            return query;
        }
        public Products ProductByID(int ID)
        {
            var query = context.Products.Where(p => p.ProductID == ID).FirstOrDefault();

            return query;
        }
    }
}
