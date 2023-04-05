using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace customersManager
{
    public class Customer : Person
    {
        string vatIdNumber;
        DateTime creationDate;

        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public string VatIdNumber
        {
            get => vatIdNumber;
            set
            {
                Regex regex = new Regex("^[A-Za-z]{2}\\d{9}$");
                if (regex.IsMatch(value))
                {
                    vatIdNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid VAT ID number format.");
                }
            }
        }

        public Customer(string vatIdNumber, string creationDate, string name, string surName, string city, int postCode, string street, Male male):
            base(name,surName,city, postCode, street, male)
        {
            this.VatIdNumber = vatIdNumber;
            DateTime date;
            DateTime.TryParseExact(creationDate, new[] { "yyyy-MMM-dd", "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy", "dd.MM.yyyy" }, null, DateTimeStyles.None, out date);
            this.CreationDate = date;
        }


    }
}
