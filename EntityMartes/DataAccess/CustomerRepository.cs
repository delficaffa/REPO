using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerRepository
    {
        public static void Agregar(Customers c)
        {
            using (var context = new PruebaNumberOneEntities())
            {
                context.Customers.Add(c);
                context.SaveChanges();
            }
            
        }

        public static void Eliminar(Customers c)
        {
            using (var context = new PruebaNumberOneEntities())
            {
                context.Customers.Remove(c);
                context.SaveChanges();
            }

        }

     
    }
}
