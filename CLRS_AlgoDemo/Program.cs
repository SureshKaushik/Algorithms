using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRS_AlgoDemo
{
    interface ICloningService
    {
        T Clone<T>(T source);
    }

    public class CloningService: ICloningService
    {
        public T Clone<T>(T source)
        {
            return (T)this.MemberwiseClone();
        }
    }

    class PersonDescription
    {
        public string firstName;
        public string lastName;
        public PersonDescription(string f, string l)
        {
            firstName = f;
            lastName = l;
        }
    }

    class Person
    {
        public int Age;

        public PersonDescription desc;
        
        public Person(int age, string firstName, string lastName)
        {
            this.Age = age;
            desc = new PersonDescription(firstName, lastName);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person deepCopyPerson = new Person(this.Age, desc.firstName, desc.lastName);
            return deepCopyPerson;
        }
    }

    public enum CloningMode
    {
        Shallow = 0,
        Deep=1,
        Ignore=2
    }

    class Program
    {
        static void Main(string[] args)
        {            
            //PrintHello();
            //InsertionSort();
            //BitArrayAddition();
            //SelectionSort();
            //MedianSort();
            //MergeSort();
            //FIndInversionInArray();
            //GetInput();
            //LeftRotate();

            Person p1 = new Person(31, "Suresh", "Kaushik");
            //Person p2 = p1;         //passing reference

            if (Convert.ToInt32(Console.ReadLine()) ==0)
            {

                Person shallow = (Person)p1.ShallowCopy();           //Create separate reference and assigned it. Whatever changes user makes in p2 object its not reflecting to object p1.
                shallow.desc.firstName = "Manish";

                Console.WriteLine("shallow: " + shallow.desc.firstName);
                Console.WriteLine("shallow: " + shallow.desc.firstName);
            }
            else if (Convert.ToInt32(Console.ReadLine())== 1)
            {

                Person p2 = p1.DeepCopy();
                p2.desc.firstName = "Rakesh";

                Console.WriteLine("Deep: " + p1.desc.firstName);
                Console.WriteLine("Deep: " + p2.desc.firstName);
            }
            else
            {
                Console.WriteLine("Please igonore");
            }
            Console.ReadLine();
        }

        private static void LeftRotate()
        {
            int k = 2;
            int j;
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int temp=0;
            for (int i = 0; i < a.Length; i++)
            {
                if (k > 0)
                {
                    temp = a[i];
                    k--;
                }
                j = i + 1;
                if(j <= a.Length-1)
                    a[i] = a[j];

                if (j==a.Length)
                {
                    a[i] = temp;
                    k++;
                }

            }
        }

        private static void GetInput()
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int i2;
            double d2;
            string s2;
            // Declare second integer, double, and String variables.

            i2 = Convert.ToInt16(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
            s2 = Console.ReadLine();
            // Read and save an integer, double, and String to your variables.
            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

            double d3 = d + d2;

            Console.WriteLine(i + i2);
            Console.WriteLine(d3);
            Console.WriteLine(s + s2);   
        }

        private static void FIndInversionInArray()
        {
            int[] Arr = { 2, 3, 8, 6, 1 };

            for(int i=0; i<Arr.Length; i++)
            {
                int j = 0;
                while (j<Arr.Length)
                {
                    if (i == j)
                    {
                        j++;
                        continue;
                    }

                    if (i<j)
                    {
                        if(Arr[i] > Arr[j])
                        {
                            Console.WriteLine("i: {0}, j:{1}", Arr[i], Arr[j]);
                        }
                    }
                    j++;
                }
            }
        }

        private static void MergeSort()
        {
            int[] A = { 2, 4, 5, 7, 1, 2, 3, 6 };

            int p = 1;
            int q = (p + A.Length) / 2;
            int r = A.Length;

            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] R = new int[n2];            

            for (int i = 0; i < n1; i++)
            {
                // Create left array;
                L[i] = A[p+i-1];
            }

            for (int j = 0; j < n2; j++)
            {
                // Create right array
                R[j] = A[q + j];
            }

            for (int i = 0; i < L.Length; i++)
            {
                Console.Write(L[i] + " ");
            }
            Console.WriteLine("---------------------");
            for (int i = 0; i < L.Length; i++)
            {
                Console.Write(R[i] + " ");
            }

            int i1 = 0;
            int j1 = 0;
            for (int k = p-1; k < r; k++)
            {
                if (L[i1] < R[j1])
                {
                    A[k] = L[i1];
                    i1++;
                }
                else
                {
                    A[k] = L[j1];
                    j1 = j1 + 1;
                }
            }

            for (int i = 0; i < r; i++)
            {
                Console.Write(A[i] + " ");   
            }
        }

        private static void MedianSort()
        {
            int[] Array1 = { 2, 4, 5, 1, 3 };

            // find median index

            int left = 0, right = Array1.Length - 1;
            int mid = (left + right) / 2;

            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[mid] < Array1[i])
                {

                }
            }
        }

        private static void SelectionSort()
        {
            int[] Array1 = {4, 5,6 ,6, 6, 10, 10, 2, 1};

            for (int i = 0; i < Array1.Length; i++)
            {
                int min = i;
                int j = i + 1;
                while (j < Array1.Length)
                {
                    if (Array1[j] < Array1[min])
                    {
                        min = j;
                    }
                    j++;
                }
                int small = Array1[min];
                
                Array1[min] = Array1[i];
                Array1[i] = small;
                
            }
            for (int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine(Array1[i]);    
            }            
        }

        private static void BitArrayAddition()
        {
            int[] A = { 1, 2, 3, 4 };
            int[] B = { 2, 3, 4, 6 };
            int[] C = new int[A.Length];

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            for (int j = 0; j < C.Length; j++ )
            {
                Console.WriteLine(C[j]);
            }

            Console.WriteLine("----------------------------------");

            string[] C1 = new string[A.Length];
            for(int i=0; i<A.Length; i++)
            {
                // Convert to Binary element.
                string bitString = ConvertToBinary(A[i] + B[i]);
                C1[i] = bitString;
            }

            for(int j=0; j<C1.Length; j++)
            {
                Console.WriteLine(C1[j]);
            }
        }

        private static string ConvertToBinary(int p)
        {
            string bitString = "";
           // string reverseString = "";
            while (p > 0)
            {
                bitString += p % 2;
                p = p / 2;                
            }            

            while (bitString.Length < 4)
            {
                bitString = "0" + bitString;
            }

            // Reverse a string
            //int i = 4;
            //while (i >= 0)
            //{
            //    reverseString = bitString[i].ToString();
            //}

            return bitString;
        }

        private static void InsertionSort()
        {
            int[] arrs = { 5, 2, 4, 6, 1, 3 };

            Console.WriteLine("Unsorted Array: ");
            for (int i = 0; i < arrs.Length; i++)
            {
                Console.WriteLine(arrs[i]);
            }

            Console.WriteLine("Sorted array using insertion sort: ");

            // Starting from the 2nd element in an array
            int j = 1;
            while (j < arrs.Length)
            {
                // Assigning the 2nd element as a key.
                int key = arrs[j];

                // Initializing the 1st element by reducing 1
                int i = j - 1;

                // Continue till the i>=0 and if array value is > than key value.
                while (i >= 0 && arrs[i] > key)
                {
                    // Initializing the value to next element
                    arrs[i + 1] = arrs[i];

                    // reducing the i value by 1 and continue till it becomes 0.
                    i = i - 1;
                }

                // Assiging key value to previous element
                arrs[i + 1] = key;

                // Continue till the end of an array.
                j++;
            }

            for (int i = 0; i < arrs.Length; i++)
            {
                Console.WriteLine(arrs[i]);
            }
        }

        private static void PrintHello()
        {            
            Console.WriteLine("Hello");
        }
    }
}
