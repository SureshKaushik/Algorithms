using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class IdInfo
    {
        public int IdNumber;
        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other =(Person) this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = string.Copy(Name);
            return other;
        }
    }
    static class ShallowAndDeepCopyExample
    {
        public static void ShallowAndDeep()
        {
            // create an instance of Person and assign values to its fields.
            Person p1 = new Person();
            p1.Age = 20;
            p1.Name = "Suresh";
            p1.IdInfo = new IdInfo(1000);

            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2: ");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p2);

            // Change the value of p1 properties ad sipaly the values of p1 and p2.
            p1.Age = 30;
            p1.Name = "Ramesh";
            p1.IdInfo.IdNumber = 2000;

            Console.WriteLine(" Values of p1 and p2 after changes to p1: ");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();

            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "Tarun";
            p1.Age = 18;
            p1.IdInfo.IdNumber = 3000;

            Console.WriteLine(" Values of p1 and p3 after changes to p1: ");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p3);
        }

        private static void DisplayValues(Person p)
        {
            Console.WriteLine(" Name: {0}, Age: {1}", p.Name, p.Age);
            Console.WriteLine(" Values: {0}", p.IdInfo.IdNumber);
        }
    }
}
