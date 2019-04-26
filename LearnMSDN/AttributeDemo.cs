using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// Attribute provides a powerful method of associating metadata, or declarative information, with code
    /// (Assemblies, types, methods, properties, and so forth). After an attribute is associated with a program entity,
    /// the attribute can be queried at runtime by using a technique called reflection.
    /// </summary>
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct , AllowMultiple = true)]
    public class Author: Attribute
    {
        private string name;
        public double version;

        public Author (string name)
        {
            this.name = name;
            this.version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }
    
    [Author("Suresh Kaushik")]
    public class FirstClass    { }
    public class SecondClass    { }

    [Author("Manish"), Author ("Raju", version =2.0)]
    public class ThirdClass { }

    public static class TestAuthorAttribute
    {
        public static void Test()
        {
            PrintAuthorInformation(typeof(FirstClass));
            PrintAuthorInformation(typeof(SecondClass));
            PrintAuthorInformation(typeof(ThirdClass));
        }

        private static void PrintAuthorInformation(Type type)
        {
            Console.WriteLine("Author information for {0}", type);

            // using reflection 
            Attribute[] attrs = Attribute.GetCustomAttributes(type);

            foreach (var attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
}
