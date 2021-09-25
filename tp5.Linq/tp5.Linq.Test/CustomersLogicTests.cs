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
    public class CustomersLogicTests
    {
        private CustomersLogic clienteLogic = new CustomersLogic();
        [TestMethod()]
        public void ClientesTest()
        {

            var cliente = clienteLogic.Clientes();

            Assert.IsNotNull(cliente);
        }

        [TestMethod()]
        public void ClientesRegionTest()
        {
            string region = "WA";
            var clienteRegion = clienteLogic.ClientesRegion(region);

            Assert.IsNotNull(clienteRegion);
        }

        [TestMethod()]
        public void NombresClientesTest()
        {
            var clientes = clienteLogic.NombresClientes();

            Assert.IsNotNull(clientes);
        }

        [TestMethod()]
        public void ClientesRegionyFechaTest()
        {
            string region = "WA";
            DateTime fecha = DateTime.Parse("1997-1-1");
            var clienteRegion = clienteLogic.ClientesRegionyFecha(region, fecha);
            Assert.IsNotNull(clienteRegion);
        }
    }
}