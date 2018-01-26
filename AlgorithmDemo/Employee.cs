using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class Employee
    {
        public string Name { get; set; }
        public AddressInfo Address { get; set; }
        public InsuranceInfo Insurance { get; set; }
        public string Salary { get; set; }

        public Employee(string name, string street, string city, string state, string postalCode) : this(name, street, city, state, postalCode,"50000")
        {
        }

        public Employee(string name, string street, string city, string state, string postalCode, string salary)
        {
            Name = name;
            Salary = salary;
            Address = new AddressInfo()
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = postalCode
            };
        }

        public override string ToString()
        {
            string val = Name + " " + Address.Street + " " + Address.City + " " + Address.State
                + " " + Address.PostalCode;

            if(Insurance != null)
            {
                val += Insurance.Name + " " + Insurance.ID;
            }
            return val;
        }

        public virtual string DoWork()
        {
            return "Employee is doing workk!";
        }

        public virtual string DoWork(string workType)
        {
            return " Doing: " + workType;
        }
    }
}
