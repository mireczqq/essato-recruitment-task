using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersManager
{
    public interface ICustomersList
    {
        void AddCustomer(Customer customer);
        void RemoveCustomer(string vatid);

    }
}
