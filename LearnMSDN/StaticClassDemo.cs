using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    #region Private Constructor
    public class PrivateConstructor
    {
        /// <summary>
        /// It is a special instance constructor.
        /// It is generally used in classes that contain static members only.
        /// If a class has one or more private constructor and no public constructors, other classes (except nested classes) cannot create instance of this class.
        /// If you do not use an access modifier with the constructor it will still be private by default.
        /// private modifier is usuallyu used explicitly to make it clear that the class cannot be instantiated.
        /// It is used to prevent creating instances of a class when there are no instance fields or methods (Eg. Math class).
        /// </summary>
        private PrivateConstructor() {  }

        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
        //public static double e = Math.E;
    }

    public static class PrivateConstructorDemo
    {
        public static void CallPrivateConstructor()
        {
            // private modifier is usuallyu used explicitly to make it clear that the class cannot be instantiated.
            // Notice that if you uncomment the following statement from the example, it will generate an error because the constructor is inaccessible because of its protection level.
            //PrivateConstructor cons = new PrivateConstructor();       // throwing erro
            PrivateConstructor.currentCount = 100;
            PrivateConstructor.IncrementCount();
            Console.WriteLine("New count: {0}", PrivateConstructor.currentCount);
        }
    }

    #endregion

    #region static constructor

    public class Bus
    {
        // Static variable used by all Bus instances.
        // Represents the time the first bus of the day starts its route.
        protected static readonly DateTime  globalStartTime;

        // Property for the nuber of each bus.
        protected int RouteNumber { get; set; }

        /// <summary>
        /// static constructor is used to initialise any static data, or to perform apartifular action that needs to be performed once only.
        /// It is callsed automatically before the first instance is created or any static mebers are referenced.
        /// Properties: it does not take access modifiers or have parameters.
        /// </summary>
        static Bus()
        {
            globalStartTime = DateTime.Now;
            // line occurs only once.
            Console.WriteLine("Static constructor sets global start time to {0}", globalStartTime.ToLongTimeString());
        }

        // Instance constructor.
        public Bus(int routeNum)
        {
            RouteNumber = routeNum;
            Console.WriteLine("Bus #{0} is created.", RouteNumber);
        }

        // Instance method.
        public void Drive()
        {
            TimeSpan elapsedTime = DateTime.Now - globalStartTime;

            Console.WriteLine("{0} is strarting its route {1:N2} minutes after global start time {2}", this.RouteNumber, elapsedTime.Milliseconds, globalStartTime.ToShortTimeString());
        }
    }

    public static class StaticConstructorDemo
    {
        public static void StaticConstructorDemoMethod()
        {
            Bus bus1 = new Bus(71);
            Bus bus2 = new Bus(72);

            bus1.Drive();

            System.Threading.Thread.Sleep(25);

            bus2.Drive();            
        }
    }
    #endregion 

    #region Copy Constructor

    /// <summary>
    /// C# doesn't provie a copy constructor for objects, but you can write one yourself.
    /// Person class defines a copy constructor that takes, as its argument, an instance of Person.
    /// The values of the properties of the argument are assigned to the properties of the new instance of Person.
    /// The code contains an alternative copy constructor that sends the Name and Age properties of the instance that you want to copy to the instance constructor of the class.
    /// </summary>
    class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }
        public Person(Person previousPerson)
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Details()
        {
            return Name + " is " + Age.ToString();
        }
    }

    class TestPerson
    {
        public static void CopyConstructorDemo()
        {
            Person person1 = new Person("Suresh", 30);

            Person person2 = new Person(person1);
            person1.Age = 31;
            person2.Age = 35;

            person2.Name = "Manish";

            Console.WriteLine(person1.Details());
            Console.WriteLine(person2.Details());
        }
    }
    #endregion

    #region static class

    /// <summary>
    /// A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. 
    /// In other words, you cannot us the new keyword to crate a variable of the class type.
    /// Because there is no intance variable, you access the members of a static class by using the class name itselt.
    /// A static class can be used as a convenient container for sets of methods that just operate on input parameters and do not have to get or set any internal instance fields. Eg. Math class
    /// Contains only static members.
    /// Cannot be instantiated.
    /// Is sealed
    /// Cannot contain Instance Constructors.
    /// </summary>
    public static class TemperatureConverter
    {
        public static double CensiusToFahrenheit(string temperatureCensius)
        {
            double celsius = Double.Parse(temperatureCensius);
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double fahrenheit = Double.Parse(temperatureFahrenheit);
            double cencius = (fahrenheit - 32) * 5 / 9;
            return cencius;
        }
    }

    class TestTemperatureConverter
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celcius.");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.WriteLine("Please enter the Celcius temperature:");
                    F = TemperatureConverter.CensiusToFahrenheit(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;
                case "2":
                    Console.WriteLine("Please enter the Fahrenheit temperature:");
                    C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
        }
    }
    #endregion 
}
