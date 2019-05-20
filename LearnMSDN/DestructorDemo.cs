using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// Finanlizeres (Destructors) are used to perform any necessary final clean-up 
    /// when a class instance is veing collected by the farbage collector.
    /// </summary>    
    class Car
    {
        /// <summary>
        /// A class can only have one finalizer
        /// Finalizers cannot be inherited or overloaded.
        /// Finalizers cannot be called. They are invoked automatically.
        /// A finalizer does not take modifiers or have parameters.
        /// </summary>
        ~Car()          // finalizer
        { // cleanup statements...
        }

        // The finalizer implicitly calls Finalize on the base class of the object. Therefor, a call to a finalizer is implicitly translated to the following code:

        //protected override void Finalize()
        //{
        //    try
        //    {
        //        // cleanup statements...
        //    }
        //    finally
        //    {
        //        base.Finalize();
        //    }
        //}
    }

    class First
    {
        ~First()
        {
            System.Diagnostics.Trace.WriteLine("First's desctructor is called.");
        }
    }

    class Second: First
    {
        ~Second()
        {
            System.Diagnostics.Trace.WriteLine("Second's destrucotr is called.");
        }
    }

    class Third : Second
    {
        ~Third()
        {
            System.Diagnostics.Trace.WriteLine("Third's destructor is called.");            
        }
    }
    public class DestructorDemo
    {
        public static void DestructorDemoMethod()
        {
            Third t = new Third();
        }
    }
}
