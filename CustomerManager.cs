using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class CustomerManager : ICustomerManager
    {

        List<Customer> customers = new List<Customer>();

        public void CustomerAdd(Customer customer)
        {
            customers.Add(customer);
        }

        public void CustomerDelete(Customer customer)
        {
            customers.Remove(customer);
        }

        public void CustomerUpdate(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }

        public void ShowCustomers()
        {
            foreach(var customer in customers)
            {
                Console.WriteLine("kullanıcılar : " + customer.FirsName);
            }
        }
    }
}
