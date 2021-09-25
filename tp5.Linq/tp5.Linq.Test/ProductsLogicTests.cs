using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp5.Linq.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5.Linq.Logic.Tests
{
    [TestClass()]
    public class ProductsLogicTests
    {
        private ProductsLogic _productos = new ProductsLogic();
        [TestMethod()]
        public void ProductosSinStockTest()
        {

            Assert.IsNotNull(_productos.ProductosSinStock());
        }

        [TestMethod()]
        public void ProductosEnStockConPrecioTest()
        {

            Assert.IsNotNull(_productos.ProductosEnStockConPrecio());
        }

        [TestMethod()]
        public void ProductByIDTest()
        {
            int id = 789;
            var producto = _productos.ProductByID(id);
            Assert.IsNull(producto);
        }
    }
}