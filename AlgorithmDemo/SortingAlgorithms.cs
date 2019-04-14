using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    class SortingAlgorithms
    {
        private static void SelectionSort()
        {
            int[] Array1 = { 4, 5, 6, 6, 6, 10, 10, 2, 1 };

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

        /// <summary>
        /// This class demo's the selection sort working and its algorithms
        /// </summary>
        private static void SelectionSortDemo()
        {
            // Step 1: Select min to location 0
            // Step 2: Search the minimum element in the list
            // Step 3: Swap with value at location MIN
            // Step 4: Increment MIN to point to next element 
            // Step 5: Repeat until list is sorted

            int[] array1 = new int[] { 2, 5, 1, 3, 4 };

            for (int i = 0; i < array1.Length - 1; i++)
            {
                int min = i;        //Select minimum
                int j = i + 1;

                // iterating from j to end of an array
                while (j < array1.Length)
                {
                    if (array1[j] < array1[min]) // Search min value in list
                    {
                        min = j;
                    }
                    j++;
                }

                // Swap the minimum element with the current element
                int temp = array1[min];
                array1[min] = array1[i];
                array1[i] = temp;
            }

            // Time complexity Best=Big Omega(n^2), Average= Theta(n^2), Worst = small omega (n^2)

            // Space cmplexity
        }

        private static void InsertionSortDemo()
        {
            Console.WriteLine("Insertion sort: ");
            int[] num = { 12, 5, 4, 3, 1, 10, 8 };
            for (int j = 1; j < num.Length; j++)
            {
                int i = j - 1;

                while (i >= 0)
                {
                    if (num[i] > num[i + 1])
                    {
                        int temp = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = temp;
                    }
                    i--;
                }
            }
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

        private static void InsertionSort_2()
        {
            int[] arr = { 9, 8, 6, 7, 3, 5, 4, 1, 2 };

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                for (int m = 0; m < arr.Length; m++)
                {
                    Console.Write(arr[m] + " ");
                }
                Console.Write("\n");
            }
        }

        private static void InsertionSort1()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
            int n = arr.Length;

            if (n - 1 < n)
            {
                int key = arr[n - 1];
                int i = n - 2;
                while (i >= 0)
                {
                    //int temp = arr[i];
                    if (arr[i] > key)
                    {
                        arr[i + 1] = arr[i];

                        for (int m = 0; m < n; m++)
                        {
                            Console.Write(arr[m] + " ");
                        }
                        Console.Write("\n");
                    }
                    else
                    {
                        arr[i + 1] = key;
                        for (int m = 0; m < n; m++)
                        {
                            Console.Write(arr[m] + " ");
                        }
                        Console.Write("\n");
                        break;
                    }
                    if (i == 0)
                    {
                        if (arr[0] > key)
                        {
                            arr[i + 1] = arr[i];
                            arr[i] = key;
                        }
                        for (int m = 0; m < n; m++)
                        {
                            Console.Write(arr[m] + " ");
                        }
                    }
                    i--;
                }
            }
        }
        private static void MergeSort()
        {
            int[] arr = { 5, 2, 4, 7, 1, 3, 2, 6 };
            int p = 0, r = arr.Length - 1;
            MergeSort_Sort(arr, p, r);
        }

        private static void MergeSort_Sort(int[] arr, int p, int r)
        {
            int q = 0;
            if (p < r)
            {
                q = (p + r) / 2;
                MergeSort_Sort(arr, p, q);
                MergeSort_Sort(arr, q + 1, r);
                Merge(arr, p, q, r);
            }
        }

        private static void Merge(int[] arr, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }

            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[q + j];
            }

            int l = 0;
            int m = 0;

            for (int k = p; k < r; k++)
            {
                if (L[l] <= R[m])
                {
                    arr[k] = L[l];
                    l = l + 1;
                }
                else
                {
                    arr[k] = R[m];
                    m = m + 1;
                }
            }
        }

        private static void HeapSort()
        {
            int[] arr = { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };

            for (int i = 0; i < arr.Length; i++)
            {
                int val = MaxHeapify(arr, i);
            }
        }

        private static int MaxHeapify(int[] arr, int i)
        {
            return 0;
        }

        private static void BubbleSortDemo()
        {
            int[] array = { 4, 9, 6, 8, 5 };

            for (int k = 0; k < array.Length - 1; k++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int j = i + 1;
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write(item);
            }
        }

        private static void QuickSort()
        {
            int[] arr = { 2, 10, 3, 7, 9, 4, 6, 12, 8 };

            ArrayList left = new ArrayList();
            ArrayList right = new ArrayList();
            ArrayList equal = new ArrayList();

            int pivot = arr[0];
            int j = 0, k = 0, l = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > pivot)
                {
                    right.Add(arr[i]);
                }
                else if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    equal.Add(pivot);
                }
            }
            ArrayList result = new ArrayList();
            foreach (var item in left)
            {
                result.Add(item);
            }
            foreach (var item in equal)
            {
                result.Add(item);
            }
            foreach (var item in right)
            {
                result.Add(item);
            }

            Array abc = result.ToArray();
            int x = 0;
            foreach (var item in abc)
            {
                arr[x] = (int)item;
                x++;
            }
        }

        private static void COuntingSort2()
        {
            string str = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33";

            //string path = @"D:\Projects\Test.txt";
            //string str = File.ReadAllText(path);

            string[] strarr = str.Split(' ');
            int[] arr = Array.ConvertAll(strarr, Int32.Parse);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        private static void CountingSort1()
        {
            string str = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33";

            //string path = @"D:\Projects\Test.txt";
            //string str = File.ReadAllText(path);

            //string str = "0 2 0 2 0 0 1 0 1 2 1 0 1 1 0 0 2 0 1 0 1 2 1 1 1 3 0 2 0 0 2 0 3 3 1 0 0 0 0 2 2 1 1 1 2 0 2 0 1 0 1 0 0 1 0 0 2 1 0 1 1 1 0 1 0 1 0 2 1 3 2 0 0 2 1 2 1 0 2 2 1 2 1 2 1 1 2 2 0 3 2 1 1 0 1 1 1 0 2 2";
            string[] strarr = str.Split(' ');
            int[] arr = Array.ConvertAll(strarr, Int32.Parse);

            Dictionary<int, int> count = new Dictionary<int, int>();

            for (int i = 0; i < 100; i++)
            {
                count.Add(i, 0);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (count.ContainsKey(arr[i]))
                {
                    count[arr[i]]++;
                }
            }

            foreach (var item in count)
            {
                Console.Write(item.Value + " ");
            }
        }

        public static void MergeSortDemo(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = p + r / 2;
                MergeSortDemo(A, p, q);
                MergeSortDemo(A, q+1, r);
                MergeDemo(A, p, q, r);
            }
        }

        public static void MergeDemo(int[] A, int p, int q, int r)
        {
            int[] L = new int[A.Length / 2];
            int[] R = new int[A.Length / 2];

            //int p = 0;
            for (int i = 0; i < A.Length / 2; i++)
            {
                L[i] = A[i];
                p++;
            }

            for (int j = 0; j < A.Length / 2; j++)
            {
                R[j] = A[p + j];
            }

            for (int k = 0; k < A.Length; k++)
            {
                int i = 0, j = 0;
                if (L[i] >= R[j])
                {
                    A[k] = R[j];
                    R[j] = L[i];
                    j++;
                }
                else
                {
                    A[k] = L[i];
                    i++;
                }
            }
            for (int x = 0; x < A.Length; x++)
            {
                Console.Write(A[x] + " ");
            }
        }
    }
}
