using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Servicios
{
    public class Consultas
    {
        private Repository<Customers> _customerRepository;

        public Consultas()
        {
            _customerRepository = new Repository<Customers>();
        }

        public void Agregar(ClienteDTO cliente)
        {
            var nuevoCliente = new Customers();

            nuevoCliente.CompanyName = cliente.CompanyName;
            nuevoCliente.ContactName = cliente.ContactName;
            nuevoCliente.City = cliente.City;
            nuevoCliente.ContactTitle = cliente.ContactTitle;
            nuevoCliente.CustomerID = cliente.CustomerID;

            _customerRepository.Persist(nuevoCliente);
            _customerRepository.SaveChanges();

        }
    }

    public static void Eliminar(string id)
    {
        using (var context = new PruebaNumberOneEntities())
        {
            try
            {

                var cliente = context.Customers.Where(c => c.CustomerID == id).First();

                context.Customers.Remove(cliente);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No existe el cliente con ese id");
            }

        }
    }

    public static void Buscar(string id)
    {
        using (var context = new PruebaNumberOneEntities())
        {
            try
            {
                var cliente = context.Customers.Where(c => c.CustomerID == id).First();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("No existe el cliente con ese id");
            }

        }
    }
    public static void Modificar(ClienteDTO nuevo)
    {
        using (var context = new PruebaNumberOneEntities())
        {
            var editCliente = new Customers();

            editCliente.CompanyName = cliente.CompanyName;
            editCliente.ContactName = cliente.ContactName;
            editCliente.City = cliente.City;
            editCliente.ContactTitle = cliente.ContactTitle;
            editCliente.CustomerID = cliente.CustomerID;

            context.Customers.Add(editCliente);
            context.SaveChanges();
        }
    }
}
