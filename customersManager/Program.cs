using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersList customersList = new CustomersList();
            customersList.AddCustomer(new Customer("PL111222333", "01-01-2023", "Jan", "Kowalski", "Krakow", 22300, "Dobra", Male.Male));
            customersList.AddCustomer(new Customer("PL000000000", "02-02-2023", "Adam", "Nowak", "Krakow", 22300, "Droga", Male.Other));

            Console.WriteLine(customersList);
            Console.ReadKey();
        }
    }
}
