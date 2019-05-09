using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
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

    public static class StaticClassDemo
    {
        public static void StaticClassDemoMethod()
        {
            Bus bus1 = new Bus(71);
            Bus bus2 = new Bus(72);

            bus1.Drive();

            System.Threading.Thread.Sleep(25);

            bus2.Drive();            
        }
    }
}
