using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    /// <summary>
    /// A test object that needs to be serialized.
    /// </summary>
    [Serializable()]
    public class TestSimpleObject
    {
        public int member1;
        public string member2;
        public string member3;
        public double member4;

        // A field that is not serialized.
        [NonSerialized()]
        public string member5;

        public TestSimpleObject()
        {
            member1 = 11;
            member2 = "Suresh";
            member3 = "Kumar";
            member4 = 3.14;
            member5 = "Hello, World!";
        }

        public void Print()
        {
            Console.WriteLine("Member1: '{0}'", member1);
            Console.WriteLine("Member2: '{0}'", member2);
            Console.WriteLine("Member3: '{0}'", member3);
            Console.WriteLine("Member4: '{0}'", member4);
            Console.WriteLine("Member5: '{0}'", member5);
        }
    }
    public class SerializableAttributeDemo
    {
        public static void SerializableAttributeDemoMethod()
        {
            TestSimpleObject simpleObj = new TestSimpleObject();
            Console.WriteLine("Before serialization object contains:");
            simpleObj.Print();

            Stream stream = File.Open("data.xml", FileMode.Create);
            SoapFormatter formatter = new SoapFormatter();

            formatter.Serialize(stream, simpleObj);
            stream.Close();

            simpleObj = null;

            stream = File.Open("data.xml", FileMode.Open);
            formatter = new SoapFormatter();

            simpleObj = (TestSimpleObject)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("");
            Console.WriteLine("After deserialization the object contains:");
            simpleObj.Print();
        }
    }
}
