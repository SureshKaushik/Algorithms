using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// Simple business object.
    /// </summary>
    public class PersonE
    {
        public PersonE(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public string firstName;
        public string lastName;
    }

    /// <summary>
    /// Collection of Person objects. This class
    /// implments IEnumrable so that it can be used 
    /// with ForEach sytax.
    /// </summary>
    public class People:IEnumerable
    {
        private PersonE[] _people;

        public People(PersonE[] pArray)
        {
            _people = new PersonE[pArray.Length];
            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        //Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    /// <summary>
    /// When you implement IEnumerable, you must also implement IEnumerator.
    /// IEnumerator: provides the ability to iterate through the collection by exposing a Current property and MoveNext and Reset methods.
    /// </summary>
    public class PeopleEnum : IEnumerator
    {
        public PersonE[] _people;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum (PersonE[] list)
        {
            _people = list;
        }

        object IEnumerator.Current
        {
            get 
            {
                return Current;
            }
        }

        public PersonE Current {     
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }

    /// <summary>
    /// Exposes an enumerator, which supports a simple iteration over a non-generic collection.
    /// Need to implement IEnumerable and IEnumerator interface.
    /// </summary>
    public class IEnumerableDemo
    {
        public static void IEnumerableDemoMethod()
        {
            PersonE[] peopleArray = new PersonE[3]
            {
                new PersonE("Suresh", "Kumar"),
                new PersonE("Kunj", "Bihari"),
                new PersonE("Dharmesh", "Kaushik")
            };

            People peopleList = new People(peopleArray);
            foreach (var people in peopleList)
            {
                Console.WriteLine(people.firstName + " " + people.lastName);
            }
        }
    }
}
