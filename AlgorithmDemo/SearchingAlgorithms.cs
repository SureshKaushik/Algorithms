using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    class SearchingAlgorithms
    {
        public static void BinarySearch()
        {
            //int[] arr = { 4, 2, 3, 1, 5 };

            //SumArrayElements(arr);

            //ReverseArrayElement(arr);

            string text = "aabbccddee";
            string pattern = "ee";
            //StringMatchingPattern(text, pattern);

            Console.WriteLine("Calculate Length of an string: ");

            // 1. Loop through end of the string. and initialize the counter as 0
            // 2. increase the counter
            // 3. continue till you find '\0'

            int counter = 0;
            for (int i = 0; text[i] != '\0'; ++i)
            {
                counter++;
            }
            Console.WriteLine("String length: {0}", counter);
        }
    }
}
