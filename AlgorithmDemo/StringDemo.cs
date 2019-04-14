using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class StringDemo
    {
        public static void StringMatchingBruteForce()
        {
            string S = "1234567890";
            string P = "1234";
            int matchIndex = 0;

            for (int i = 0; i < S.Length -P.Length + 1; i++)
            {
                bool flag = true;
                for (int j = 0; j < P.Length && flag==true; j++)
                {
                    if (S[i] != P[i+j-1])
                    {
                        flag = false;
                    }   
                }
                if (flag == true)
                {
                    matchIndex = i;   
                }
            }
            Console.WriteLine("String matching found at index: {0}", matchIndex);
        }
        private static void StringMatchingPattern(string text, string pattern)
        {
            int i = 0;
            int counter = 0;
            while (i < (text.Length - (pattern.Length - 1)))
            {
                int j = 0;
                while (j < pattern.Length)
                {
                    if (text[i] == pattern[j])
                    {
                        i++;
                        j++;
                        counter++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            if (counter == pattern.Length)
            {
                Console.WriteLine("Pattern {0} found in text {1}", pattern, text);
            }
        }

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
