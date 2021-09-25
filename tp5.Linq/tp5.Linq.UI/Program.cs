using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Linq.Logic;

namespace tp5.Linq.UI
{
    class Program
    {

        static void Main(string[] args)
        {
            CustomersLogic _clientes = new CustomersLogic();
            ProductsLogic _productos = new ProductsLogic();

            var cliente = _clientes.Clientes();
            Console.WriteLine("Los nombres de los Clientes en Mayuscula Son:");
            foreach (var customer in _clientes.NombresClientes())
            {
                Console.WriteLine(customer.ContactName.ToUpper());

            }
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Los nombres de los Clientes en Minuscula Son:");
            foreach (var customer in _clientes.NombresClientes())
            {
                Console.WriteLine(customer.ContactName.ToLower());

            }
           

            Console.ReadLine();




        }
    }
}
