using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRS_AlgoDemo
{
   
    interface ICloningService
    {
        T Clone<T>(T source);
    }

    public class ValueWrapper<T> where T : struct
    {
        public T Value { get; set; }
        public ValueWrapper(T value) { this.Value = value; }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }

    public class CloningService: ICloningService
    {
        public T Clone<T>(T source)
        {
            return (T)this.MemberwiseClone();
        }
    }

    class PersonDescription
    {
        public string firstName;
        public string lastName;
        public PersonDescription(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
    }

    class Person
    {
        public int Age;

        public PersonDescription desc;
        
        public Person(int age, string firstName, string lastName)
        {
            this.Age = age;
            desc = new PersonDescription(firstName, lastName);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person deepCopyPerson = new Person(this.Age, desc.firstName, desc.lastName);
            return deepCopyPerson;
        }
    }

    public enum CloningMode
    {
        Shallow = 0,
        Deep=1,
        Ignore=2
    }

    class Program
    {
        static void Main(string[] args)
        {            
            //PrintHello();
            //BitArrayAddition();
            
            //FIndInversionInArray();
            //GetInput();
            //LeftRotate();

            int x = 10;
            ValueWrapper<int> intVal = new ValueWrapper<int>(x);

            Person p1 = new Person(31, "Suresh", "Kaushik");
            Person shallow1 = (Person)p1.ShallowCopy();
            Person p22 = p1.DeepCopy();

            //Person p2 = p1;         //passing reference

            if (Convert.ToInt32(Console.ReadLine()) ==0)
            {

                Person shallow = (Person)p1.ShallowCopy();           //Create separate reference and assigned it. Whatever changes user makes in p2 object its not reflecting to object p1.
                shallow.desc.firstName = "Manish";

                Console.WriteLine("shallow: " + shallow.desc.firstName);
                Console.WriteLine("shallow: " + shallow.desc.firstName);
            }
            else if (Convert.ToInt32(Console.ReadLine())== 1)
            {

                Person p2 = p1.DeepCopy();
                p2.desc.firstName = "Rakesh";

                Console.WriteLine("Deep: " + p1.desc.firstName);
                Console.WriteLine("Deep: " + p2.desc.firstName);
            }
            else
            {
                Console.WriteLine("Please igonore");
            }
            Console.ReadLine();
        }
    }
}
