using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// If you want to create and manager groups of related objects. There are two ways to group objects: 
    /// 1. By creating arrays of objects
    /// 2. By creating collections of objects.
    /// Array: Most useful for creating and working with a fixed number of strongly-types objects.
    /// Collections: Provides a more flexivle way to work with froups of objects. 
    /// A collection is class, so you must declare an instance of the class before you can add elements to that collection.
    /// If your collection contains elements of only one data type, you can use one of the classes in System.Collections.Generic namespace
    /// Generic Collection: enforces typ sa
    /// </summary>
    public class CollectionsDemo
    {
        public static void SimpleCollection()
        {
            // create a list of strings.
            var persons = new List<string>();
            persons.Add("Suresh");
            persons.Add("Manish");
            persons.Add("Raju");

            // Iterate through the list.
            foreach(var person in persons)
            {
                Console.WriteLine("Name: {0}", person);
            }
        }

       public static void CollectionInitiazer()
       {
            // create a list of strings by using a 
            // collection initializer.
           var persons = new List<string> { "Manish", "Suresh", "Narendra" };

            // Iterate through the list using foreach
           foreach (var person in persons)
           {
               Console.WriteLine("Person Name: {0}", person);
           }

            // Iterarate through the list using for loop
           for (int index = 0; index < persons.Count; index++)
           {
               Console.WriteLine("Person Name: {0}", persons[index]);
           }
       }

       public static void CollectionOperations()
       {
           #region Remove
           // Create a list of strings by using a collection initializer.
           var persons = new List<string> { "Ashish", "Manish", "Ritesh" };

            // Remove an element from the list by specifying the object.
           persons.Remove("Manish");
            
            // Iterate through the list.
           foreach (var person in persons)
           {
               Console.Write(person + " ");
           }
           #endregion 

           #region RemoveAt
            // Removes elements from a generic list. Instead of a foreach statement, a for statement that iterates in descending order is used. 
            // This is because the RemoveAt method causes elements after a removed element to have a lower index value.

           var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10 };
            //Remove odd numbers
           for (int index = numbers.Count-1; index >=0; index--)
           {               
               if (numbers[index] % 2 != 0)
               {
                   // Remove the element by specifying
                   // the zero-based index in the list.
                   numbers.RemoveAt(index);
               }
           }

            // Iterate through the list.
            // A lambda expression is placed in the ForEach method of the List<T> object.
           numbers.ForEach(number => Console.Write(number + " "));
           #endregion 
       }

        /// <summary>
        /// For the type os elements in the List<T>, you can also define your own class.        
        /// </summary>
        public static void IterateThroughList()
       {
           var theGalaxies = new List<Galaxy>
           {
               new Galaxy(){Name="A", MegaLightYears = 400},
               new Galaxy() {Name = "B", MegaLightYears=25},
               new Galaxy() {Name="C", MegaLightYears=0},
               new Galaxy(){Name = "D", MegaLightYears=3}
           };

            foreach(Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears);
            }
       }

        #region Kinds of Collections
        // 1. System.Collections.Generics classes=> Dictionary<T>, List<T>, Queue<T>, SortedList<T>, Stack<T>
        // 2. System.Collections.Consurrent classes => .Net 4 or newer., the collections provide a efficient 
        // thread-safe operations for accessing collection items from multiple threads. E.g. BlockingCollection<T>, 
        // ConcurrentBag<T>, ConcurrentDictionary<T>, ConcurrentQueue<T>, 
        // ConcurrrentStack<T>, OrderablePartioner<TSource>, Partitioner, Partitioner<TSource>
        // It should be used in place of the corresponding types in the System.Collections and System.Collections.Generic  
        // whenever multiple threads are accessing the collection
        // 3. System.Collections classes
        // It don not stoer elements as specifically types objects, but as objects of type Object.
        // Whenever possible, you should use the generic collections or collections.concurrent instead of the legacy types in the System.Collections
        // E.g. ArrayList, HashTable, Queue, Stack

        private static void IterateThroughDictionary()
        {
            //The Dictionary<T, T> generic collection  enables you to access to elements in a collection by using 
            // the key of each element. Each addition to the dictiona ry consists of a value and its associated key.
            // Retrieving a value by using its key is fast because the Dictionary class is implemented as hash table
            Dictionary<string, Element> elements = BuildDictionary();

            // To instead use a collection initializer to build the Dictionary collection, you can replace the BuildDictionary and AddToDictionary 
            // methods with the following method.

            Dictionary<string, Element> elements2 = BuildDictionary2();

            foreach (KeyValuePair<string, Element> kvp in elements)
            {
                Element theElement = kvp.Value;

                Console.WriteLine("key: {0}", kvp.Key);
                Console.WriteLine("values: " + theElement.Symbol + " " + theElement.Name + " " + theElement.AtomicNumber);
            }
        }

        private static Dictionary<string, Element> BuildDictionary2()
        {
            return new Dictionary<string, Element>
            {
                {"K", new Element{Symbol = "K", Name="Potassium", AtomicNumber=19}},
                {"Ca", new Element{Symbol="Ca", Name="Calcium", AtomicNumber=20}},
                {"Sc", new Element{Symbol="Sc", Name="Scandium", AtomicNumber=21}},
                {"Ti", new Element{Symbol="Ti", Name="Titanium"}}
        }

        private static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();
            AddToDictionary(elements, "K", "Potassium", 19);
            AddToDictionary(elements, "Ca", "Calcium", 20);
            AddToDictionary(elements, "Sc", "Scandium", 21);
            AddToDictionary(elements, "Ti", "Titanium", 22);

            return elements;
        }

        private static void AddToDictionary(Dictionary<string, Element> elements, string sysmbol, string name, int atomicNumber)
        {
            Element theElement = new Element();
            theElement.Symbol = sysmbol;
            theElement.Name = name;
            theElement.AtomicNumber = atomicNumber;

            elements.Add(key:theElement.Symbol, value: theElement);
        }
        #endregion 
    }
    class Element
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int AtomicNumber { get; set; }
    }

    class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }
}
