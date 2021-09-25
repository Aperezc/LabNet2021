using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5.Linq.Entities;

namespace tp5.Linq.Logic
{
    public class CustomersLogic : LogicBase
    {
        public Customers Clientes()
        {   var cliente = context.Customers.FirstOrDefault();

            return cliente;
        }
        public List<Customers> ClientesRegion(string region)
        {
            var query = context.Customers.Where(c => c.Region == region).ToList();

            return query;
        }
        public List<Customers> NombresClientes()
        {
            var query = (from customer in context.Customers
                        where customer.CustomerID != null
                        select customer).ToList();            

            return query;
        }

        public List<Customers> ClientesRegionyFecha(string region, DateTime fecha)
        {
            var query = (from customer in context.Customers
                         join orders in context.Orders
                         on new {customer.CustomerID}
                         equals new { orders.CustomerID}
                         where(customer.Region == region && orders.OrderDate > fecha)
                         select(customer)).ToList();
            return query;
        }
    }
}
