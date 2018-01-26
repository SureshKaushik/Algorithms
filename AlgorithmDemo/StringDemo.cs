using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class StringDemo
    {
        public static void StringConcat()
        {
            string s1 = "Suresh Kumar Kaushik";
            //Count the words from an string;

            //using function.
            string[] strArray = s1.Split(' ');
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }

            int count = 0;
            Console.WriteLine("Using code: COunt word from an string.");
            for (int i = 0; s1[i] != '\0'; i++)
            {
                if (s1[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("Total words in a string are: {0}", count);
        }

        public static void CheckStringContainsPolindrome()
        {
            string s1 = "surer";

            int first = 0;
            int last = s1.Length - 1;

            while (first < last)
            {
                for (int i = first; i < s1.Length-1; i++)
                {
                    if (s1[first] == s1[i+1])
                    {
                        last = i + 1;
                        break;
                    }
                }

                first++;
            }
        }
    }
}
