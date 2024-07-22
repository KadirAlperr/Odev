using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal interface ICustomerManager
    {
        void CustomerAdd(Customer customer);
        void CustomerUpdate(Customer customer);
        void CustomerDelete(Customer customer);
        void ShowCustomers();

        

    }
}
