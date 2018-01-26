using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class HashtableDemo
    {
        public static void Hashtable()
        {
            Hashtable openWith = new Hashtable();
            openWith.Add("txt", "notepad.exe");
            openWith.Add("Msword", "winword.exe");
            openWith.Add("chrome", "chrome.exe");

            try
            {
                openWith.Add("txt", "notepad.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.Message);
            }
            Console.WriteLine("txt value: {0}", openWith["txt"]);

            openWith["txt"] = "edit.exe";
            Console.WriteLine("Updated txt value: {0}", openWith["txt"].GetHashCode());
            Console.WriteLine("Updated msword value: {0}", openWith["Msword"].GetHashCode());
            Console.WriteLine("Updated chrome value: {0}", openWith["chrome"].GetHashCode());
            Console.WriteLine("Open with hash code: {0}", openWith.GetHashCode());
        }
    }
}
