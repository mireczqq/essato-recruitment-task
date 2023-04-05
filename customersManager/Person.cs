using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersManager
{
    public enum Male { Female, Male, Other }
    public abstract class Person
    {
        private string name;
        private string surName;
        private string city;
        private string street;
        private int postCode;
        private Male male;


        public Male Male { get => male; set => male = value; }
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int PostCode { get => postCode; set => postCode = value; }

        public Person(string name, string surName, string city, int postCode, string street, Male male)
        {
            this.Name = name;
            this.SurName = surName;
            this.City = city;
            this.PostCode = postCode;
            this.Street = street;
            this.Male = male;
        }
        public string ConnectAdress()
        {
            return $"ul.{Street}, {PostCode.ToString("##-###")} {City}";
        }

        public override string ToString()
        {
            return $@"{Name} {SurName} ({Male}), {this.ConnectAdress()}";
        }

    }
}
