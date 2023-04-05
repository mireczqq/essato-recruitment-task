using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersManager
{
    public class CustomersList: ICustomersList
    {
        List<Customer> customers = new List<Customer>();

        public List<Customer> Customers { get => customers; set => customers = value; }

        public CustomersList()
        {
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public void RemoveCustomer(string vatid)
        {
            if (this.Customers.FirstOrDefault(c => c.VatIdNumber == vatid) == null)
                return;

            this.Customers.Remove(this.Customers.FirstOrDefault(c => c.VatIdNumber == vatid));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Customer member in customers)
                sb.AppendLine(member.ToString());

            return sb.ToString();
        }
    }
}
