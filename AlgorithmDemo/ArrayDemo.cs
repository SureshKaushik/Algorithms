using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class ArrayDemo
    {
        public static void BinarySearch()
        {
            //int[] arr = { 4, 2, 3, 1, 5 };

            //SumArrayElements(arr);

            //ReverseArrayElement(arr);

            string text = "aabbccddee";
            string pattern = "ee";
            StringMatchingPattern(text, pattern);

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

        private static void SumArrayElements(int[] arr)
        {
            int sum = 0;
            Console.WriteLine("Find the sum of the array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("sum: " + sum);
        }

        private static void ReverseArrayElement(int[] arr)
        {
            Console.WriteLine("Inverse the element of an array:");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void RotateArrayBasedonPivot()
        {
            int[] arr = { 1, 2, 3, 4 };
            int pivot = 1;
            int i = 0;
            int j = 0;
            int k  = 0;
            while (i <arr.Length)
            {        
                //Find the pivot index                
                if (arr[i] == pivot)
                {
                    // track the pivot index.
                    j = i;

                    // Continue till the end of arrray.
                    while (i < arr.Length)
	                {
	                    Console.WriteLine(arr[i] + " ");
                        i++;
	                }               
                }
                i++;

                // continue from k to end of j.
                while (k < j)
                {
                    Console.Write(arr[k] + " ");
                    k++;
                }
            }
        }

        public static void FindSumofTwoElement(int value)
        {
            int[] arr = { 1, 2, 3 };
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 0;
                while (j < arr.Length)
                {
                    if (i==j)
                    {
                        j++;
                        continue;
                    }
                    int sum = arr[i] + arr[j];

                    if(sum == value)
                    {
                        Console.WriteLine("Two value {0} and {1} = {2}", arr[i], arr[j], sum);
                        found = true;
                        break;
                    }
                    if (found)
                    {
                        continue;
                    }
                    j++;
                }
            }
            if (!found)
            {
                Console.WriteLine("Not found an value: {0} into an array.", value);
            }
        }

        public static void PolindromCheck()
        {
            string str = "madam";

            int start = 0;
            int end = str.Length;
            while(start < end)
            {
                //Console.WriteLine(str[start]);
                if (str[start] == str[end-1])
                {
                    start++;
                    end--;
                }
            }
        }

        public static void FindPolindromeFromString()
        {
            string str = "sumadam";

            // start from index = 0 and start from index = index+1 to end 
            // check whethere it contains any other character

            int start = 0;
            int end = str.Length;

            while(start < end)
            {
                for(int i= start +1 ; i< end; i++)
                {
                    if (str[start] == str[i])
                    {
                        end = i;

                        while (start < end)
                        {
                            if (str[start] == str[end])
                            {
                                start++;
                                end--;
                            } 
                        }                        
                    }
                }
                start++;
                continue;
            }
        }
        /// <summary>
        /// Find the repeated element from the group. If two elements repeated the find the min value.
        /// </summary>
        public static void FindDuplicateValueFromArray()
        {
            int[] arr = { 1, 1, 2, 3, 4, 4, 8, 8, 10, 10};
            ArrayList al = new ArrayList();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        al.Add(arr[i]);
                    }
                }
            }
            Console.WriteLine(al.Count);
        }

        /// <summary>
        /// Find the kth smallest or largest element from an unsorted/sorted array.
        /// </summary>
        public static void FindkthSmallestElement(int findElementIndex)
        {
            int[] arr = { 4,2, 3,1 };

            //Step 1: sort an array
            //step 2: find the element using goven (kth) index and return the same.

            // sort an array using bubble sort
            int i=0;
            while (i < arr.Length)
            {                
                for (int j = 0; j < arr.Length-1; j++)
                {
                    try
                    {
                        if (arr[j] > arr[j+1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j+1];
                            arr[j+1] = temp;
                        }                        
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Exception occured: {0}", e.Message);
                    } 
                }
                i++;              
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
        }
    }
}
