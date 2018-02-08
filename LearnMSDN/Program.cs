﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace LearnMSDN
{
    class Program
    {
        public delegate void Del(int x);
        static void Main(string[] args)
        {
            //DelegateDemo demo = new DelegateDemo();

           //string value = ReduceString();
            //Console.WriteLine(value);

            //RondingStudentGrade();

            //AppleOrangeRange();

            //ApplyResourceFile();

            //demo.MethodWithCallback(10, 20, demo.Del handler);

            //CheckBeautifulString();
            //SuperReducingString();

            //FindSubstring();
            //FindSubStringAsHackerrank();

            //FindLonelyInteger();
            //FindCaesarCipher();
            //DayOfTheProgrammer();
            //BetweenTwoSets();
            //IceCreameParlor();
             //MininumLoss();               //Take input and test

           
            //Pairs();                      //Timeout error
            //FindMaximumSubArrayAddition();
            //FunnyString();
            //SubsetsWithAUniqueSum();
            //MissingNumbers();           
            //TwoStrings();

            //SeparateNumbers();
            //BirthDayChocolate();

            //MigratoryBirds();

            //CalculatePermutation();
            //InsertionSort();
            //InsertionSort_2();     
            //QuickSort();
            //CalculateMaxXor();

            //CalculateMaxXoRShortcutMethod();
            //SumVsXoR();
            //CounterGame();

            //CalcXoR();
            //WeightedUniformStrings();
            //BigSorting();                   //Solve it;
            //FindMedianValue();

            //HeapSort();

            //MergeSort();

            //CheckPolindromWord();
            //MarsExploration();

            //MakingAnagrams();

            StringConstruction();
            //StringFunctionCalculation(); -Incomlete

            //AbsoluteElementSums();

            //GemStones();
            //AlternatingCharacters();
            //Anagram();

            //BreakingTheRecords();
            //SockMerchants();

            //DrawingBook();

            //MakePatter();
            //ElectronicsShop();

            //CatsAndMouse();

            //FormingAMagizSquare();
            //CountingSort1();

            //ReductionCost();

            //FindUniqueString();

            //HackerlandRadioTransmitters();
            //RevisedRussianRoulette();
            Console.ReadLine();
        }

        private static void RevisedRussianRoulette()
        {
            int[] doors = {0,1 ,0 ,1,0,1,0,1,1,1};

            int i = 0;
            int maxLocked = 0;
            int minLocked = 0;

            while (i < doors.Length)
            {
                int j = i;
                int k = j+1;
                if (j < doors.Length && k <doors.Length)
                {
                    if (doors[j]==1 && doors[k] == 1)
                    {
                        minLocked++;
                        j++;
                    }
                    else if(doors[j]==1)
                    {
                        maxLocked++;
                        j++;
                    }
                    else
                    { j++; }
                }
                i = j;
            }
            Console.WriteLine(minLocked + "--" + maxLocked);
        }

        private static void HackerlandRadioTransmitters()
        {
            int[] x = {7,2,4, 6,5,9,12,11 };
            int k = 2;
            Array.Sort(x);
            int count = 0;
            int j = 0;

            for (int i = 0; i < x.Length; i++)
            {
                while (Math.Abs(x[i]-x[++i]) <= k)
                {
                    i++;
                }
                i = j;
                count++;
            }
        }

        private static void FindUniqueString()
        {
            string s = "beabeefeab";
            string s1 = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!s1.Contains(s[i]))
                {
                    s1 += s[i];
                }
            }
            Console.WriteLine(s1);
            for (int j = 0; j < s1.Length; j++)
            {
                s = s.Remove(j);
            }
        }

        private static void ReductionCost()
        {
            int[] num = { 1, 2, 3, 4};
            int count = 0;

            int i=0;
            while (i < num.Length)
            {
                int j = i+1;
                if (num.Length ==1)
                {
                    break;
                }

                if (i!=j && j < num.Length)
                {
                    int val = num[i] + num[j];
                    count += val;
                    num[i] = 0;
                    num[j] = 0;

                    while (i < num.Length - 2)
                    {
                        num[i] = num[i + 2];
                        i++;
                    }
                    Array.Resize(ref num, num.Length - 1);

                    num[num.Length - 1] = val;
                    Array.Sort(num);
                }
                i = 0;
            }
            Console.WriteLine(count);
        }

        private static void CountingSort1()
        {
            string str = "63 25 73 1 98 73 56 84 86 57 16 83 8 25 81 56 9 53 98 67 99 12 83 89 80 91 39 86 76 85 74 39 25 90 59 10 94 32 44 3 89 30 27 79 46 96 27 32 18 21 92 69 81 40 40 34 68 78 24 87 42 69 23 41 78 22 6 90 99 89 50 30 20 1 43 3 70 95 33 46 44 9 69 48 33 60 65 16 82 67 61 32 21 79 75 75 13 87 70 33";
            string[] strarr = str.Split(' ');
            int[] arr = Array.ConvertAll(strarr, Int32.Parse);

            Dictionary<int, int> count = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (count.ContainsKey(arr[i]))
                {
                    count[arr[i]]++;
                }
                else
                {
                    count.Add(arr[i], 0);
                }
            }

            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
        }

        private static void FormingAMagizSquare()
        {
            int[,] s = { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 5 } };

            int digVal = 0;
            int length = s.GetLength(0);

            for (int i = 0; i < length; i++)
            {
                int value = 0;
                int colVal = 0;               

                for (int j = 0; j < length; j++)
                {
                    value += s[i,j];
                    colVal += s[j, i];
                    
                }
                digVal += s[i, i];
                if (value == colVal)
                    continue;                    
            }

            for (int i = 0; i < s.Length; i++)
            {
                int value = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    value += s[j, i];
                }
                Console.WriteLine(value);
            }
        }

        private static void CatsAndMouse()
        {
            int x = 1, y = 2, z
                = 3;

            if (Math.Abs(x-z) > Math.Abs(y-z))
            {
                Console.WriteLine("Cat B");   
            }
            else if(Math.Abs(x-z) < Math.Abs(y-z))
            {
                Console.WriteLine("Cat A");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }
            
        }

        private static void ElectronicsShop()
        {
            int[] keyboards = { 3, 1 };
            int[] drives = { 5, 2, 8 };
            int s = 10;
            int value = 0;

            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int temp = keyboards[i] + drives[j];
                    if (temp <= s && temp > value)
                    {  
                        value = temp;
                    }
                }
            }
            if (value != 0)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }

        private static void DrawingBook()
        {
            int n = 70809;
            int p = 46090;

            int tot = n / 2;
            int right = p / 2;
            int left = tot - right;
            int ret = 0;

            if (right < left)
            {
                ret = right;
            }
            else
            {
                ret = left;
            }
            Console.WriteLine(ret);
            //int front = 0;
            //int back=0;

            //List<string> st = new List<string>();

            //int i = 0;
            //while (i <= n)
            //{
            //    int k = 0;
            //    while (k < 2 && i<=n)
            //    {
            //        int val = i + 1;
            //        st.Add(i + "" +val);
            //        i = i + 2;
            //        k++;
            //    }                
            //}
            //foreach (var item in st)
            //{
            //    if (item.Contains(p.ToString()))
            //    {
            //        break;
            //    }
            //    front++;
            //}

            //for (int j = st.Count-1; j >=0; j--)
            //{
            //    if (st[j].Contains(p.ToString()))
            //    {
            //        break;
            //    }
            //    back++;
            //}
            //Console.WriteLine(front + "--" + back);
            
            
            //int i = 1;
            //int j = n;

            //int first=0, last = 0;

            //while(i < n)
            //{
            //    int k = i+1;
            //    if (i==1)
            //    {
            //        i++;
            //        continue;               
            //    }
            //    else
            //    {
            //        if (i==p || p== k)
            //        {
            //            first++;
            //            break;
            //        }
            //        first++;
            //    }
            //    i = i + 2;
            //}

            //while (j >= 1)
            //{
            //    int l = j -1;
            //    if (j %2==0)
            //    {
            //        j--;
            //        continue;       
            //    }
            //    else
            //    {
            //        if (j==p || l==p)
            //        {
            //            break;
            //        }
            //        last++;
            //    }
            //    j = j - 2;
            //}
            //Console.Write(first + "--" + last);
        }

        private static void SockMerchants()
        {
            int[]  ar = new int[]{4, 5, 5, 5, 6, 6, 4, 1, 4, 4, 3, 6, 6, 3, 6, 1, 4, 5, 5, 5};

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (d.ContainsKey(ar[i]))
                {
                    d[ar[i]]++;
                }
                else
                    d.Add(ar[i], 1);
            }

            int count = 0;
            foreach (var item in d)
            {   
                if (item.Value > 1)
                {
                    if (item.Value % 2==0)
                    {
                        count += item.Value / 2;
                    }
                    else
                    {
                        count += item.Value / 2;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void BreakingTheRecords()
        {
            int[] score = {3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            int max = score[0];
            int min = score[0];

            int minCount = 0;
            int maxCount = 0;

            for (int i = 1; i < score.Length; i++)
            {
                if (score[i] > max)
                {
                    max = score[i];
                    maxCount++;
                }
                else
                {
                    if (score[i] < min)
                    {
                        minCount++;
                        min = score[i];
                    }
                }
            }
            Console.WriteLine(maxCount + " " + minCount);
        }

        private static void MakePatter()
        {
            //    *
            //   * *
            //  * * *

            for (int i = 0; i < 3; i++)
            {
                int k = i;
                for (int j = 0; j < 5; j++)
                {
                    if (j %2!=0)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }                    
                }
                Console.Write("\n");
            }
        }

        private static void Anagram()
        {
            string s = "xyyx";

            string s1 = s.Substring(0, s.Length / 2);
            string s2 = s.Substring(s1.Length, s.Length / 2);
            int count = 0;

            if (s.Length % 2 != 0)
            {
                Console.WriteLine(count);
            }

            int i = s2.Length - 1;
            while (i >= 0)
            {
                char c = s2[i];
                int k = s1.IndexOf(c);

                if (k < 0)
                {
                    s2 = s2.Remove(i, 1);
                    count++;
                }
                else
                {
                    s1 = s1.Remove(i, 1);
                    s2 = s2.Remove(i, 1);
                }
                i--;
            }
            Console.WriteLine(count);

            //var sd1 = new Dictionary<int, int>();
            //var sd2 = new Dictionary<int, int>();
            //var numbersWithFour = new List<int>();

            //foreach (var c in s1)
            //{
            //    if (sd1.ContainsKey(c))
            //        sd1[c]++;
            //    else
            //        sd1.Add(c, 1);
            //}

            //foreach (var c1 in s2)
            //{
            //    if (sd2.ContainsKey(c1))
            //        sd2[c1]++;
            //    else
            //        sd2.Add(c1, 1);
            //}

            //Console.WriteLine(s1.Length + "-----" + s2.Length);

            //foreach (var v in sd2)
            //{
            //    int t = v.Key;

            //    if (sd1.Keys.Contains(t))
            //    {  
            //    }

            //    int sum = 0;
            //    int j = 0;

            //    while (j < v.Value)
            //    {
            //        sum += Math.Abs(t);
            //        j++;
            //    }
            //    //al.Add(sum);
            //}

            Console.WriteLine(count);

        }

        private static void AlternatingCharacters()
        {
            string s = "AAAA";            
            int count = 0;
            string c1 = "AB";
            string c2 = "BA";
            int i = 0;

            while ( i < s.Length)
            {
                string ss = s.Substring(i, 2);
                int j = 0;

                if (s[i] == 'A')
                {   
                    while (j < c1.Length)
                    {
                        if (ss[j] != c1[j])
                        {
                            s = s.Remove(j, 1);
                            count++;
                        }
                        j++;
                    }
                    i = i+2;
                }
                else 
                {
                    while (j < c1.Length)
                    {
                        if (ss[i] != c2[j])
                        {
                            s = s.Remove(j, 1);
                            count++;
                        }
                        j++;
                        i++;
                    }
                    i = j;
                }
            }
            Console.WriteLine(count);
        }

        private static void GemStones()
        {
            string[] arr = { "abcdde", "baccd", "eeabg" };
            string first ="abcdefghijklmnopqrstuvwxyz";
            int count = 0;
            
            for (int i = 0; i < arr[0].Length; i++)
            {
                int j = 0;
                char c = first[i];
                bool found = true;

                while (j < arr.Length)
                {
                    if (!arr[j].Contains(c))
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        j++;
                        continue;
                    }
                }
                if(found)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void AbsoluteElementSums()
        {
            int[] arr = { -1, 2, -3 };
            int[] ele = { 1, -2, 3 };

            var fn = @"C:\Users\user\Desktop\Test.txt";
            
            var val = File.ReadAllText(fn);
            var array = val.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = Array.ConvertAll(array, int.Parse);

            //var dictionary = new Dictionary<int, int>();
            //var numbersWithFour = new List<int>();

            //foreach (var number in numbers)
            //{
            //    if (dictionary.ContainsKey(number))
            //        dictionary[number]++;
            //    else
            //        dictionary.Add(number, 1);
            //}

            ArrayList al = new ArrayList();


            //foreach (var v in dictionary)
            //{
            //    int t = v.Key;
            //    int sum = 0;
            //    int j = 0;

            //    while (j < v.Value)
            //    {
            //        sum += Math.Abs(t);
            //        j++;
            //    }
            //    al.Add(sum);
            //}

            for (int i = 0; i < 4001; i++)
            {
                int t = numbers[i];
                int sum = 0;
                int j = 0;

                while (j < numbers.Length)
                {
                    int tt = numbers[j] + t;
                    numbers[j] = tt;
                    sum += Math.Abs(tt);
                    j++;
                }
                al.Add(sum);
            }
            int[] res = al.OfType<int>().ToArray();
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }

        private static void StringFunctionCalculation()
        {
            string s = "aaaaaa";



        }

        private static void StringConstruction()
        {
            string s = "abcd";
            string p = "";

            for (int i = 0; i < s.Length; i++)
            {
                   
            }

        }

        private static void MakingAnagrams()
        {
            string s1 = "fcrxzwscanmligyxyvym";
            string s2 = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            int index = 0;

            int[] ints = new int[26];

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            for (int i = 0; i < c1.Length; i++)
            {
                ints[c1[i] - 97]++; 
            }
            for (int i = 0; i < c2.Length; i++)
            {
                ints[c2[i] - 97]++;
            }
            int sum = 0;
            for (int i = 0; i < 26; i++)
                sum += Math.Abs(ints[i]);

            Console.WriteLine(sum);

            //for (int i = 0; i < s1.Length; i++)
            //{
            //    int j = 0;
            //    while (i < s1.Length && s2.Contains(s1[i]) && j < s2.Length)
            //    {
            //        if (s1[i] == s2[j])
            //        {
            //            s1 = s1.Remove(i, 1);
            //            s2 = s2.Remove(j, 1);                        
            //        }
            //        j++;
            //    }
            //}
        }

        private static void MarsExploration()
        {
            string s = "SOSSOT";
            int count = 0;
            string org = "SOS";

            for (int i = 0; i < s.Length; i++)
            {
                string temp = s.Substring(i, 3);
                int k=0;
                while (k <temp.Length)
                {
                    if (org[k] != temp[k])
                    {
                        count++;
                    }
                    k++;
                }
                i = i + 2;
            }
            Console.WriteLine(count);
        }

        private static void CheckPolindromWord()
        {
            string s = "aaa";
            //////////////////Taken from discussion/////////////////
             int len =  s.Length;
                int start = 0, end = len-1;      
                while(start<end){
                    if(s[start]!=s[end])
                    {
                        if((s[start+1]==s[end]) && (s[start+2] == s[end-1]))
                           start = start;
                        else
                            end=  end;
                    }
                    start++;
                    end--;
                }
                //return -1;
            ///////////////////////////////////

            
            int b = -1;
            int count = 0;
            string s1 = s;

            for (int k = 0; k < s.Length +1; k++)
            {
                count = 0;
                int i = 0;
                int j = s1.Length - 1;

                while (i < s1.Length / 2)
                {
                    if (s1[i] != s1[j])
                    {
                        s1 = s.Remove(k, 1);
                        break;
                    }
                    i++;
                    j--;
                    count++;
                    continue;
                }
                if (count==s1.Length/2)
                {
                    b = k-1;
                    break;
                }
            }
            Console.WriteLine(s + "------:::" + b);
        }

        private static void MergeSort()
        {
            int[] arr = { 5, 2, 4, 7, 1, 3, 2, 6 };
            int p=0, r=arr.Length-1;
            MergeSort_Sort(arr, p, r);

        }

        private static void MergeSort_Sort(int[] arr, int p, int r)
        {
            int q=0;
            if (p <r)
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

            int l= 0;
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
            int[] arr = { 16, 14, 10, 8, 7, 9, 3, 2,4,1 };

            for (int i = 0; i < arr.Length; i++)
            {
                int val = MaxHeapify(arr, i);
            }
        }

        private static int MaxHeapify(int[] arr, int i)
        {
            return 0; 
        }

        private static void FindMedianValue()
        {
            int[] arr = { 0, 1, 2, 4, 6, 5, 3 };

            int j = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                j =i-1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

            int mid = ((arr.Length) / 2);
        }

        private static void BigSorting()
        {
            string[] arr = { "31415926535897932384626433832795", "1", "3", "10", "3", "5" };

            for (int i = 1; i < arr.Length; i++)
            {
                string key = arr[i];
                BigInteger b = BigInteger.Parse(key);
                long j = i - 1;

                while (j >= 0  && BigInteger.Parse(arr[j]) > b)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            //string[] arr2 = Array.ConvertAll(arr1, x => x.ToString());
        }

        private static void WeightedUniformStrings()
        {
            string s = "abccddde";
            List<int> lst = new List<int>();
            int weight = 0;
            int j = 0;
            int i = 0;

            while (i < s.Length)
            {
                j = i + 1;
                if (true)
                {                    
                    while (j < s.Length)
                    {
                        if (s[i] == s[j])
                        {
                            j++;
                        }
                        else
                            break;
                    }                    
                }

                string ss = s.Substring(i, j - i);
                int temp = 0;

                for (int k = 0; k < ss.Length; k++)
                {
                    weight =s[i] - 96;
                    temp += weight;
                    lst.Add(temp);
                }
                i = j;
            }
        }

        private static int GetWeightForAlphabets(char s)
        {
            int val = 0;
            switch (s)
            {
                case 'a':
                    val= 1;
                    break;
                case 'b':
                    val = 2;
                    break;
                case 'c':
                    val = 3;
                    break;
                case 'd':
                    val = 4;
                    break;
                case 'e':
                    val = 5;
                    break;
                case 'f':
                    val = 6;
                    break;
                case 'g':
                    val = 7;
                    break;
                case 'h':
                    val = 8;
                    break;
                case 'i':
                    val = 9;
                    break;
                case 'j':
                    val = 10;
                    break;
                case 'k':
                    val = 11;
                    break;
                case 'l':
                    val =  12;
                    break;
                case 'm':
                    val = 13;
                    break;
                case 'n':
                    val = 14;
                    break;
                case 'o':
                    val = 15;
                    break;
                case 'p':
                    val = 16;
                    break;
                case 'q':
                    val = 17;
                    break;
                case 'r':
                    val = 18;
                    break;
                case 's':
                    val = 19;
                    break;
                case 't':
                    val = 20;
                    break;
                case 'u':
                    val = 21;
                    break;
                case 'v':
                    val = 22;
                    break;
                case 'w':
                    val = 23;
                    break;
                case 'x':
                    val = 24;
                    break;
                case 'z':
                    val = 25;
                    break;
            }
            return val;
        }

        private static void CounterGame()
        {
            long n = 1560834904;
            int i = 1;

            while (n > 0)
            {
                bool b = ChackPowerOf2(n);
                if (!b)
                {
                    n = n - 2;
                    if (n == 1)
                    {
                        Console.WriteLine("Louise");
                        break;
                    }
                }
                else
                {
                    n = n - (n / 2);
                    if (n == 1)
                    {
                        Console.WriteLine("Richard");
                        break;
                    }
                }
                
                i++;
            }
        }

        private static bool ChackPowerOf2(long n)
        {
            int i=0;
            long val = 0;
            bool isPow = false;

            while (val <= n)
            {
                double d = Math.Pow(2, i);
                val  = Convert.ToInt64(d);
                if (val==n)
                {
                    isPow = true;
                    break;
                }
                i++;
            }

            return isPow;
        }

        private static void SumVsXoR()
        {
            long n = 15;
            long count = 0;
            //for (long k = 0; k <= n; k++)
            //{
            //    long sum = n + k;
            //    long val = n ^ k;

            //    if (sum != val)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            for (long k = 0; k <= n; k++)
            {
                long sum = n + k;
                long val = n ^ k;

                if (sum != val)
                {
                    continue;
                }
                else
                {
                    count++;
                }
            }

            while (n>0)
            {
                count += (n % 2==0) ? 0 : 1;
                n /= 2;
            }
            count =(Int64) Math.Pow(2.0, Convert.ToDouble(count));
            Console.WriteLine(count);
        }


        private static void CalculateMaxXoRShortcutMethod()
        {
            int l = 10, r = 15;  //1023
            List<int> lst = new List<int>();
            for (int j = l; j <= r; j++)
            {
                int x = j;
                int f = j;
                while (x <= r)
                {
                    int val = f ^ x;                    
                    lst.Add(val);
                    x++;
                }
            }
            lst.Sort();
            for (int i = lst.Count - 1; i > 0; i++)
            {
                Console.WriteLine(lst[i]);
                break;
            }
        }

        private static void CalcXoR()
        {
            int a = 10, b = 15;
            int v = a ^ b;
            Console.WriteLine(v);
        }

        private static void CalculateMaxXor()
        {
            int l = 65, r = 898;  //1023
            List<int> lst = new List<int>();
            for (int j = l; j <= r; j++)
            {
                int x = j;
                int f = j;
                string s1 = ConvertFromDecToBinaryculateXoR(f);
                while (x <= r)
                {
                    string s2 = ConvertFromDecToBinaryculateXoR(x);

                    if (s1.Length != s2.Length)
                    {
                        if (s2.Length > s1.Length)
                        {
                            s1 = s1.PadLeft(s2.Length, '0');
                        }
                        else
                        {
                            s2 = s2.PadLeft(s1.Length, '0');
                        }
                    }

                    string res = "";
                    for (int i = 0; i < s2.Length; i++)
                    {                        
                        if (s1[i]!=s2[i])
                        {
                            res += "1";   
                        }
                        else
                        {
                            res += "0";
                        }
                    }
                    char[] resa = res.ToCharArray();
                    string s11 = new string(resa);
                    int val = ConvertToDexFromBinary(s11);
                    lst.Add(val);
                    x++;
                }
            }
            lst.Sort();
            for (int i = lst.Count-1; i > 0; i++)
            {
                Console.WriteLine(lst[i]);
                break;
            }
        }

        private static int ConvertToDexFromBinary(string s11)
        {
            int j=0;
            int v = 0;
            for (int i = s11.Length-1; i >= 0; i--)
            {
                double p = Math.Pow(2, j);
                int s = Convert.ToInt32(s11[i].ToString());
                v += s * Convert.ToInt32(p);
                j++;
            }
            return v;
        }

        private static string ConvertFromDecToBinaryculateXoR(int x)
        {
            string s = "";
            int r = 0;
            while (x !=0)
            {
                r = x % 2;
                x = x / 2;                
                s = s + r.ToString();
            }
            char[] s1 = s.ToCharArray();
            Array.Reverse(s1);
            return new string(s1);
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

        private static void InsertionSort_2()
        {
            int[] arr = { 9, 8, 6, 7, 3, 5, 4, 1, 2 };

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
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

        private static void InsertionSort()
        {
            int[] arr = { 2,3, 4, 5 ,6, 7, 8, 9, 10, 1};
            int n = arr.Length;

            if (n-1<n)
            {
                int key = arr[n-1];
                int i = n-2;
                while (i >= 0)
                {
                    //int temp = arr[i];
                    if (arr[i] > key)
                    {
                        arr[i + 1] = arr[i]; 

                        for (int m = 0; m < n; m++)
                        {
                            Console.Write(arr[m] +" ");
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
                    if(i==0)
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

        private static void MigratoryBirds()
        {
            int[] ar = { 1, 4, 4, 4, 5, 3 };
            int n = 6;

            int[] t = { 1, 2, 3, 4, 5 };

            int max = 0;
            int type = 0;
            for (int i = 0; i < t.Length; i++)
            {
                int j = 0;
                int count = 0;
                while (j < ar.Length)
                {
                    if (t[i] == ar[j])
                        count++;
                    j++;
                }
                if (count>max)
                {
                    max = count;
                    type = i + 1;
                }
            }
            Console.WriteLine(type+ ":" +max);
        }

        private static void BirthDayChocolate()
        {
            int[] s = { 1,2,1,3,2};
            int d = 3, m = 2;

            int count=0;
            for(int i=0; i<s.Length; i++)
            {
                int j=i;
                int sum=0;
                int k = 0;
                
                while (k < m)
                {
                    if (j < s.Length)
                    {
                        sum += s[j];
                        j++;
                    }
                    k++;
                }
                
                if(sum==d)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        private static void SeparateNumbers()
        {
            string s = "88888888888888888888888888888888";
            bool valid = false;
            // Try each possible starting number
            long f = -1;
            for (int i = 1; i <= s.Length / 2; ++i)
            {
                // Get first index. 
                long x = Convert.ToInt64(s.Substring(0, i));
                f = x;
                string str1 = x.ToString();
                while (str1.Length < s.Length)
                {
                    str1 += Convert.ToInt32(++x);
                }
                if (s.Equals(str1))
                {
                    valid = true;
                    break;
                }
            }
            Console.WriteLine(valid ? "YES  " + f : "NO");
        }

        private static void CalculatePermutation()
        {
            string s = "abc";  //o/p: 

            string s1;
            for (int i = 0; i < s.Length; i++)
            {
                int j = i;
                if (i==0)
                {
                    j = j+1;
                    s1 = Swap(j, j++);  
                }
                if (i==1)
                {
                    
                }
                if (i==2)
                {
                    
                }
            }
        }

        private static string Swap(int j, int p)
        {
            throw new NotImplementedException();
        }

        private static void TwoStrings()
        {
            string s1 = "hitcwvrtvizzztsecgtezzitwhgcbvesrtgwijrvbihsctwvigrbtbbisgewzevjgsessiebrstirztjtwgzzgevweigiccjzswecbtwgitzsicbjezjttcjiittgsggtehtwwgjbtghrirejechbhiwcbrvcgzevjvszztwssirsitsihcegrtctzghrbgibibgjrjgebcvbtgetjbrthjzvesiieciwivrzwhbvbhhihchgsjgjsezhgihtghrcrewbgibicrzzrtijcctsvehhgzticrbhvjzjgeitsbberizjivbzegjjbwrsbzrrsvhgbgewgeiwvvzihbgwgeseiiriewgvitjbtbrgicjgvgjegzewsbvrwtibsbivzjivjebcthzwsersbeeeeccthwztgwcwwgjbwtbvctwievsbzjstviiwtctvbgiicgetijrczchbwecitzcrehejrstjjgzbgvwvrwhiwzggcbvgjegtewrjwbwscgcwgjbeswssbhcsrgicigsjjrhsrtegjbrjczbchzjteewchbjiwvhtwwgsretsteiieiisvizzjrgriigwvezvbtzvrzjzjtsttgrvsjrithiizhzvzszjjrwjrwhgcrgcwzhetvriregsectewzvevcrrzrrrbvgiirwhitbzetcbbcjezsbezzbbtjzcszsbstzcbjjstsvjewwrihjzbcgswbhtvjjsgevciwzcheetvgezgrjhbbbwesrwrzwigweehcvsertjhezwbvrswjeghczbgjrzvwwwceijvijvviggwthvzsvrijhwzjihrbecswwwgtrchevsivwrbwwiiwhvgrhbvtghcstsrzzthjgrewghiecwcbgwzhvjezsrseccerssgticvzeecjgiiwrcbcvbchiirvithwrzgrsviihjecrgbvbzeertivssjgeijzgrtrjcbbbhsgeirsgsswigcizgcszzwebvbrstjehrhsebsbbzjtberrbigjbcctesvctvitgjgrsizggsbevrwwbbczgicbgigrcijjzsezzsisjetchwecctbggbczevvvisbgbrcsvtrhihshjhbesjcsrzhsczsjzgbvjbebrjwjjgcztwrtrzbtwgejggzevvijgeeiivgbjrrtbtethgztsbicjwrvsbejtjzcrwsebjrrvbhrhzzcvjhbzrvtvctzbzjhrerwheebshrtezvhvgjbgehbbtsstewwwhccjtigwwvwwcjwbeejgbiegzzvtjzwrhgjgzigwetssvtzzcbggctszvjshsziwwvcirjisshcvitgcgrriwerizszbbvcjzihzjgejzjhbtezshvcgrizizsvvrrzwgejhtehjzzbbjzcbzstzchtezsjbvjzrweezzerjhhwesshvrtzhirrjjebsjrcwcwerrhzechsrgbjjwwjrjchhzvibreghtssijshvgbwivtrvgtbserwvhztgjwttbsjrcchjvviziczhsewhzgveevsethsvvwtvvzbgzwjwrgcjeghtjhgjsgvzvibriggrjtstijhrvteithjjwhbvevjeebewsrwejtbtsrttgrbhchegetjgvtvrhgwbjtwrcverwgrigtjsiercthrhrhvcjggrihzbecehszeejwwviizgjjetbtzvivjvvcrthchvszjzregtrwgzvzjwtiwejcbhwwswzgcwibrjrbwvsccejehvethjjsriswgzegtwrghhgigireeibvesrwerrgigitvhjcgjzzbebezchtzijeejzweiivtzesbsbgwiszvzcvvhhrjjhhjvscbwbjiszvrzzscwzggwwithceigbcssezwccjjhgrcvivtzitrbjcgtibebbthcjcccbzwrwbbjbsjibvszbrirebecsbvggeebzsrrerhbrsctwcbhrgvwcctrhchjicziecsgthrrtzijivwtrciiztrzgtbibiwiiwscrhjwjcvtwhtjwrejiwewvgbczwtschhwtevggghzewjzsbwhweswgiwzbwwsgtivztrziiwzchcsehjghzwrjtgbbwwvsebsrrchhcrzhtwrijhzhswesersvtgwtsrwesitbrrigzbgwvbvwvwrvgsgbzwgejjtsszjvihbebvgjrztjzrcisgjcswzssvhsztghrivtjjswhwhvwhvgiicbsvtgtcvwziicssieibjcbibcicvhchgjhwhsvsjzvhsvbjcerbitrgjbbhewcszvbbgvvgwvvisesgggcvrzjsgvvtgwebihcsivcrbzibichsztgsivgzebjzggcvwbejijhgvijijjebejwbbtveecrwigrhzgvstibethwtsegwbhtbgjbsgehhvsrjrsresrwhishvzbhhrzzjzberwsrjezwvvhcwbhhzwrzhczwwzvtjziirierrivcwghhjtgzgcjtgigcwthbccwciizhcsjtvzhzhhsbjrzgwevcjhireiczsvirzcjwcchcgjeigjbbtjrrjbbbzjvjigezhrwzgbtvithbecrizrihhgzsrssbjgbtztsbwhizzvgevrwsjcsgeiejejhegsvvbrvchsbrcivcvtctizhigiccbesbverrtvzvtezvvehgzccjcieetvheirjcggwijttcvciwrssttssizserztjibzhzhijcjwbieesesjirchgebjgjvvwribtrtwegctisrrhsirsbviiegvcvhrgevezjwegwsjihwtbsvwtvvcwizhzvecjsjrzzrscgrzihrsescrehgihhvcjswvjzhgchztvrebvccgrzbhvjztvcgrcbchbwtcbrtbzbcvsvrbitvcrhzzhsciertjsherhhzzthischebcttrwjgiezcztwzvbehrgtwwrrhtctihbtczvsczsrviczvwsejjrrzwjbhsgggzvsrtterwerhggjeeeiggeibszbtesejjciwjjebvhejvjzijtibrcwwcherrteijbbizthjiibwtzjzjgvwivbwvsbihsgrigsgvgebjzjbjvitsszgsjjggchszvzvvvesvcghtijshztstbbzwrbhswbtzewjigrhjbgibhttbswwwgvjtzwtsgshvgcigsghwgrzsteissbrtwvtbccevveegsbsbecjtjssgtrtiwtwhjviezcewgzszrhjsbvebrizvwzzercbgtehvijthrhizgiwzjrcjetzgzrtbrehvvztihjrhwzejvtjhjictvbtvsjczbhijizhevjgtvhgcbtrrgchvjzetrrrecizwjgitwvcejwshvihjijvvzhgccrrhctiihregrrjiwgswervveszceeicijjctvgswshjbtibttrtzjszzetzihgsggwejszjrhcetibehhebtrgsgcwgsjhzwrrwzsjbgtrtjjcciebzivesjbrwvttbsztstwtbweveejewetgcvejszejievezrevzvivwhiiibjwijzstsgigcevhgbzeizjgivshvzjisbrgjzvjzhjbivzwhtteijeewgzvvctzjwzsivgrtzvscebvezgbzhsbrivehehsvcccbzibcegzegzshbrizwwigwhectezegccjhvhwsrvsbgegvizwebtbzssebzwiwgzrbezwecvjvggrvcthwhwcszsjgigtgiggcrccttvsisvjehvwiszcwgczhhbzztbgvjrgciivzvvcrggtjrgzzhsjewgsjttsreshbhcvcibzhgbggwhgjjjeicgshvwhbtgiwriztiebjcjjctjhcjggzsserewwgijzgsgzwvsrzssciebhrrgjebcbwsvwbtbwhjtwsvjvbhtvbbtzejeiirrvezrzzgjgvghcchjvbtvbsrbvjtbitrtjrhghsgbrvgizcvejvjrtjzgghgrvtvhtwihezvhijhscjtgbhvtgrribvzwwbvbzrbrbehhrtbbtgwshbrgcbbtezvgejvweggiwstzizjtjvecjwirbhvrhjzccsrgvhbsrerhbhwicjtijrzrhjtstccijjjbvtzsjwwiigvrwercrjjeivbivcjzciscecjigjiwgteghwwtvrebrwverhiwwbzbtgvjrvgechjtgtsrzwevhircjhssitjtesgwiiwttggvweewhirzsbgcsjrwsvwvgerweizgezegrsjvctzzrrtrreejjwitbrcwbsgzettsjzethvwzswewvgsijgiccvvergsswsecrrzjzjhghijhvgjevhjvsvbizzjhcvttivzshjjbijhesrwrhtresvgwizrebhjvttrshwjitwtetjjtjgrzvbjebvgrigvgjsgtebwzjvrwbvzbjvtjcivzgjwweehizzhgjzchezcwzecjbscjwwithzgjhtcbjrtwsjbsibcrbvrvhgwbbbzjcjvbsrhiwvbhcwccwegbzwigvzsrstjcbvvcthhwzjjwtzhrvhiwbhrecjwzcrrcejbvwgrrwejwcjhsrehggrgihwvchhwbbrbwrwewgbgzzscgtrbbvrtsejggzvzzjsbrgirwbjhvwiisbsbvhtbzscehricsrhvvjwhieczgbwrwjbhwjshgzbccihrivziwgzgwwrgtvzhggcghwietbjgjvsgibrjcczsciiibcjtizbcbzezczcihttczjzhsrccbtjitcsgezsrjbwvceweizicrrrgvwtgjvirisvcejwrescjticzzzcsbrsveizhevttrzbisrhcvvbccbvsjjtwttebjrrsvervehrzvttegirsjzjvgrsverrbsbitrzsgetwvitvcbivrrceeeeiirwchrbjhevgricbzgvczvgvrhbwjegjrtjhiiiicjgcrezttvzgjggcgwcihssrghegbvhzgbztjircztweezivgzwcscrvbwtivjzejjrzjetswevwevwhjcvrjbrwwvjjhvsbijezwcjzibzgiziwetirieggibztwzgsihbsbvejjhcrctiswzscjgirjisbgczscscbisgjgtzwcvhtgervwcercwccgzstjgezibrttcrettcrzvhjsvctsjcehjbwrsscjgststcvgshstiwcciczgrercccsiivzctzhrrsgsegczvzseigzwctvsvcjrjsbebrjjzzitsvvehgtrvszzrrhjesbhrhijthhcrzihvrvewcjecbtrzsgigtervsszrzcbtvizwjjbzzhsivehirrshwcwvbebthcgwwjwbcszwersezbivzghvbgbjrejgctgcwgcesgiggwcgergreebtwjwbrzcvwhstcjzcjvgbttjwcbzzwsgwzevzsweiijigvvtzcvshbzieziwtbbhtrtgiwwitvgizjcsjtrvhhbhjrthtzigerbtigteegtiziitwrjibcgjcsevsshezjrrrehsgwbtztbhjswswrcieszbzvrterhwzbvrizbhsgsisvwizhgcisejvshjivebgcbvtitjbsbgrcweibivrbcrgztetztsrjrvibzecgvvgicszvrcivgsgtthchggczchcwhgtegbwttrwhgbcehgzzgtivtjvriiwvceewbrbebhzswswhirrzihitwbgswwhctrgwiwejwecwebcbrtvijsirchveizshjhszjcjjrtvesbrceevbwbjbtwvttciwhcgzzibectwrrshiwjjshwwvvjwvhschrijhvhzgwjbhscejizhtrjttggtbtvsbhsevbzijwtvhgvrbjrzvhsvbgwbzjhhiggihsirctsvwsibjbbtgbheccswrbhbbbvvcecwbzbegssretczjhztrbtcehbbcgjwcvtwvzjhvvtcrwhzbbsgwrsbwjsvwizghszieghjzhcstevgvchcihjrrrrhibeehgrvwhthsgtwtvzghczewcwtegrigbhbbhihjtgshchejgthvibjhescrtbvhctjgtihcthbghvizsgggervwetjrsjcztjthzcebvvtgcwwtjcgsvihrswszeccjirsvzsetjjvgithissvzjvtiwbcivhrsbihczehvvbcsjccrzbvsegsciwrevhgjecvbhcvgrtcreecgszbbwheiewccsthhbeiztjethjtscivwrerigwhcehgizgshjvvbeercigscgbbztbwbwwghrszstsesjihcijbcztgvjriigzwgziesjesgbjevgerhetswrjgvrzvbwegvczbwjszhwictiicjbgebhrehtwjwbjczrhwtczrcsicbvzssrcgezshvsrhbiicjtjtsjtwjczirgwgzjiejcgbesthectbwcgbwbhswscbjjhvjjzjicbstitehzthswjzgrgeetvcgviwsghzcwjtijhrhhhbwghsechwjiwrczwzjiwzisvgtjjhbevvvgjhtciggbgvtcgsejhcvjrszjcvvwzczchrrtcgjsegevrvcszgijigtjwhrbttjcjjzegswhestzvwwrtjgbwtrtrjjzvtwwhjsbgivwchithvsrsrreirvjjgzzsrsecrvssticzhhssrsbiijiwhzgsizeceivtgjsvjjsjcgvrbzgjhvbgthszbvvteeirjigvgjhizrhziscijczvzeevwtisgtzrrihwrhhvscrzrgwcrgetztrcceshvsgtswrbbgczgwrsvtwrecghiwrcgrbztszhgwhhejizgwtvsetwicebiswiesghzscsgbrbzjhjvewjrwrjicizjischietvzhzrsswegwehhvjwibzibzchhetihszjhgvirbjjszvwebszbsjwtibjghjbjrtzjhvwtrgsrwsvectjbsjizvviiibbivzziggcrigjhtrewrwesvvigviwirtcgcweebrbehezwrggjsvvitbgrwigbtwrbzebchciewzrczevbijszigrchjeitzsrivsbihshssvjjjgssvtrewgsbiisbhwwwbziezirsswsscrrvehvecetvsggvttwbgsgwissgvctibcgbsgsescstzzbbvzbbigjrrbgeigjgcbehvstivwhhhttvrbtejegggivjrsivtssiihhjecccbghherwczrctwzbsgrecztgvigrvibihcjirzsegjszgbgcbieshcjjizicstjeesvigcbrwbghzrezbbswwwvevbgziwrhbtetcbwcgrvevwwwbhiibcrjtcviwevhcigtjggswrczrrtctewhcbtvirsigtzhbirihhrczwshhhcviriczizccwbzisbcwrjevewwcbtwbzhizstbgsvvtbwjvhwwzrrttggvvvezgsrizecbcwgzivbzthvisecsvhsseibhjijzibsszrgsrvzswzercevtvzzwzriwvetbvbcvrrztgwsiewbzevhsjtzrtgshrvssszrbztvvzceigvgevvvvztrbtjzijhjbchijhibvvvwvvsccjhiiseivegtvsgwiseihzceererbhhzhvthvhezvbcrrwgeibcjwwvwiscrhrhvsgrirbvcwztwjsjshwjrhvwerzjwwgjtvhsbwcszcirisvvhvebvvgbtejtthewsbcbbtcigshribcisjttriebebcteirjtjjhihicijhhhvrishvhibwbzjiwzbctwghtcewiiitbebtbzbwvtecjecrtgsrhztcitheesvriiivjceiziiggzjjzrgisezcttchvssjgvicvzbhggjstwbitichgtjswvwbthzvvbtewresgwctcggszcjezhetwtzsbgijsigbrtrtrwihizsrejjbzjsgjjsrgwjgvisbsbwezcbhwbzivbjvjthvbscjbizgissrrjbvicwshezitihgigecwwjsjvghwrjtbjigicecghrecrzegjhrhjehsjetvthvgszrvrttvezcbbbstbvbehstjvsjrwjziccgcbewtssehtbbwsrjcvbsccsswsterwiwtrcgcicrejvjgzvsechbrhvihvvzrbwiitvwhwjjvbtceegeweczjhwjtteczrwhwjwzesttcgzecjrbirgbwhzvgrbgswvwtwcijzcccewcbecwbergwggwegvihsbhvhgzjwtswtwbrzhcssccvbsezzzgtgstscjwrhssrrjgzhrerccsevszjejtzsvjhiewzvbzthcjcjgzhebtijgetchzsttivgztijzrsceiszrthsibvbsvjtcggbwvcbvvzcwzbtjjeegczsvhitvwcjbgezggwjrgwevvvhivchhjbweezjjerbbscgjiwecjcjgwchzzbwjbhtczbsrejcvvgictczezzvrjighwgbchcchjiiishvbjzwtjthejrewijrizhitbvgeczhjhiistrczgejwibvrewwcchtvbsvttsiihczzwihgheszeicezwwjvhzghewzsbhcrsethzeiijsriihsgcgttvejwhzhscjvgjibsiejzzjvhsshgibtszhihgstbewjvsbehgzewcrbwjevjjhvshcswhvjgivzrstewirjbstcjczbigthgwejchesrvtgvrigvvbchzzgcbrgcebbsghwgwjjjgegevhzgzgzbicscgbezstcgtwcitgwevcitbrvetejribhhhiwzicsvcjibvsrjrrzijrzwchziezgjiwgsgvwstcwjwtsiswrvghhgztjrgvsrhstgrzwbvggwbzzwwggzzsizvrscszhtgghwicwcgbveicrgvgetvbeisjbsirsergwgwgiwhtvwsrhtejetisewhscvgsrwbeeevewjvwccrtzjzjbrrzjwribrvcecevvszjcgzzscijjgzitszrhjhbberteiehjvggcbtzgwebbrghhvzsrsbrwsjtwhvjjwhszgrgiehvvrwwjwhhbjewzrwervhrsriwsivrbbiiezgbgvvscrvsivjitgbtgergrihwberbvgceietgjrzbvtbrbzwztwezsgjsbvceetievcwjgbrcthewvisgwcvrztjhtzizetrijewrjgswersjsiwwtheibbsiegvewhziebrzsizjjvizirsebthcegsjwsbhbtjevjzjvirvzegbvrcsscesjchijcgteithvwcghbvjstwttttvzggjvijjescgigbhrjtbczcijczhighrgcgjbzbvrhgezzbjvzwhbvecebgjjretjbigcwtejcbjrscsjzzgjbizsgrjciwevrjswgtszvreirewzegvvresizcgitevetriwbcetwzcevrzwvhgghvgeihevhrrziithttrhiezjjttherrehwejrgezrgsebzvivreztigzzcbecgvbcwrivwerhtiiwsbtjjwvceivsjtzbirwibjjcjwvwhzgbihzcbzrvjjgztvwjtcjwbwtigshhjeccrswwsjzibcvjzcrggtsjihbbcerwieberzeijceeirswcebievehjgjhvbhbtjgjzgwsvzcjegisgjwwrwizhjwvtewrwgsjzgistzhgcvbzbgbrhzhbswigetejvwwhtieiwwtztcsbcgrtcihrtszercsvrhecvwwercvhevczibtjtwevvjhewigjgzgbhgivvezitrghjcwizzcvwjzssjbecwjsijeciiebiwbbgzhbigtbrwevwhgweizcceesgzrvjtjjwbbwsgcvcwbtvtrrizweewbhtchjjvvvcvzwvcivsrgttcibcrjggzbresihvbchssigbwjstvcsicbtgicbrjbvtwtbezrctbtjgetczcrztjbcsbshbvzivjbvihieesjbscivhtvgevehbcwhszisjsgjhsgccsierhcewwjcewegwibsbwgcsvvetzbjitcbrgvwseeezigzrhescshsvsittebvhhbrebitzwhzegegeewhgwzrwicrghwbhiirvtghtbgcwsithbjhzvtvbtrweegiscvhttrrhbrcgctvwziwsgbhcsgzjrbcejcwgwvjtwjswhszbstwszbghhgvijvcezrgiigczgghjchsthgvvebzjhhjbrbzrvcjzwvcvhbvwwbcwerzgwwjgzzgtzhhgiwwthhgzswzvjezeizcswswhczebgrjvwrhjtvhsvejbcshhssrjcejvrrewvezrvzsgthzerrgczisjwizbigjevriwwjhrhrzvhvgitietziecgtsbwbzebivhbjssgebcergwsjjicjbbejzstcvzhbwittzchisrewsvsstrezchrhwrctcwbtvbcstrsbswrwrtrjrwgizjsjcijsctgjgsbsbggtcgcebtzztwjgvvvshgvhbitwwjrthciszjswzsvhgbwvcezicrhseichtehveswzwvgeisgjzvsirzvbbrwjbbsresrhetbgjebrcghzjtzjtrzvetgjbiirieeghieiczvbcetvbwsevshzvrjjcesbgvchtsvjiwbvsevjjztwgbbjhvgvhhzjzieejtvrhciehwctchtiwwctgitszegtecgrjjczzwbcgbrtevbrhhwzvzgeszwvebbihjrrzhijzbeisbhszetvsiijjzttwshjjcvzsieeeriswisccshgrzreztcbjtebtsvgestsirtzwzbegszbvhebehihcjgbbzghgjsejhcvrzghjhvsgegvwvetzghbjtbezrbcrrhshcjbgtveejjwesthtzjzjjrijvjsctsejevrbestcirzbchzrgwstijbhezjsrhrhcbhtrwtcwcsrgwtbrttbwztibbrwzsgrvstzzzgrzbjwbchrjzrwrigsrsirtsecwbrjihzegetbvsrgbtssrgzgsgggetshezrszhhccwhigtbcigvthwiwgvcbirwgsbszzhwvrtsgbjwbwsbgzibjjtjiieisztgzijcvewzrzrwjjrzescbvititwgitztsgvijhbgwjvigwzebbeeebbstvirtibvjchihttjbcgsczziwbvircwcjchbzgtsztejtwzjgsbwcrvibczctgevcbehrbcjcczebzgicbhhizrvrvzvvzevseititjceistgbsstevjhzgzeijjcjszjiichejijshjgciihcrrvzitrevtihbrvsbbtszsgtrhrbvbzevghstsztzhrejzzgbtitrgbtiwzeczzrjirwcvcbwrewihtejewehjjgweijbtswihzhwghrsvhrzgvsjsgzscztttvtbrbghsvejzrwbetcebstbrgszergvseigrgsgzjwrzscwwrtiwcwtvjjbzwjgbhtecthjicrvsstwjvwszvwresvtwjrhjztgriztrvrhivbtjecezcgchtgsibbjbtttezbvjjsjvvvbtgecebhzhrriwjwzvvzebtwsciectetgwbrztijwwhhjrcigzbjviercwctvghvwcwzbzhcrihgszebbvrjziecvghseevzbcggwjbweshbzsictziwjhzbissvwwgwzbiiewrcjwbwrrjjetghbvwwsrhgzegttvbjbzecbwrjvgwzvgrevswhbrbrbhsewtwssirchzebcbrigrzzswjbtbsvgregirwicgwcrsshgiggsjhgjvbzwtgtjczrewgcrjhztvbihsejvgszbeebsbihezbrsgtgbbzbwewzrrsjirzzistebvjtgggvsitvejciejtzstcveseczbitwbzzgirvczhcvchicjhbwisezgeeczswzzhrwtcwizzcevwwvigzjvczevzgthjggvvttcgzjihwtvcwtvgjigszgbiszwbbzcgzgjwricbczhsviejwrhhvvrgzgihgvegzrbhjwgbcgvvtehhtebiggthcrchiteijvcvzjswwjbgvhcgcwvgrbsgerwregwirrheheciiirrizjcershwitetgwcchwrrgjhjrhzshhtcjjchvbswrthjgwtrszjsitiwbbzztzzchbtiiszzvrteweevwcwzcervbczsjggizwszhhgrejgjircjvgjtcctrcrcvhehtviecsbjggrivzrvbhihjchhhgsjigtihcgerwjijzszwrebigjiibvshecbjjterzwgzhwwjjvvjervtrjhhvhvbthesgbhshrzrsezgtegwerbehzcvtshehjeiwvvvztwgvijwgzrrircrbjjrcevwtcrwwwjviibhgjsjechjjvbhtbcthibzhzstizhzwbvwghzjjwchrijjhtvjgsigtirgwzeiteizwtccbtwjgcebsiibijwzictseihvzcwzcszcscjctrjgcjvjvvwseveszjvbegjjveecjwhvhwjjsrbgizbbgcwtghthzhjiiegrwjcitvzghbjsgvccvwjszwijwggtjhjzzjwrjtbiirgetvritgtwzjcwzwzbvbershgzzwgigcjczcrzigbibstrwcbzzszvwjirbvtejwihwervttcscvzibissrztwgijjebtwvzvisrzjzzgwvrgiszbijhwtcwesbibsbczccrizivihigssvzcrczvwtighvwsitwssvbeggjcjzrjgcvezshvttwbgvvgwrbwssizvjvjbjivgcwbrcvcesbesbwvvsjgihwiibrgjhcjrgbcbtehzhirtsghjswjtiveetbvzevtjebvvwrwgvwrvtzzswhtcezcsbsrthcwbbcwwtbggjiirbjcicrzwwstvcvressgjgwjcvjccvvvhewrzswvttwzbhvihcwisiwrjgcbjvezgtwgbbtjirwcbggvtzezvviveirwrbjgjisrcbsegwrwibzitebvjgztttieesceetvscbhrbcrhhttcvttgwcbticcbtvjvtrcjbsvtwhswweswijtizizwbjiwrhbhsgvbzbswwejbcztwhgwbrgiswgrrwjejegeijhicwtwccrjwsjicbthbcgzrjcwcczwsjtstbbwbjizbcgjtwthvesrzcirzvcrrbrvjbhzwrhrtwjcrgercezjzwbirvecszvwbvrvvigjhiccwtvwcrejebchrrizezzziwshwtwbrrthgjivrhcggvhtbisegvhbghtehehjrsirbgiievwcwvsgjihjhgvggieigwbjbwiesggrrgggwivgigtrwibjgtchvccrsbwshjwghtcwrchchrwcczvgbghbwcztcsegrgcttzrwtzwrgejshgrvjctirhbcswsijbzgwzereceehzjzzrrgwgggrjrcstszjebrewiissghzhbgrwgbhvcgjrecbecsjcsbrzjbsssrwcbvvvzcirjhehgseteressrtizseejjcbjcbbvrhrvvczcgjjssiwhtbzwhicswrhzwhisssrjthbjhtwhrtzjizswhtezcbrsgjegjzstgcrbwbcvjgrwcbihsjzrzgeihhrtttewzhwecvsicswzgwvtvvtbjtstwbrwvwjjirbjcsbwccvthethgbecbttcibrtvizbgvjzhebibterwzhwgibtszirtggcscwcetzgevvvrrgebvcwjihbjzhjswejtettvbsgcgijcgtvjgwsizcccwhcrcjbzsjjtcsbeetbezthgewhbjcewevtbhcejigcevhjwhzjbvzjbthvvbibhjwrtbjzwjiertbesetgzvvsccreirijgvehbibgewsvweshjvzzvgrjtstcszbvjwjsgvgezwrrvbjtthhswchbsbzzwhgghjbvsrhescwijihheshjbrisbcgjvwsirtvwsbjbcighhrcirhvcczrvzjhhhiiitbescirtccwejterhescvtjvvctzvjjvvggigtbschzgtrgbtvghetwigcjcvthcgzbzirirwvrshvgwhisjewgrwwjjshiwbsgshhbhjcwezishrcbgstibwzzjccbbswjrjzgrbtwizgbwhhbvivbgjgtbhzhtthewcjisbsrhjrtjzebisegwsjgbjjwizeetrrcvhvirhgggbthghbjirheheigtcbjihezcjhzjhwcvwwhhtbzrghtbbitvihhgjwitchzvsggthbwsvgcbrecwsshgihhjzesbvserbvwgsrzisritihhebwbztbzcrjjwhejgchcibbczgcgizwzvrsrtiizivwiecgszztgjtewcwizvbeiwizwhjsecgvrgrejrjbzztbzvtghrtbrrweestiszsvvrbhievvtzbhsrrhcjcsczvivghjcbtbjzwrbhtrejiezjrjhsbjrviisbbvscitchjsewvgiwghswjirwgirztjiirgcwrhsirtrrhgtwshzvevsjvcjcgcszccsjizservrtrctjrbeeehwiwiwesjgztgvirtsegiecvvhbieshihtehghzeiwvvvhwsczihctrhbrstjbzebbhwtrhicvbrzizcgcetjzzbhjgibrghjszrgsrietzsgrwsstvjetesjztzzctctcbigbejrzrsjctighsbsvvwwgwwvtizchzvbewetbwhwvtvjicircrcthihvgtsvjhrvwihbtgbtgwjghgibbhihiwvbzerhgewggcvetjgewizhrbjgrhggggsvzvgjcigejtswctzjtwhgicccjgchwztsbjvvhjvvgvzvhiswwvrezwjiizzjhrsiwwtiwbrcsrvvczcsevhsgbthzgjrzhcszehiwegtgjhsrvcsbigjzstwshwchehvzbztgjjtsztegwrevbjhisbwwiirccvhiregeiwteevvgrbrwetgzjzcgethetjgeibzggizzgghiizcwcjhjcgwigrgrtebhhchcciibzitrszbjtzwtjcvietszjghsrzestzvbzsvctwzchhrjigtjceczevjigzwrthhjvishgscvjvbgjshwhhieszsrzzjtvtrsgccrzzztjvrchtctjzezwsiwssccsgrwrtvbtjvgzhzzvccrtveigcjihjbeizrtwthcrcwewsijhjsvrjbrbzsjbhziwezseivhrhcsjgzehtsrrzwccegijvivisbtgwbeitwhsjscviwzrwrgbbwzsvzvjjcczvvbjwwtecstsvrvsbiswgcgjvwteeizwrhhccvrsgbtgzcgbiczbejtjibvizghgissviivbbjvvsieeheczhzthivsvwvrbiehtwgtstcjjcscwjersrettwzszhtbgsrebwvrzhjsbbwwegcvjejjtrgjigzcbibitsetczigvgcsthstghtigbhcvwcszcrjgzzizvwbcieiswbwcrrtzvrribgirsezijijssieigwbhhrsbitggbehrzhgrwthwztzwwtzchivcreeiitzjsrjwwztrtbstirheeghjsvsrhwgvvbzgibtgzvwtvzvtzczcsjwcrbvcbjcwwhchhwwgztsivwesgbbgihrhzvvzsrwtgtirhrstjrbhvsjrzwvjzcwbzeejccbtcwtrczggtttswhzhtgjjzcirwsjtcshsjvcvtegcvbrrzbhstgrbcszrgtggeivhsztzcwzztbcvcrvigvgveswvbzwbcbvtwzegbrtevgsizzegbizjcisrgjttvgbvgivrcejctswzbggtcbccewigzjgbgrveebjvjczeeziweegzghessibwvwbttttvvztwgwcbhsgebbcwtzvvizjhvisjrthgwwbcwijweizrigwbbtejshvgbvbecrrgwsegthrtbjhihwigsrrwwiwtrrgebijzrthewtgzicjwgjgwieveejgvzbrjgvwbbecsjctvzbzhrzjgsszhwrrsjiwrezrchhbhhsscwhjitgzbecvvveeivrbercghvvihsizzwscwzstetbrjhcrrwtvtjsewbevjbtcsirwbwzewzbhhjbreivvgjiszvjvwwtgwhegthcgrvgicbejshibjgwwcectwetrwsihwhwhzztbbjhgeziwgstjerhzhctewjihhebtvtihcbjwtzbezisghhcztrvjiswshjtrbjwvebbhrhbczcjcgveivciewssreerrwszgrebbvvghrejsbegjcicrehjrccgjtghicrzegesvwrzwzibjrjzctgjbzghvgzghceebwgsrrhghteecriirwhvcrweshvwtbvwrhjgstghzvberswtgzrrvetzbtisvbgitczjvzgbzhrsehbjbreiscbwjzrvvizrjbgjsjjszjhvwzbwbgiszsghjgvbjczvctwhrvtzzcrhcbbhsbtbstsshjibghjwvjhhevhzrwgzhhigbbtetswzvsbgiwicrszeievggivgtezihcwistvzstijtctcgshzwecwghbrjttjibiestiithjzticebeihvgsvsezggbzsiizeecwrzwzwtcsshwtwtrzjehecwwsjtwggwbghieztcrstvwwcwvggjbsgsgbjgcesweigsrcsjsehiwsttzscvvtwvzcrbjcecvwwtiiwtscgzrvwibcztjctvrcctgvcgthiwsrrhcbwvrcbbsjwsetvszrhrvgghczwjswjwgzzcwhsitzgeectgiceergehbcrtigwjigzjjijvbsewcbgibwgrgegwziwtwzgbvstvezsrrcbhgvrrriegcwbishbhchtsjcczjsgcewhehcebrjschwthhetgsijiczccbsgehsrhwjrsjbeizrrjwtsebvzjevhwehzhwgwjzewjrihbvjjsrgbhvhwbevsvbtthvggveevsegvjzrzsezsgjwewvgijjbthtsrjwhevjwghzwwewvzjtwjjzvbvhbwtgjrwhsiteggvgthrzgseiwrwtbvecbbjciegzjbehtcjgchicgjhtcvtjcswrsgscicvbtcwzgrribvrwhsggjcwrbrcthetwbicrrtgzrerwrwezesezgjvcrgcgsgvswwvgjghrwjztvzjbhcshwevzreecihwrvgscwewzzgzhgggrhrcbjcihhizzbrcwtrieesjhbiwbzgtbwhrtjehiesbzszgccsrwjzsbczssevtwwejjsvvhcwvejhvjbbrrtejsjsvvbvvrezvesbiizetccszjtvvgchwjwrcbggzrbtrjchttszccjetjgzbjhvjrthrhhczijrrgwviibsbehgcbcbwrbziwiebvvbhrbejszhgsrhvrrgewbvvveejivwwjjhbsrhrwhbsjtbzjrbwwrwwvcsrzvwwtghjrrbvwjvgcjseteeseggbcjtzrwghwcrhwivistjjgtgwivsrviswcjjwvhvirtezrrsciibiwziwsvjwtgwttrwisecwzwzjcjhjzjtgbhbcitbejhgwwjiteejzwrjihjzrjwiehtttziwzzbwbsviswictjbijsvwsjbhggeghjsegrzttctzjvbiiejrcvgsvejtgvrsshcwjtjwchzbzbvreccgsibsbijbeshsihjbhhhwctcwtjgehcrihrctgijwsbszrwjgvhzvgizizthrcicrzwgtvvbswzwgiervhtrjscswgjbztgrzbshzwvcjesrhhcrtgicrbczewsirvvbcrrvvvviwbegtsbzwjrwrtchgritectcbecihvtztriwwbwrtzvbztjwzgzjghrbrbhrzzsigiwgszcbrwejzjswwegiirwrtcgzhtcsgizgvctirshscisgsicerszvewijtttczcvsberirgjrrcsgvgbzetvwbzwgzhbghjzgjiegivzrbbrhhereshjtsihwjzgtrgvgvbgwtcvsjwhsgzctwsjecggvrhvwhvcsetbehbehtgbrrtrcsvzeswbtjwwhrchbgjccgrewhwgejewwztrebtjibirtgibcjejstcjritrsvieejthijjvhegigisbvggvittrjtziszihjgwwrzhzgrcccwvjwvhbvevzzhjrthcwsswhjivzitjbvezbzhhshzscbgzzccribebwhjhbctvwhehtthtsiwbswcjbzbshvretbtsbsjwrvsjcstbsicvetebbgsewjzjsgvgsgjtigwwgzweishhgzbgtwhttvvrjzvhstcivgzzerhjjzhjgiwibjtewsihcbgsrhtvrgczhbgtrghwbiizswjviwthcwechwzssrtwtrthzvivetccegssjbswgtvjrsehjzzztwgcthtsgvrivbezeiirjehvwhjzjvczbccretchjewttcvgctibwsibtctrcercetzthvbwrhrsgvtevhvhtcvishbicivhwiesjvizihiwrwttrscizhbrcbwwgtcbhvswgbrghgvzvitgzzzztbcsvwhwzjzjhseztgtshcztcvreirvgzzcseviiczbrchvsbeecechtgjjwjwwgjhgvervvtresticshiscrirzwwiwcgwttecgrrgicgsbvhbsjvwbewseieshzrzhjizbzgijjvtbrzvieihsrbcrrebiiezcwivcwtvtghrwzjweisjirrtgzbzwgcisththvbtwirvzcvzzcwhbveitvizgjrjijrethctgwtbhgttcsjhjjrgttszthhrjrbcwhzwthbcbwbzbvvwgghwwgecshvzszzwjrzvzvterzzbvejrjziszevsbscegrtsszsrbiegjvzwswgccgetbijgewbesjsrjhjvtgzetrzjhbhrttbjerwiegbjjcbbezjiiicsrszjgirjshzhrwrwberbbcswebhrwjrstigiegvrjbgiswszcisssibjhhvcshcjrscveszhhjebgezwsrzvbcvzgshrrvreggiztctgwzzbvzzvbrjwtvjhijbvvhirswzsbrrvthwthcshgvvhetzgsirzcjbvrrrgggztcsebbvesewibgjhjhjshggrbhzcchzhechigrcgwcsggebhjbgzswtwctgjregitgzithsscegjwgcrhigjjbbgwhrcbcbjbivvrittiwisbgwtivicwtcitrchvebetiezhesgjciwtehhwzvctgeshscwsibttjgrhziicvsgetiwbbhcivhcwrrvzvjswchviztbbjwewerwgewbvbwrctjtgbhwgrjiwzcbvzsbtvitcrbzbrrtevizcvczswbwrrteggvhshhzjvvwcetzesjbzvjwezvjtrehcjggsvbjiccvvszhtcvbschssbezgjsvsgetrjrbribcwwbrszssceejsitvvbejjjcgzzsbjishiibzrcjhwiectvrhsbrcrjhsecvwtsjergbscvchcrethvievhvsgccicectbecrbgiibzzbiwsrwtgzrbbwwgijtwzhrswvzzscwsvzhiesrwzgeshvtrrhbbeijrejgjibgcgtvegzwbveesthchbgbewvjvwsvgjehstiejezggcvcesciwjvbtevjewcjjzwsvjszzjgizgtbhrjbhtghhhwbjzteichjwbbstgrbsjwcgeweczttbsrecwezrwcbwbvheitbesjgcejwribewejvzrhhicbtzzbsrchjieeecszsibwhweeegircrrvghvweightihtzgjhswswgstwrcbbgbiervhswiiiscvsgzwshghcjiivsztibevicbhvircvbrzzjhejebggwbezciirjsbtbgvjwreevzgwiswwicgzzzicstbvctjvtzsecrzbitjjstbzvhzztzbstbwbhzbiscetvgirevvigiwhshvttcbgivcsizjzgvzzstzrctiwwshzcwhjzvewshgjswhzihitggjzwvjcvczctrcrrbrighcvzcreihztetihwcjbwevcivwcrsrtbjerehrtsszztrvcbctsebrtvstcttjzisrjriivwctitvzegvbegbbrjctethzthrbitezhrrcwjcgijwhrcjhrzttegeiscgershcbjrtthegiwgerwgscjtcccieebbvjezrzcjgiwsbjzhsvibjrhzvhtcewgtwijhjrsbcsrbbserbrecvztrwzishvtcvtgccgstrvrjzswzzvevijvchhggbiwwzriegjbewiveriverzzvwswjwjhjjwhgtcsssejhjbcbtejvggbcetgwzvebsizcggtbswzjijzszgcejtzbicezgeivvrervhzhiwbbjjgrjzgeiszjrtszzsrtehrzbrecjwwsetieewsgzevihjsivwjhtgbzicztitjetsevbigwwvhgvzcghjsgtjiwvriscbbsgsewhwscgchihhbweiwwcjbzjwvrrbhezrirwgtvththizrwzttetbtcbthrzzcweibgbisetwgjhgszicbehezbbhseziesscgbesscthwczrjigsshwhgigvsirsweswrhhecvhcbshgczjzriwrcjehihbjwcjccehzsssctwjcwejtsbvcgbwwjvrzgcthjzivvbbzzcihwisvvwvcrwcbbscbrvtbetbhvcigvcrcjchwbvtccrszrtgsrwgstzszbcjrghsrzjeeiigzzbjgcwczgsjirggvhhzbevsgzvvsgbbgrrczwvbeizbbbgtwsrggehsbscizwbbciertrerweitzsrwtehtestcwwwwehebhvjgecicjjjtzgetzswbvvvcisicbwtgzrvwriherghesbizccccwwrjjisegbrwjiztsztcehhzgttszgrhzgwszwivcsghjrrhjzchrhbzvbtgzhevesccgjvhczgwrbevgbvbreczggebsvthrvtrwrwvwhhjwesgvhhehstwshiiwbzbhgegterszjechztzvhbvhiijhbgetgrstwibvvsrrjzhiwwhttcsetrsetrrggwtwvvjbirbsciziiscssiewisrcshjtgwszbrrzevwetihetvijzjcsgsbvvwvrijwtggwihsvrjtjwiggcgjjhbciiwzherbbtthezirsjjjbecrzvjgghttwggrhwrrjejbgithhgjtstsicztjsvggzceibebrtevcszjbwhesbjsezvehrizzzhsrsrhwegwiewzwsvwbtczwtgetswgiviwzjcrrzzczgtwzhhvsciehhejtgctvjbwrtzwcvwtjzeigcebgtcevrzwbiszrzgjbgeijcszceezgbjvegejghvgjtceiwijchjizchviwscigizitzvrtwbcwvwjvbbsvhhrjzwwiwvvzrvecvjiieigiiezcthrztzjhvbjzzezizbibhvwejtzzweijgzgecheveigwhhzvbgeiwsjtczsgcscccewebzerjrshvrbztwcjtiswhbhrcgjejvtvgchtcswiscbewrhrcbwwwjgbwjjjshgizhjerbrwjbbcrhctvwhhrsweehghthethzwwvsbvjwcvzvwtibsbbwscbijgsibjzwzcsvbvjtcbebhvzcwvrrzhscsvritsetihsgjwggzwzjtwsebwvtetsrcgsrhzcttbtghhsszhvhzezrbtcczwzbbwstwrecisiwsvrvjwttcjzegjggcrtjrwewsvztvwtitrbwhihgrjtzrtggvhhhzczswbczrghctiejerswcvcvgzvjhcjriwcbwzgszivztwzegzvhiezzhehththwzizteewjbjstwztscbewwrzesestthjtcgrwwvgjgjzerrbbsgjtvwetwztjhcgwzggtshzjbvbcgghvwvswbbwwizvjgsrtsrscjbjgetrzjbghitjbgzczsvejwbsrwwvhzzgbigcwstvevijzgisicsirwgehrzerhgsebwegzegcvistcczwrgbbjvzhsvjtgcbgvgtiviwzghwscgzcrwewtzrgvvztvwwhwhsczbivhrijhrrgcbzrcrbijvchhbsjzvsejzgrestbhbeweivswzttssesrthhscjisgbegcsbhitirgsbgtrhrgcshbvrzcgzsriwrvbezwtheibwjtiwjhcjjcbwsrvwtvwehtbwecscbwwivircshtehchejzhshhjeswihievzhzjecgettizccjrejgetcbjrhtizhztgsihbttjztvrvttstvejczgstghbhteehgcvistcvwewzwczvwettzzsrwbcsijtvghvicwrivwvhssjjzhstetszvrshcrjvrhsszttjcsbrjbcivsgebbgzgttgisvrctwsiwtieijtetcrjeireecejvzhsvcviesgzeejergwsjvbzjievbjvetvhitssbvzbbtztesgzbebhjzhbehebsersvcviecsecbrjwrchtcechegcbwseithtiivcsteszszvrghjcwizggjtcezwegzzwziigvjggrjvczszzjjvitbsgwvvtethscgehcjevbggehbzrtrtcewwsrgtbghehzccgjgvtscgcwzzrvwvwrggjvwihcizesvsisszzzbvetzgsrjsjewzvbbzggrjbvbehevhrjsevhicvberbbibwhcbciribrrwrhigsbssisjiwcbjhgzvctwzbewtsvshzwgberzietsecjvhizthssbgrvrjssezggwievhjwgjvtczvjgzhiwbiigirshgtgtbcswzwijwisiirjrierhjrtcvijizwhccrswviwrbhcwjewizjwwciccezstsbjhbwhzbctwecezthtvriebtwbsccczsjwwzrhhzsirgjjecjvcjthiscjtzvebwzgcthvrehwejetcshzwrvgewesjggsizrtrziwzvbvehgwhhtrtcrebchgebrsjzcjbjjjjhssczhrsiebtsvzgevithwzsivcjsggwgrcetbiitsrbvwjsczhrvwwgrhbwhtiezgricweesgegjwcjtsehsetrbwvhhbcrzcshthvbgwsgrrjvwrzctwcvbriccwsvzhtbvccerhjejzgeggsewibtcrtcvcrhtvwzhrgbjjzezghhiircetvzwjgzgtwjjgcisbcbrztisbrjewzibjbrggvicceshzgcbibihswsbzhhcizrwihsvhceztshjzisrjiwchivicjbwwjhwcrgivcrvbibvtgshzsiibvwvsjzrsirgbvwghrviircwvsthsvvrhbgvbchecbwewjcwhjswevbejwcgwisvrvthbvvhsesresjeeewsehwgrbbbggwceihsezszttbgbjjwsztvvccibjwvgbijstrchbvccsbrzgwhgwbvhjbsssjhrtgwssvwjbjzwtzhszwvhgvrjibhvrtgiesrwsrgjgsibirvjgzhvjvjrsjwigwzecwcrbbwrscebehiztrttbzzsbgbvzthbhrghjjbrjzhwhjizhchsgicbirsgcbvbzswhcbizijhvbtesttettsrtrewtbwwzivjbzzzzvtvbwzrtbeebjhbgjirccgbjsrtvicvvribhrrbjcjeriirczthrewsbzegcczsevgzhbzibvgrswbjezsecrvgcthvgjttiejehhrgzrittwgrijssvirzjribjcghetzibzjvbvrzrrhwzhbtejgwzgwrchzzjbszgigvgjbthvbsejwwcvbeizhtivsrwjzwjbwwzteeczjghhgghthgiwtgrevtbrhsgttivbghgbwcsbwzjcgwrcjsvsvcgehvbsrejrswhhttbjgsiersesceigvbrrrihwziswsretbvhezghehzehsibertghvwhgzhsczzzghjhgzhwvbjgvwiizcrbjchgbsbscvhcbischzgctrhsgcgiiijjcgsgrsrssevccvthzzjwjztjvviwbiiebzchjvjwwwbrhrvhghhigtcsgsbvjhegbrchzzgjibthbbcetgggejibggcszijzjhierwvwzvrttggtsevitgvbbcwrszzzvsbcisbzgzsvrbzwwtzjjjrzzsehzebjirwhizetjcbgbgitcihchcehgzzciweghrihvbceejvzwrssbbihcsertshvbrrjwchhvwrgssrijbcibjwhgcczczchwhjcgjtgbciwrizhzswcccrcgbsevivtstzsswbrbzcijtzgetjiivwjwrrtcehbihcejhbjstjrtthhbhhjvtiwzgzevvbrrtwettzcjhigizcezjigchijjggwrgwczcbjebivztbvjgvcwgrejcgvjcbitrchrcczwwegbeezbssecttwevjchwcirjsiwjceziewrjjwrgswsjtbsriwwwjrwctzvvzwsrbjwsrwtvszigwjweevjegwihevvtsgtcibjebghetechizssjvisibgjgrigtisbvcsjtcbtzwgvbzegvjjwhjbsbwbcrggbghijstcghsezvsvcrjsigzgtbhjibztezvbrhvjzrgwiigrwjztrehsvreehhirjgrctjcjzrghgghizzczwzthccttjizhzrbbwtsgijshcggebvjrhwttvwzcwgcijhjzvwgrhevvvgejbrbejjsevjjhtwwvjvhtseiejjegsewhitebjtstsjbjtzjribjhbcegezjtvwvgwvrggrswissehhtvchhswtjvcevczezeietrjjegrhbjvccrisjrgjwvctjbtcggewvsbhzjjtbejrhrrjssctvrsssbvchezcjzwrvzeevjewssccvzhzchbivtjcgeiitzejciscctstwbrhhecrzbrhgrwgbizzejzvjtzcwtjjiwtscsvtgbgsgctsbbwirigvvhcjgcgrcbjhwwtgziszzegvhbteiebwtwseviriztjcriwszhbvzwzihtzzjithjtvtiighgrtwezgswwsvtgvicbicwehwbszrehstbgbvschvjjhgsizrsjhzsrijwgbbbjwbgregwttvbcchtwjtiwigwhjtshbtcrejcijzzbvhrzztirwsijreejwsizgvjjvevjbrzbbjcgizjvbjvhtbehvveehrezwgvjisjwezzbjsticzvvzwwgzsrgerwhebvzztgtriicrviegrcwrechcehrvjgtbwiersiijzcgcreegrvhbgtsjgbihbzvsghsgzcivjhzwsjjiibewgtztcizwhhigzvehihztcvjbhthbhscstscccvhsivbsezjgwrcczhrgbjetjirbgwrwczsvwrtitgzwvgrgscejvgzbttchezgrbzigjbhsvibggjwibctvsscbvteghshewsbswesztvgiwirvcscswjvvzzsviizjcjbzbthtjzhtzzzwbciigshsitscrewwzssticbtrvsrieiezisrgrwtiijreciibhihscvihjrvesjwwhztztrcjweigewttgcwwchzztgwwiicgztjvtiwvjwrizzsgiwhrzrbcjwwcvwibvgcgbcjbsbtsbevsgwicghhbrejggbjwrzcggtevcztsjehgwttrzbzttthzezgjieeichhzvvjzrvezcwcwcwjwctjrjweciwisrivijegrwzcwbwzbswrirwcrrvvieswwjgjsigwvvcwcjjjgsivegscchwgizcbhhzvgibtbjiwzbzrcbrjjishggrsgsvhgcwgvgectbcrczebjvzsvcserisjebjrcwtetecjicgwihjhczrsjwhsthhvergjhsejjrsvvcgrvhgbricrigjgsehjwjrzbvvetzircwbighzwhctzwcgjwtiresrjibcstrbgwzhbethzgevesrsgrircvvggvvwiescswhjjibgttvzjgbwvgsthbeieehsbjthhcwcihhjecejeerzeiziirgwrzszcccwcshzschrgjejghhhcszgwtcvsvtcbtewrsccjvegjrcejgrzrgezjjzsgeehzbcbvwhebbtcswrtbrvvhiectevichbtcszjzwrchgvtzwrbvwsttsivhcbczbsjccizerhggcwrjvcrtjjrgcwbhzgghghggzbthhjsrttcghtgcitgetgtvrvczbgbiissthvhwcibgwvgjcvcbztrhgccgvsjigvwjgvvgrirzwwwvgbbzhsejwhcbcbhgjijrbsvwtthwzcijsjhgizsivrtgwggtcweitcztzrrrgieegchbcrhvcerzghtezbibrrsbcbcrgjsgghbizzrhgewzhrrrjtrjttrzzcbzhbbjvvjevrzbewrrtrbtwecgvivrcithvrehhbshzwcgeizctcitwtzchwszcjvhbsssvgevzbvgsbiihsrvrbetjtztwzbvzvgejbjsghgzrczhjjjttbbjzstjgizbzjirbcwewbwthrgjgrvgtjgzthbbhshgrgrijzjrwbtsizecjtzzetighiwwcewgswzcjgvtghhewitscvwbibtigcrjjvbwjigzetjbjwzeiztzeejbegtbrstjbirszbtwbgzsiccgeeteizzgeeiibgcievjjhcjwzshtcvvzrbrzivtzvtbscirewwcgivjjrwgvhshsbvzhbsetzwereecwcrzigbebcjhbsggbvirzwrigrrrchiswbvbzveeewcgbghttivcccgizcbzhwwjjrjiwwhctszitcwwwjcbbretsevzhtsvireitejiwbzthvjbgwwitrvrhcciweetiwhzzijvigwsbrsvjtvczcstjghivttbtserijesijvctebsrwjcrshivivesjgssbrvrbssivirwgrttcbwwwiibtjbhchvgrejbihsvwzbhcheivhiisjsriejtcssrvvrtcbvbbbcetwwrvjshrjcicvesirtccjjezshsbzwjrchgtibbbigbbzizsbgtrzghvcjveiergtvrswbjbwjrjejjwcshighrrwsrgiwhejjtzjzzwtzsbtgtvccrggbrczsebjwjwhscvzvvvjecwvevvhwbteezhijijjrrjwjbbiwhwzrzwcrhjwhjbveewcchwtvhcgegztzzbizjjwztiswbhbwbsivtgvjssjwvhwthsgvgtrvrtbehstgvvctrvjbrhwzzrbejwezshcirtwrrtwhsvewwsbhcivvrvbezbccgsvcecbwghzzrhcwhzhgewecgtjjsejrtccvjisshwizivbhevtgihbcrzzhgjbjshsezwgvigbscjitiithwcgtgrvitctzirsihzwhrzwtggbvetzbhreztizrgzsvgbbtrjivtzcivvvbsscejhbggihhvrwjbchgwiscgrhtebwzzsgrzbrhcrsibegjgrhbgswigisgctbjzhrcczsribzreciscjbthjewtbttjsswehggsjwirjbejrvcihweiijvibswsvhsiezirrwbsbcgtgzjwgccghsvwwvhecwhsibhrwwejeebgtbrvzcjbwitbgshjzrrhzvievrbbsrwbsicgvtbrwcecthtwhrzjjrbgitceggtigwhvjwivrbihhgwgbrizcrvbtwwibviesvsihtseecejgchtisgccbijwiwiisrsctctjzvztswjhbcieergbwcrsweihtviwijttwccsgvbtgbjgbibsrszsigigiiszewbsetbcrbgvzbrschrbsiigvtbbwbtzhthvcictvtwgceisiicrvsiieshwbjihvteigijwssittzbebthczrgwgjireggjsvvgzetvswhececzgwrhtwbrcsjhgweivtzrbsvsjsezshrhgstsizibjhbzbzrgwwswrczzvwevtwsescivsicwbrcewizzctjvsewrtsecijjghittgzswwsebrhcegcjhwzeiiswgtrciwrzviccjjrwjjbrsgbwtrtjetgwhrjtsshvhvvzcsztgwsebjtwrgcttbrwgivsevtjtvwirbsigjhhhtcejvgeisbrrsrcesceiztscsswejrghsevhcbgstgwvwghegrzwjgehiewevvvzjestvhrsrctcevgvztircistwhczbcjevbrwhhhithtstszrwvbvsrhtczhsztswjerbvhwthhzzciishwghrveerghshtjhbgiizhjjejscgbtjcwbecgetzetzszieteercsewzihvrizibrvszgsithtjcvrjsgjzesbvizisehtcwsrctzstgcsszvcbgrzitwcwtbstrrbshjcsgtcrhtgsberviijstsrzsigvgewzigjvcejsvcrejtcjtittzriwwretijssjhtgzzwewsbwcjwhivzvcvrijvibwshsbbwcjsttcjztighhsveztrwsrgzsczvcehzebtvczczrgbbbsitrwcszhriiewtjbjzbhhgbcrbjrwhihriviegesjvrrgssiicebzzezbejrcijbcctesighgicsigbvhzcssrswvstsreevtveitvgcrtzwreirtwsvbgcvtvetsggerhrgwicebzjgbhjrtsrzizzrbrbbvzvszrbjswwigzzcjcbrictzvsvswhstwhvrjrcbbvvzijwtgiizeshesezevivbszjbjieevczbvesrhjbrjihhszisbccwgewzvchbiiwjtrjrtttjtsgscstiiweewsbzgcwjjvztvszzjzeijtzbgzwzbejhbgwrgsbsjzeecigiigeccwtwghijczjczsrbjwsccvitgettehgvsshhhriteevgstrvhhttcebrjceirhesbbbtgcbghjthcsehcvvrscivvtigbizbhgezgtricirbrrrzwhwzvggethigscjvwrcsrjbbrwiijzseibcwjzicjtgbwvtgizbitjrhzhvrcszgbbtztwwihwtvecbwchwthgihhjjibjzticbvebhtsijsjgzbhsweechrstttgzistjwbswwjtgwjbgzjtgcwhgggizzjjvbgbceiceghiihsvwhzrzrztrjvvbsgwvghzbwevivwwizcszrrihvbwczjcwzcvrctgivvrgcvrhbwerebirvevtcrvgcrbcwecjiszcwtswhgebczwhiwchvshjsrrtizzivhgrwrehhhhrwbhtwrzbrecjseireihjwgtggecjgivwvcvrvivsrtigvrccsshgjhsthswggttrbhewwebhzvchesvhrvzrivhgcrgiwsvrtrhjwscjwrjwhjiztwrzeheghegjejgseszrvccrbbtewjvwrzrjjrerwjcjrvviwrsshvrtrsithshtzvtvjgbigbsjzjeegbrgiesbvhbghrcjhcrgbjtzbcbehehbrwgsjeevwbhjjjzsriviizbirwgscirzsghgwtjjtbjhhisrswvegzjtetwbhvvvjzghvjieijwschrtitehvrheigtttsjbvethijzthzwseisigwseswgvrrcswzjvvzbswsrivcrttgezgwitcetrbrrvwttbezvvzgivejtgzsssjtjihhjvsrrzzhjbtjrrivwbjitzzsjzztzbhztzwtvgieevvhgvezzwvisgeiswsewshvzcgjiihgcrcvjhhigrevzgiegsetsszsgihciswbgrrricgzesbvvzbwrtgwssiggswgesvezhgrbbsghwrjwzcccvhgjwgzrwtjwriievihessheezsrvwcvvjttctzewwehsszrhczjbsbhtvbjsjwzrbrebcejbzwrrhvgvjcesrreggzwzcjsrjiizgjetiejbehschjizrhigeicjiicswzibsbzsrbetecvijrhbstvihgresejccterzvrcegtzvzcbtbghrbsvbtbzebzwhzgzsbizggrrcwjbieiihjrzrserhjiwejhiightrewjhecvrtvjjwbsezbrzcjzvvwszetscrevggcsirzrbcsrrizhgwrvjgsctittivwjweeievsrrbveihvcwchczhcisvjzcvvhbizctbhrgvggghwrgbvteczijisjewsswbhtvtbvvrshtierhcbrbtjezzwcbbestcsetitwwtzgtjvgsgietizijrhbhiiztezhehgeezeehesjwvstbhsiebjvwwtejzvjcbihtirczeejisiegsjzhcrgwsbswwwwibrsbrsjegizjsbwrcjvvtzgbhzecgggwtstgbsittcvjsewevshtcrejchtvirctvbehttretctehhgjezeztizwszgvwgvhzrwchjitvjbreehjjgsjzhtrbtwtgcbvwjcrbtjtiveizgirvegbijcichwcjzrzrtsitrsiwessvsghezvbwjwrgezjzbebgsjrbszsbrtvbrjsgirgrgjbwhvvtbsvgzvtbwhcwcbehtzbwtvzghbrhbrjzhtrebrjtrzjjhvhbwtswhwcjzrzbbcgzgrirssbecevrijervvwitcewbbcccehsevwggvwttcbrsicvhbitzwetbtsttvsvzstbvttwgrgjzccshvvjwherzetwvitzrwbihctestvvjescswbjgctgtzervwgcjztcbviswzjzhiswzjwgvwihbttjwvrwtrcgzzjwvjwejtcwzcwgerwibgisjbiistehjsgezigrzbhibvcjjcwzwiecicrebjcrseigtghgttzzhswgicievwthrehigebbswcbbwewizeihghrreeriwwtebirjsecbejzbbcsvtrvvvezicbhszhvjercgjgcjrccghibjegwhrwssrctrehthiizzttcgicewhhvshicvhscebjzssbhzchewrewhrrezhzgecstreriighgjbrbtswbjigghgtjwwvtcihiezehbsrjgjecwjstibihhihzwwrtvisrhwsvrbszsivivrjvhitshiievcczzrijhcjjizvtiecwhgzjjzjgtwzwrhssgjscsjwiwibjsecthssitctbjiebgtcibjgczwgthivtewgrhwevchishhegzthwcvvwecejtiivbicerccbhbczjggtzhihcvjbzzcgcbthbsgbssjrehvherhzivhcrtgvehetjjtjzzgrrzzzjhvcjvveccvtcczrvcwestewvgczrvwtsgjsbstbzeterjsvtereshgebzhchbwghhthjvvstbrchwbbegtesejzrhshbjrszticbsjtjhwetwzwiivtjhiwrgewjgrzwcsrzsszgjreivesbzgswwvhhrihircvhtwwebgrgiihhgsgzrwvrgwctgwrbwgrhvgwwtjszetziwshgrwesgerjzrgcwvrjijizghwthibtrgeijciictzrggizijczgcezhjtrshrcebrgrbhzbvztwrziibvvtjbwsvjhrzswseewrhcssigtsbbjvrsjzseiijjbsitjiejsgevejbscjjrijebticiigwwweizhisjbebwwsssgttvhhrzczehjswwetwewwbwvrtrsswhggtzijwbsirezjwejtcettziwjjjshrgebiscwjwzsvjgsrtizrhrwvzszzjjtihjgitercstghzsjzgiesiijwzichhhivsczeijhtvzthiibetbstzcrvjiizbvjjtteizbewjrjvrivhvhssecegecvrvgcviwwvhggzvtsjrchwvjitvcgjvsiijgsvvztssvszwjsvietizcczsicesvvssigrhtvbvsrwiittbzizwsrtjetehcrwzirwsw";
            string s2 = "alflkudnnayylualdlqlklyofomfoooqmnmuakdfxqxlkafxopolmaxukuopkqqpllafdpudlknkfdmpqnodkflnudxdkpdylyqkqayyfuqayxfaoxyynflfaqyouypmxadqqnfnlmxfpunnuodnyqoaddpflynfkyfxdqymmxoxlpxfqomyyayylfunxlnxomoyqoqnkpuaypmaqqflmaxmnmnxfkypqaayluakokuoxqnlyopfoupdquoyfxupdfklmdynflxmkouqdlydxxonpmopqfuquyqufkodopkpaqlxoopoloafqpxopfaaddaylxdxmffaymllmulauolkopouummfflxqondaxuqonxdploquffqddxfdknkxnyqxpxxmnnxpanxuxlnupynykfnppdoouuonunlofudxnnloxkamnnxdoaknmopquanfkmpqlmmlxlpkuylfdpypxdxpnypnpdmxfmdxqadnyyuymupdfkxpaaakqloodkdluddkmadknnadlpmulyunfokddnoxyuymnaukdyupmupudydmxoxodppfqualufqxmxxodknulkmmmyfknfxyuufaopkpmoqlxdmlpdomlxdaqnaxpoyxpuokudqfdpnduxfkdaxmkydpmolafumodluumlkuapxuuaappfkfkykqamkdfaokayoypokquddxkddlqknolqommadolpopuuukqndnxpnfnmdqoopqmfdmxlypqlxdfxmqynmdkpppfpmfdadpnxnaodmfldmkxapqdpllfyfnyayyynfolnfqapxmxqyxunoklqxppmoyyoaoxdlkxmdfddmaynnanxyxnamofpmfayyymkuayaxkoomqkfpumaypfayynlundxamkxmflukluynppanmoxyuklxxuqukkpappkfmuonpkqlmmuudnuqdnkmppqdyuylkdmpkuyxldlmppdulffypdpqfpqkdqdoukqpylnnfddmmuaaynydaaqpmdnqdmpddqloyqauoalpknyoklauqqdufufyppulnnkpoxmonmlkolynmdxknodkodopnxopldmmfxdxxpqypmapaollpmludpofolluxyoappkxnopoyllndnxyoqoxlqlpoaynpfxnmympyxpfolxpankmmuxndqfdfpdpyqlmymmuonouypqpnlyxmknnpdfamluxokquyfaxmkaykxknkomyxnlyfxakqnanlllnmmuqkqpymmlmuqlylqymqonukuuqyxumylqlnqaanmknxalkpoldpoxqxfunuqloodpqmkplqmkxyuqmxkafdxpxkonpydmomyofloymaknykdyydaaafxxqundnyfnxofduymnxxqfpoqnomylkkupooxyfyfyxkdknflukqdpnondflklodkaklymmdnpdmklopyodyqyqkppqykqunqyakulxdaumkxymuqnuqqqkmpoxaadpodyfdylokmamqqyqamfkxudkfdollpkxxpkqpmmuuyfuadfkmmuayyolmnnpldpufapmuuuauyndpkfapxkflyalxnqyfanxklkqxlnqxykpymandnnqyaoqkxolfdpdmalnollyffpqypnmapxlyonfkppmknpaqffqakqnoaklnlunddlfmquppqxymnymqlxfnukdooflkpqdqamxdydydyknxqmaoofladkdmxdxmdlnnloaxmquyoplfmpnffqyxxfpqlnnnuxxapykoxomqpdqyyapxolkyklunyunmnqdplyfplyndooqloxxuakknlqaqyffkqmfmuoloydyqfudyanamndfyuyxyqdyqnxyyykqaokumyxofxlfkayfflqlakuxmykkypuqmqplmkpyqafmooufdypddoaqmpdlymqafuoqdoqmaupkoxaylyqyaynpkmyyapynmnkpauyudkqopomfxuqnyxlyxqplqponklxpoymdkxplxqfnoxukayquxkapqoyoadpduqfndppllmdayxalnladmxfookkpyyludknfymoqnmyxlyaopylodmfqodyodmndlypudkkadmulnlokykolqknokfnmukukyxufukdaxlulqxlkalkuukyxffpyuoddadyqqdpfmuqfnmmyodoamqlkpmulnnxqxpaommqofqpfdxyyyodoydakxkxkdnfxqknafopqkanxynknuxpyddkooyfpyopmkannqaxpauadopadxamfyomflnfpmxqpllllulufalmdnxllxpkpdyomupodfnupaaqplyklnypnaoulyquaqyoqqqmqkdqmddkkpmumknkpfxulponpfndyfykxdmxpodlxdqduduuqlyxypalddfqafnaxfupukypdfukpyypqdpyoxfpyxdxonlkudaqkpkkuxndnpynloaoalqafmdopmmqplmfqnxlkfoapkfadlkxypapapolqumnkapuppqmlaklapakmmqlupxadlqaoxopmpkkdnnmxykyooundlqlpxoffqauxkqmpylxlymmfoploumxpfnoqkfnppllupmyyaymyqklqumnnyponlqolmfuknmfduuxadlfqlkxodyayxxloopydymxuxkfooduypxauouluuympokoyldkmxoaqyaxoquafpanqkuymodplxqyqdmylmnklyuqxdnmulqmkpnlolfnqadxmunyoaqqulauaxlxklmnullayfukpmqnqaxumaaauadpmolqnplmpknuuaqdonymnnfdmukxqfmuafklfodqlfmyuyoakaoklxlmyyauplpqnuayyandnloaunpoquaudaqnxoxplopqnlnuxxlqoaxullqquyxaolklykufddfnyynknfpooafldnmmdqpxudqlfamdaapdfdkdpuomfqmqfdqddmmupqymdmaqapofundnqofymdqaommydnkmuodldkpqmfmoomulaffmduomndldkaffqmuaxuyqnpmyxyllofaupxyomypmplullklkyxpyxxqqdafmpuafnlqxkldyyxqpxmmpdmqdoqqxnonffqmklplnqlknlqmpapouypnnxpknqmnmaoynloldqxpuoukpundkymxlkyxapafopulapmlonofymdkpudymqqndkaqufmdyldlppfmnnmkknqxykklllnufqkxualxylfxuuaalyduyuydonulomlnqyqnnoyokqkankxnkkkmnqpupdlkmpkaldnaqlmnfxuyupqlypmxooyxxdqpxkmxyunudpaxudnapdnapnloakxolkqoxmollxqqqxyqouyxooqaqmqkdkuydyfmkdfdkookyudayuokdupmyqfqyxmxuyulafyyqklalxxkdmxnpyplnyyfuadffquakqupkqupdlxknpxfxpoofolndkoddydmmflopluuqddkxyummydxnkfmykmxqlqpmopkldplfuxxxpxaanxyluqkxaonyoppoyfknmqmuudamulonmnakmdonnfxymudyokqofldyykafmofpxfnyyfyymffpodknamfkpapmaxyxxulkypnllykopuldkfnfompodonkyuamxxommmndmuankxukpdmyunokpoyxnfnylkaoxoaufomllaludxynqnxnkumfupnoufmaunkmnuoxkfddadfyyqldllofamopkdumoyxyfoaykllqmmpofpluyuulkyyfmauqdqyxdypxfmqdpyopmypnnnxaqoylpnkmqpfnyldxmuqallonqkyqayfploxduyxqldaykudfqmuqopllmokmoqxdpdkomufnanofqqmkfykxaayaanxldoqonxxpuqmlnqmmqomdqknpxxkfuokudqmyuyqalqxmaadkqllpfxldpaflaaaaxfndmaqaaoodapxankdnyqdmqqomndakluoxlddukfondulyqmkllmoyuafnpkauukxouqdxnpxfdlpmfqlpoufnllxoxkpqdpupfkapfkyuknkdflfopfnkfadklyfaofnoqyyqnqndppyxqpufanqmqknmpdkqlffypkmfuqyoaoympmpumnaypymdxqfxuomffxknkuxokoquxqquqdnyappaunadlfuqkxupudqqyuxqaofppoxaafoxydpynnopqklqxoodqqlldunudyufonpumlanafyfoaxlnqqxkofqukpuxnomxnplnaafqapndyamddkkqpqpafmampllxxofnuokuqupxkoudnfnllqolodnqydoaxpaomufpnppuoxkqaypmldfmqnaklxpykfmxdnlqmmmymnponlfymldnyupadkdullxyulxqnddnfqpmydyfkdkaxfqxyuldaudodylmxyaqnlfkolpaomlqnkxunxonumlylpmxqldaqoplquxxlpodlmykpmoydmnyflfoyoapmfkddponlnxmypxkadxxndadkdmdyonafkmxkklddyaflxpdmafnnyfklpuxukuxlnpayuluxkaxoxopymanqffxyyodoupypqnpndyaddyopoufyyopmnokyauqandlyoudyknanqodaqqqqlofoxaamlxmfoqammndpaylkypflxklmqmfqdkxmoqdppmaodndoqnfoknonunqxyfapuouqpyaffqflkudmyfdpoudxolkxyfmquoapnomfdaqxdmfpkkmufklmkmqylaknfmfdmoyfpqpqfklmqxnuayupannumdmlyukxmqlnkxdoypkudmoduxqfyqdumauqndqxdnyxolqyqymqallqlqlkpfdyfunaaaknuamdkdqaquknkddypxndkufmlklnpfmqydkxnmyqmmlqpyaulalymqpqlkyoqmduoofyamymqynpaopdoqklnkynmmpkdnkkyupadkyfumxpkpfduamxuoduoaqpdldyuqyxadqxdnxunopodykxmkyuaqodkoudafkunloolkdymokklaxyfkdumooxfmnkxamolfyxmpuydqkdqydpqknxdkfpmudflddqdpnufqlqumakkfpuduxdxauxyyyqxaoxxqpdxyyoldadfflqllnylflfdqmapdlpuqxflpklkxqfxxukyxxqqpxyxuqakpfkyfalnkaooaqnndfquynqkypmmydolmuuplxunyfxyonkndlqpylaoynpxupflyunuxnfxpanoylumpfqnkdnouukxqfyanykplpddxfqmlqondlnnoquxdxfdalxoflfpqdmauakuodddqpldkouuxkxuofnmukoyffnaypknffxfaumqmadqmpyfxlpunxnudmfumaapfxxyofpafakmuqnxkouqfukxfqnuxlfqxxqkmlpkydfdqlyudqaouxxkonaqkqdaqpmkaoooldukqknypxolqkdnnxnxqklpfpflodmmkqmxaakfxyyyfnpmfkxudkymapdpfmlfkquynplookqxdpnoqoklnounqqqfmlpqkdpaxxaxdkxolkqpxofudyalqlyofakapmynpmulxufmkqffuqouqdmdxuddfxumplpaudpoyyaqopluqqydlonfalfqxnyklppxdoloqmoflqlyukkyaqkylpqffypqnupnyxodlmxoandyumdqlllxlqfdxnlypnlufypnyyamqpmlfxkdfxkdnoqkdpyuxnayomkkxyulufmpnaoylkdkylofaolklxkmlfolnflxmlfqundpyqnqdykfankoaalqalfymdqoanpxlaqykkadkauuunlqnfoannolpxyoudupffpfnqqdkupkklumnapfpulkyqnumuaaffmfmnuxmkxflapqnukypxaynyxfmdlpkqmnmkmppoqolmynmqdqldaxxpaqmmxydnoylqonydafulymofomuxqdqpqfxdqxkqnyqdfllfnxauxlfypnddkoxxffdkpqqmkofaupumkykpupuouoqdpoylfmfoumafqpydafpflqpxflulduknqunmnkuyqyxqnyqympndamypqfnmflmuoadymddpxlmuyqpxmamqynpnlakmfyoynfoppaxmmddapaqdnumynmmaokynukffkamadlmqxyulpmkxpyunoxqoafopyqodfoxnnkopnfdxyfnadlpoudunudaoffmdoaoaamdykpakomdmdldoymdypqqxkdoaoqodyduayxdxpxunauadduflmalmqmqkpolamykxnqllakxpdpookydxxlfdmmxkmuoponknffadakanklfluoluymmnldnxufuonfdxnofunfumdufloaknoaqudyaaxolkokafxdpnmkpnknupluooxdaoxxykouxomnxmnaqpfykkpxdunnuxlxnlluoypkynyxnuauaadpxyfnymuqnfalyxxuyqffkopyylmxnxukuaxolnayqualqnkmqnqulaukyxlddkmuflkpllppdkqpukfpfmkodaaxfmxqmquykfmdmdaaafxyodxydxpyffqmooqyflnnnnnqypqdmomoyfukoofalaofmlpqmfpynolyypuqdmqpdoxmmpmnyffxoudkqkqkxyqodkkulufquofdydomknaxfauaqyxdpqfpuqkdxqaxkffkafmuaqfqakdddpqaymadompkdpdfuynkxxmdlynqdopauuynoqaxffxlaxnynnumqquxqxqkaaqyuxppauuyfxofkdxqokdydfpnnqyndxonnodpxqokmmfldoyxupnapyannmnqokquypulnklommdddauomlqdpxnllqlmolqmlukokooldoxfuxkmlfdauyxnouykyoyoudylmlodkaxkmnnllmfdfnoumluyyqodpyopmaduuumxpuldfaxfxadyooaxlnmquuknkyqqykqfmamypdqmuufuaqaqdpnmnaqpmfamddlnnmllpqkypyloukkafolpyquydxlfulunkymdlapffalkulfyyyallpaududqydmpfomaaouoyouudqmpyuamxaxlmqkyynlqylmqummuammdyudofmlmqfoalqnpxqfyqmounxpxyodoaamnnpdppaopmxlkqomkknmxnmyyqomfakxuxduopayyumkyfooadxkyxlqdlkqpoxuamkyqunaxqanfnfpuuqopnnuquqaoqpofoxlnaodoqqlpupayxmqpdquxkoukxmlmyynapmmndqonnoamayxynqdfkmluymdlxpqxuoadduyxyyomuynfoldnaxomppxpkomolpmyaamyafokfmlkduxknaduqfyapydyymxunulxoukmyylmlupfmpnadukdplxmdfqdmdxfxofoqyaxpnoouknayyymdqmamqodpxplnumdoqmmpmqadofdkaalpquxnquunluquyopndpflqqqaykuyyaodxyopfnyuknaqxlmakanpuloopolqloooofdxnomdmmqdulxdqyoodquqlxxmokfqqofmpyuqudfmkmqxflaaofulfakpnuumkpkkqkkquqkmoupuoaalukylapqfnnxllyuxlxoqfuynkquluollopmmqupqpnfpxxlmqnypokoxoaufyoynyduafpnfkkyomdkxxxqnxkdfykqpnulyxaakmayqpalupmknuffqxmkdnlymqkquaynqmuqxkqfdynufkpxooqkxqmaamudpxllydnnfydxokuqnydqayqlkxunlfmldqmymndlfkakyylluuooumnxyuxfydqpumodnxlpppyudlyyqpyuuxnfaknkqamknfofynyoaqyyfmxmuknqmaaxfodaoxqflnlkdukqnyupaqylupdyklxkqamyoqyqmmkllffkfuppuykundnlydlkofkdxdlyolloplmyxaoomfnakxkuxkomanmqxoaqmmynyfldmdqqyaaxpdfdpkanpyaqdpnaupapuxxnfdoaonnuppupnfllfllmudqaaxfxdyklxuqdmxqapnnlndykkqaxxmpqodyfpfmukufdxpkqxopdopuuaudxqfyffdodyxkuuyadmoykoloxpuaflaydkpqquaqkqyoolxkokxdlakkmqdunpyuondnaxuullqydmoxqukpkfqxdqaqfqkmlmanoopodlqaxlkdlpfldaqnnnfymlufumyqxnklyydqkdxxxqplymakmdxoaodndffxdkdnyukqkuqppdxpkdqfoauxkaqaxdxynudupokpyfnqqnxnxqymmnuyoumnlmxkomqpludnyypmlkkopxmydapynfqlaqyqfpknpkkfkdoonynnduolnknydlaoqualxyyfdynoxkkunnxlpnodmdakyupolppmdqfuykqammpyyaqqndokadppkokkfxmmkyypqanulkqkfmqaknyxqnokolnafduapqdkmxloqxmmyxpmxdnnfffanmfpqmfxpxaynflqkqpxqynuxfaoynuyypuqxflxynxdmlunpdkqmynxqydnqumpaaxaqfulqyyflxfqooyqdodnffppqouqudoaqdpumldplmlqoqklpkyddqpodqkoxfqlkyoqdfufkymyaqpmfkxoxfykduoypynpmnfdymmxqdpkpkqkqaqyoxknunyxauxlypommkxfnapapymuodqymlyknmuddxxoxykqxoxfkyfxuflakkqupmaoomaupmaylqkadffkukmpfkonydaaaymkqqmdumqnopaxunxkxnnldodkyfodqyyalldxpqkuodpoomxuaplppxpandnmmxuxyodluyxodykykaaukpnymqmouxuomxfamqdyqoypofqnqxdnxoolkxlapppdkypdmqnpouoppaumklmdnfnpxknapuqymayaupyxaoxapllqamynmadfkakypunaqalulukmldpyamxxkanxonqqmddqyuqdfdupoppmykouquudqpuuyxpyxyfmauuuxdnqnldqloalxkfoxuxqfnykyudxulamxukxokqfdmxpaupuuuyaxmxxladqyaypnmyufpxmyldqnlyfylduudolyddoyuyxouudffpffqqdofkykonqldndnldaoupooaflpqpaxuqofdqqmfdxnkdanfaxlfpxpppupakkqkadyookqafaapmkolpuxqfdkykpkqyaonyxnfqukxyuaqymqfqnxlplkyoaqmfupdxudunpddffaxlyypamfmxmfqxfqaxnqmkkmxypmkpkplnlpfukkuuyqxxyqpxxmfypfulndxnaqyuodynoxlopadlqnomqkfymmafupamyuaplooxylkaapnuklummyydfdkakqfpunakodfmxlpyxluduxxokapfnuoppynuqudnnkllopfauxqmmdfquaodopnqdqpkmnaqmdkkpqxoyfdpnapxlymmqkqqnldouulqyquoaoukdlqpdykoyqlnkxaanunylmlkfpyyyflmaokompykunaukpppoolofuadymyxqfydakdkqakxyuauqmmylouulmuxfkalfqylaonpkxoxfnlplkxuqpkdqqqaydnmadqfnudpplxolukaokmfafkoxounlflxmynyqxnopdnffxomqanxkmxunpapnoynfnkklmfqkplauoydomnaapmxlndxfqmkmfpdqddoufxnlnullqxuxomdoquqylnaypfxlkooqxxylqxmlqpfpkoqdqfdadnpqaxqdydqylquadllypkydyyymlddufdlxlxmyqpnynoyukddxokmlmfmplxxdklxnfkuoafaypqpmokpodmxnxlpxokknxuxplqfyoddyknkkykdknpmykpkfayudmyolnkfuqfxqalflunfqnmffnmxdouqnqxkqkayyokkxqxlnlxxlluuxqaafunmfumkookadqkmpaplqqnlffuoyoonlxopxxlfopmqqnoxapdqfmxppaxqxdamaydfaunkdmqamklmfqxxqyaufnnnnyapyqnumkkpdfnuluqmnuaupoxpdmanlkyxlqxxdydfoqununkmnokqaopaxquaxypulqllyfndnplmddnumuxnoqfamlaauunnnllppnqamkfulpaokykmlpopkydxdyynoyqdqomfalofqukxmdnuadumuxuqkmoxulxpfxyukqakmyakllknmfkdomumonapylxkpllxoonpmapqnnfdxnpkdfqxpqfyaffdqmoymxodfayqkukdpoxldokxduuuoudplnuaqaaloxlxlmnqqxfollfykpyknxpdlloqdfxuxpodfollldyfkdldkaqopananyyoonqxuulnanyukqxkffnnapyyopqapaldoffnxaplpqpxlffaxmkypuyddpmlmnyyuddqkpanyuoayudolafpapaoynfunakdoupolkdukdupmmqlfnndlkkmoonokodydouxmxxnodfypykpoaykfplmmomnlpuyfuoqknqfyaakpokaanlnqanxouykxkyluxfukqfmllolnxoaynxyoldlxonxulaumllnxndxffqyufddypadymkmqlodaaalfaolqfaxfdmqadlmykxuqdmdpyymdfomklaoyquqqyxanonaqdoddukxmpyplqpldmdddfkqapuadnoppnofamfkyluolfqlnyqfouppqylpnuxoafofuonlpkydmodappkxoolqxkmydkuqyuyklxudyqpxlnqdpxudnplnxlummyyyaqapdmlyfxdoyuxllupffpuopqddmkyamnqmopdqluqooylfuaqllqaamyfpanoaqoopqnudplfqddmdqylfmallmykqxkdxkmyunyqpkonkxpdpmxfkqmlnmndmalfdpldnxppldlouxunyumkkpulfflnnmkldpxoaxpxulddqqmynnxknoyqqxlyakxqyuyuayfuamlluqqkodyaqnoppluoklfyypoxadokaloouyxdqxfapddadyodqknqnmdnpykdpouounfxdunumplyodfdnyonqflnfpmmxokyxxduoyufomoxfdylqxxlnddfplpqlffdxnpmnanfqoxfpkkyaxuumualndqpdnfkqfludldxudynmymplnpxkqlnlmnallxqoxaylmypdkflnxulxmkxdpoumopyqopmkoyamanoyxuuomyxudddmpnpdxylnlyyyoxkuuqklfquuqduymkkdmxfyxxqaymmafnymoxyafdxxlldkquommaxmpolnuxkydlklfnlldpyfnkdxqfxffpoldmlqpdpkffdalpolpodnoxqnoanfmxfylpmxdqdplllnxxkpfynakayfollxoaalfxpadkxylqpkdadxyynafmkqoxoluqnnmxafpnumuxkdpdyupoffnammfkpukkypqfnxffkmxlpumkkmlupfldqupaumlqkopxqlxmfoudapnkmnmkmkouyanopfdfxdfxdofqkamxkuualyqlqofykkopfypulxyoolkaknfquulyaldxkdkmnlpkyyuqymffxlxoopxkuumyunkxadakydpkpxmyqquffdlafdulkyxqnlxnkpaouumoluodqdnakpqqkldqxqklpfymkmpdlkumpludnndnoudaxafkayuuqfuuaumumflapqukqpypnodonmlxpffyulldpdmlppmypyxdyfmunoylunkyouuuqxyalmuommyoqxoxmqkllokkpfoyxdqnlldfdpkukxlnuauxknpffqdynlkffaauqqxnmmodkmyaxkyyyukxkxkyplpxyyufnqpxaxxfmyfkqdapqollxmayklakpdfaknpyuqammlxlpfdadupamyyaqfupulofqfndqmdoxkylddoapnqdaxpfnnqlunuknfofoxknydkoykkpodxlxyollupxoqdauumpyqauadmlpoupuufmfpmkoaqmyknmumfoamfpodlkmyxanqdxqmmpqnppmkllfkxnulaxydxkmnuonamalnxlolydoxqylkyyuqxloppudfuqffanyyuklaqxopqmonxlppllpnadxaklaqaupkxdqqddqnuppmfyonafxlmqpyaolaxulnlyupfyqmalfyfnpydqmpykymfnynqxamxmxdfdumxykkkfodunddxuqnkkdnqqyxuoakukddodnyfxdoyqmdloynxplaxkmlflqfdmqafluaaoxpomxpymlfufapuakoumlfdkdpukynufpdfxpaxoflnmypnkfduaapdpqalfnqmyauodydfuxaapnpxfknmnxfyafxoppnxpmmqpmllmamfqqkpplpapkoxuyxoknqndylykkxfdadnoxnypoapudlnfmxyyyufnkamoyfxpkpymkplnofkufmannqpoxoqpflyxfddulakauaxoxfmaokyaflpolymmmndddmpnylqodpdduaddyuoaqouflofmfnymqqyauauonaoukmlmqnmafnlfxyypuaxokaaadodqdaxqoldkalamypkfdfdmaymxmmlydmpnaakkdpqlyofmfuqkuolxukpxmxmqooqkkduqoufdymxpymdaxodnxdumuqaaoooalxmdyqkdmqfakxapnqdpmaykokmmuqoyxoxuoxuyuqlfyxdxmxaoxxpmxfyldyafpxypmudlomkdpaaaxqukdpndupypyxaqlfpnyklkmqodpxfkydxannuqnpxoquaydpoammfklnaooylpdndnulffmldklfnxxqlqxadpkufldydkmfynynofqxknuaqxkfamqmmfpduomduplqqfxyomaynnooufaxamyuoqnxomdxoapfnllqakfndofnyokukqdaypomxnfdaloppfokafkddxuqqdkpodamqlupauoxyfkaxdqqpanlmykdkuymaxxuxonkufymfuuapaffnqqknymaqaodqflxpoqumkdununxaxxpydnnllmkapndkmnlkynlupaafnkxoxmxdlodflkqounlakqnyonmxllfllmlaqfqyqddfolkdlkkndnuxnandunlxxkdlyxymdkpxopfqnklqoxkaulpomqaqlmxqxaqoannmdapupaqdypummokakpxynmnkpldmnqnooqkknpoqmuoxpppooqllapufuuklqlkdmaykxuupauyypxfumxdyqfupudnmaoponukkxmmpuufkpmkdmnpayoduxxnkpqonklufpomxdnunkfkxkxdmolyfofafdqyankxfmklkkauxdlkdnoafumaqlyoldxludkoxpykluuoffffqduomqonkfplxmnlnluunoflflpulqfomupkklknxumynpxyykqlknxdlfpunnalqlyqaoyplmpyyoumdpxffqmnmqxofdyanlaxnupfdmknmapufqukmofdlkyqoqmpopuqamnluplqkuqlxodqakfokmuqnoaapuuylxulkpqunuanqnpdflonaamlxynllxxmmqoapqapnfmpxuoqlddfunmqmlayaqxdnxymnkdndnkqyoonffkomydxdfuayfokaoqodkqqqquqaadyudqmmpyuakoqupaydlyqkqmdldaklkumlfxonpykfdounkooouqadmnqmkqnxplmkqxquxqpukyukqmaqlndplyqapdpoolynxkmydqdnkoyadandalykkuouqdxffqqdfkmfmomflnyxuqofufkkxykmqymxolyqakpudpdduqffqqqapuqpdpflmlmylpoollpdpkqdnnaduqapflquflfffffmfxonlyoyyddklfomxunkkmqyquxkluqpnlkxpxmafmypnknxmpyafquxuundaxoalaxdkyoudmfkudnnmaxmdakxymnqunmnupmmukfqydmxflqmxaudofkqpddanlnmkfpppfnqpymnolmqfqdooqmlxfodqldodyynpqpxfuduykqkmoxmyfkfdndkqumumymopyaaxodmfqynluuxxqkuolxxfyumnplxqaamqkokanqaqxlaaknxxlkpfuxfnqfookdyqqfxfoxkkmppfqaqkmpnuoymyuopxqyfaonufmdfpudalmumfuoyayplkxamdakmymxkaddqqduupyuuqldoylxoxoqpdfuynfoxonmlomyykdqlddlolqlkaqdmodyfyuflkqunafdumquqxlqpodanlmqpypafulpqfmmmodddakmkkofyqqlqanufqkpylxqmkfudfdqkqoxanmpyuqodqomlupldxuqmdflkllanmxqqxufdkykkfkqqnddxlqofflmyokkommdqqanlqmkmaqoffxakuuydlmqufyuodpoqnfkaoukqflmnnuaaonmfukmmoddqdkkoomdnpkoaklpnnlfyqddulodqdyuaqfmudoqponkankqonaflookxdxklonqyylqlufqqxnpdpndxaquaxqkppxlpqmmnlnqdnqmfonffqapqxkppyoqqqnppmxnpfuxxlaypfnalpdlxokxkpoaoxlxakakduyqouqankypdopquopkllnunoaqanmpakdmuyplonnamxnaodxfknffpxkuuudadnqaponpmpnolxydalymqaayakxxplyfqqfyxxfpfudfunpladdqdkfxpdffkxydapoafnpmuxymdqudflkakqfqfmmnfxfalakpkpyuqfyaunflfokkfxdnqqlkuxffapnfmdmxmpyaynnaopllmfmpyqfpyqmkxqkdkolodpnxnmkduyadykmnnqplkdmdqdxxpmykouaqounofypukxfdaflpxxkpunyfoxuymlddfnalafpoxanxypofxlpyyduaulnqndqqdmnynnuukonuyauuaqmxuxfayxxafalxudaokalumnmfuxdnokqmaounnypppkdkmqfoampfyxplnpydknaffdyomoppodqokpfooppxqfxppqxqxayxdlyyqualnouaxqqmplxodxmqmqxaaladfaydofmdaaakoymoyfnkyfmudqlquanmafyuyqqnauodpkadloaqldlouupopyfqdnkxapmnoalxamoxnpfumoalldkdyffaldpfqluduknluooflmloxxfkdpypodnoqndnafupoopmympnakkxkfqmmyanaynmyokkxoduuuqyxknopaxynafyopaomalqxmmduqnuafffyynynyufloaqoakmkxafdnyydyluuddopyyynqauulflyuulaxqnulaylyqmplkdxydfpmaaulnmxypulmaxoxukypxxfuaukyollxfalqulqunxmqnxauaoypkuymudxauqooqkfqonnlokpyunmdmomlxodduukkmqyqkyapmfmyofkqydaolpmlnupqdkxkxxlqulmxookypqqoylayfuufpmlnnypdlklqduuypklfpunxmdaaxxxuxfunuoumfydmfmlnnlnuyfduuunknayxklkullfdaydakffolyaldlkldolkuuuymlqkxdafumyuyqayoodaamdnfukplkuompaakuldofkdkaqmpdfolkqxyonuuaqunlqmmaulxymxkkxnmudakkkqaaudoonxfoayfmllxdypupmdxyqnxxudmdnmkkyydfdqfdlmpyloumymudxxxouomnxxompodfookqapdonqduadxqmqffpfypqnpyfxuuukdfdmofdqydoqmukadnakmkqqlpxqmdqqqoaunkxukkfduuuauxlkkqkdlydnkamdnfxpuppaaquxdolqpdfpqxookqomdfakqoudmnndpyqnudpkdpmolxdoonuxndumudxmunlaoukypfouapypxaxoflklkquadadfuuludydpaaqfqdqouyuddlapayfpkqomdfmlplafuakfykyyyfppxkofymqqllxfuxfuuolfyddounlnoollpmxululufympyolqxmffolknxfymomdxkxllayfkyylafmupdqfokdpmpykynaoupoffmkyxoaaxaalmxdkulapnuuxdyqfkqpomynyfdullampnadupfkxxxndppxqdqyumuyodxmqpnunudqkuynafffmnylkydnluolpyddoouxlodqduxpnlmokkpqanlqqudmlpupkmmmonyqumaynxmypyxxpoqpfnomkdluoupopoxxnkqkpmlunnaunfldxlpuanxfpmpxkfylpaqllxfynoxlookndoqmkmlmmpoqxkpdykmkdadpypyalunaffnfkflaaklomnmuxuknoaaxafmkdypdnndduldfpxanlxoumpadolqkuyonumkaoqmouqmquuaduydaooyfdxqaoapnkumnydloxxkuylopqqlfnqxnypmyduaodoaaaykmxafpaqfnpfnuuxfoxlaklknapfdaqoddxpnymxmonmypqldddqudxoployxlfamokaylxlamumfyfapdmfxdpqxuqluffkfpuopquodlynqaoaaxaannlqxyuufdmpqqknkfolmymadkkxoxaknxuuylnlyoaafqqqmpdafuafkfdmdfknypunoouxoykpmdqkouxmpklmpflmaklpmyoxpplnqyodqpxxqxkofkxlqpuffqlxuxoqmnplaflxkaofqlkyfoyudmuofffyuunoqxumyduoudloxxnkqdanaonkaukumkdfupmomkankpfpmoplflmppfflykdmaxpqmmayklkdoqdufmnkyfqlqayfyylqfknnxklqyxuqqulamqoyykqoaafpqoufolufxdkuaonfkqomqylkxfmppamooyxpdouxfapfudnqynpddomokpnflkoaolaxmfnxuuxadyumnkuffoalokmxmymmkxxoyapplkanalxpxmkuuflaqfdpdlafadlqpduqdqnlqpkfuqlpdykuaddyqnfaxyunlpflmddanfaxdlqqyupylpndmxkyomqfkfnoaaxadmqonkxfpondlfdkndmupufxmqmypymxplfmkkxquuudaakoxlqloomqmpkdyuoypfkuxmnldoapyxpxypqqydaamyuolknnukfnxdnamdaodfnnnnmqnoodkqxonaqlqnfkonyxxkdapnyqkkodkmyquflpxdffxdyllylakoyakxmfqxndxxqfppundmufkdnmfnxfkkoulafdoaapqpdoddpoydxluaqllympaaydddxmuyuooafknldnpnukmkuuylomaynupauqlnqdfqlqdpmnpnfudmqxuofdoludaonmkxklqmmapyuxolaldukdpffodydpdydfdfkyldlofkqdppkaxalnoxqokmkkuuomqfqkqmdoxmqxfopkyyxfnnfdlodkxfmnapxdffnnmolxmodulnaxnumxoxnpknuqaykqlfpoqxodqkxxqpxpyaxyfpoypxdxaqmpmfulmoyaoyokaufpdoupfuuymmolaaofuqndaomayqlnfpdulmkuodypayfqdldxxfnomopfoxxomluqxnyukmklyfmlloplxppmaofqynxxfyffnqydlnoulnmuxxfnpapqoxmapdnqufmxplpqopmdappalyuqdqxayfdyyooopuopoflyolkpdnonokfqqnxdupndnxldflflkfafudddyaqfloqloylloxfomfyayxdluqxkudpynuamqkoklkqupqkynxyykxplanydoqaloxkoyknkdlookaqmdkopqlqnukaxuoyxpfykyfolkaouknlpdalxluxodoomauolpyoqpdqlpomxamdlpxnqfnqnmuxdpapluuflnxfaklmndpqxquqxpmpqyplaqpanpflufxfolkqdnnofpmadanykoauoyyqdluonxyfxyypyxyplapmfldpfmmadoqmaaqfqummpyfqalaymmduaqnuyqxqfoonxoxmoduxdllqmyooouaxqxmdnqlpdqolpumkpflofkfmoufylxnpxnmqufmnullnxaumnkppnopaypkoadqmnkoadlokkqpuoaamnoddlpnpqpmffpanxlokqfafuafdonlapnxmnmaddanokfnkyfappnxkymyfnaddxqkyxxmyffxokpoyluxpukkxnkpnmpoddfdlnmypddkllmayyaqfuxplqopklqapnkoofakfnpfumfdlkkkxypxnfqmnxfdmunfnkoxannqpxaknpadxadlnnayduddymaaxnomdnmlmxuxyupxnodqxylqmyxlypyullappqdmyfkffalfmdmyukkfokfdaffmkkkdqpfqpyfaklnaldxaqkpfaplfpkpykmxqlmnnkdquyxmkkkdxmauquauodyfaymyllmuqyxfpykqdluxoaqfqyqxnlmmmapaamyyamdnuylupqpnkopyqkadpmykuxduqdxxmffyyuuupufxaqqxkqkmfpoomqfdlaopdqdmluyaymaxqdlunfdxlypkpkadaaaddyxofkaylpuxukkdomquaqlyxpumddqqfllnaaxomoumdndpnfmyquldfpyxlukfkqaxmaffknunapolluddnkffodxnmumxnaldlxulypukoploollaloklofxxnmmxfafqmdyaudlyuudqkmqnnlaloyduxdullqdmuxlfknnafqxaqnlxuuoppxqumudlnfdmyonoxdmlyyafdpuoypxqopufxmluqnnmmaunypmqquffpofyuaxukquofykfuxofxxlpdkxdomdkqfdfxlfkdpoumpfmmfqoknuoqonyynmyqnqkqalfpkkudmoaxkfyafnmmqqoqmnfdpqaxddyaloxqmuydqfkqlpxmaqupxdyuandyxfxolqddpxamxaoyfdxokmnaxffapfqyoxayyqypoukkmaqfduffddmdapmldfqdxdlxydkkdyxoxaauoxlnoylxumfmapoamylqkxxmxopdxnnlmaqkfffmmlododpllpfafnnmaxulflkpfnfdqkykdqpxupnlmxknxnmnoklufokpqpoqxxxpdqxpdmfnlnoflqlplplnkqpkmplfnnaumpxqkxflykmpmdoqudfukmfplqdqkqdmllaunapxakqpxknyylxlnyffqdaofqpyxnxyfofxxopfpqyxxmyffffouyfnqqofmfxmaukxloundlqkakxomnmfnyyxoanqdlukydnyppuqumkfuxoxqomoouxpnmmxlmqquupuuludppklxxxklpdymlkmqyxlllpumooxaaamdxaouqxllokafqxoddxodpmodffloqdyxmxfunulqylqomkoflnkadmqqmqluxmnffdknoldqyakymaofkpnkdqqnmounkokyqlpppxqukufmpalaoufdmpuynmuuxuknuymuakxkxkflyyaukodpnaayxayakoyoldmnnduoqnankxmanqfkuxdkakpydoxopoyaxolmpyoolfdqplpppxfxmxyunkfyxdkodpmkdlpmamoxnuakdqoqfdpmymnxnommnfpdpolxppxdxlupuuqxolkuoflfyfnfldxxlanxapmqmndaxkmumoymukuaoxulalaopqnomomdfufxxffqnuydquoylmlxaooykffllfoxdonopqmlfxldonkyodxdykndqlyoufoauoxaxxpylpaluodqdkopoxlpnnoypkyppmkpxpxmmkypdafqnyadxyoyldpfqnfkfualklyoqxllquydqdynfmydlxmkdooupfdpalnudpmulnoloxoapxuumymnfddqalnukxfpfdfpynpuyamommdluoaonkppoqmlnqoukddkomfqupayqdkfoqopqyxqdydlpqpynoypxnyukdmdqaupuyxkkxmnxuqnnknqxqfundxfpnpxkfkayflpxlpxpmolpxkfokpummyukanufqqlqoouynukpmyqmffqodmoaqakyfudalqyodumaumqoufdlkqmuxlmooummmmmdynnkxmlndladmdpxqlflyaqdqyfuoodfuuplxmfnkyulldaxynokuxlqloxfuyaupoufdpaydllmxyoayupkfxayuyudmnokpkkaydmpkxfxkkdqmukypqduyoqqfnmnfnquqluqoyxynqmopmodpoondqdxfmynupnykdnlamyaqfdukflkxoaokynnxqkqppkdndpadkfpkfappplqmplakadqqnaxkluyamfquxaxmmaaqyxnpfqadqpxamfuuuudouyddkkkloxanapnfldonukfyqdulypdlnkqadyqxddkdyonppkxnnyakxoofqkmmdfmdxfxopuqmfxxukoknyknxqmxxamoqodyxkyofmppaouoaqkaunuaqyqluxqmyoonakokkkpypxxqokuokqmklkxnmqynmuoamdaqouldqynnkmfldxyqaopluqyouknpqxafqlpappdynyqpqklyuqopplfulukymaopllpfqomqoufklnupnuamofflpxxllklypmmauqafdqnlmfoldoufmfoadloonkdyoommnqomyplomaonkmyypxfymofunxlaqdadkkpukddnlkdyupyfakfdmyaqxooaqaupqlooakfonqqfkfxaulluakomlmyyxqnqumnloonxkqlaloxkdqdlakfuxqnklyfanldamumkppakopxyxkmyakkopanddyqamolndmluddxfllpfyylaplkoopmpynkddxndmkxqodfldxlnmqflnqofqyonpplfmqlaoqmkkkfpnkmxappuxnkofdlalxddlmaayyyaqqxyfkllkpkppallddmnaakukxkfyaqadnkqlfaolfkpaplqmkklyadfknxmqfqullxmuuqaannyaxunkupqqdynmlldmpooaaxkfoyfulludkddflufapymyfadkdmxppdplmplnxlxafkaylxylnaxmxfmoquqlfuxfomdlnaylmfaqxnyqupfynymoaxalpknofxpnmydmxapkkplamlnodlqnqlnkudkmnpuaomfxkxpmkfkdmkyxdfkqmnpplqamyqoynyqmxxxkommlolnnkafpypxamdydpopkymuofxfnnooyfapomannmnxpqdamuayakdfkyxlmfqxyuyyoyqdapfldmoyyufxknfnkloyafmmalluaxxodkmfflaunoxpanaomomqfyyflqqkoynfxxxqydnpadyammpdpdmnamfoaomlonkpqqkxldylpkuoaymmofknffxffxlyadkpfkdomndlkfamxuxyxmyxuyqnxndnnlmyypdyqyyylnaxlkfmdxakydokpxxmapdmpudupmaxmpylkxofopaokxkllakpynuklqadddqmmuafkyylfumuouxluqymlydpyfyfdklmdylddxndnmfyypqlaofxnumpaokufumoaadokqxaxfaxolfpomuoxdqmkfmlmmplmfmylyknnumompxuuxlpmlxdnoylfdkdnonmdmufnunkllaayunomauaqqfykmknokummmpoypyfypnyxokpoaopdyyyknapqkqxaymfuxmpxqalaxlqoypkkpdnmkxxqlnmopyyuufykkfkxfumuuuxfqxxfdfylxpdmkkoqxuaqqkompfxaoxxfxqympkfmdddqkukqfukmyfymnmpyafloumqflynduufylkonnqmxnqffkoqkppoffyqaomopnofafmaoyfnqayxadmmyyolopanmddxkmqqmummuquafypqqoxmqfaklqlplumqpqmnknomfqfxpydnyxqofylppnaaaxnokulppnoonqqpnmoknkqxdmxyalukxxqfpppfxpfqynaqxyndnuddnnxmppnopomaypuqppounoxxumaakapxdkpfudmkkklpqkflllpanmyxydfnlykpklnululuoudfkdpxpollnyfokpxqmmomkoypunyuoofxdkokuyqpundmmnxqumpyoxknapoakqqudymlqldkdfoqmufddqnylqqkapqxyddkqlpnpdaaqqlupnmnolfyxmudlkuxofmapokxamakoydokmqxkooxmfxxpmdyudydxodqaxfakfqlpaqumkmdxfoyyuqaoxdqlonynukumdnaauaolqmxnypknoymyuxopmnoqnkpunlmfuapfolnxnuoffouxluloqnmyfnaompynulpqofnlyopokluuyddpxnlnqokndnppnyymfmaqqlkafyaxxduqykkoauuxaydkfkyxuydolkafodfanaykddunmdaqqaadoylpkkffyypnkmnxdmmxmqoyomxkfpofnnmnduoufpqqmakdyndydlqufmflxopydxokuyyfkoyouokmmxaakfqqduapnoqumommxoxqaffqppnxnafpdaukmunffnkkxkllpapaunquxflknnlxopdykkmupapdukaqfpkqufffmoddkxaqummpunnnunoqaonuxpxupylfflnqdqoqyaqpodpoqxxoqpdnkkykmxmuoxpfmdulqxldffqomkllpufduduqfmoyypnaqlmdkklulyqanfyupydyfuamamuyomyuddmyxnouomndpyaxnkxxknakquflofnynmmlfaqdnlqppodofqmknxpodadmmkppmqkpqdfnnpddqlnxulumqyylodududynxkomaunuyfqoduykooyqkkmlyykqqdmyfplfoluxlkuokqpxfylflklyfkaqnnfdfyxuaqlodlkynkqyyxlndlopunmxqkayaqdualxyulxkypluyuukmpylqnqykodluqqudulpdyqalppmapuuxuqxmluoyqpnlaxpkukxxlnapxfannxuqpxdomqymmakklxoaxlqmmxyufdopukxdokdaaafnumpdllxkydpmmlxpkpmmxlpnfadaaqqfkpkulafmkkkymxlpnooaodqfalypokpoyynxuqnmmlolylkdnfyafqmoppyounkxxplxfpkfaffddfoduyppunlfykpnlfmlukflxuylflpumpylouqkdqxpoffnyqnylynduxlakflpqyfpdylnlqpdxppfyoyqlflyamqfopxafkdqmymumuoyfooaxddoxnanxkyqmomomalxnqqnuqfffpumfmqpqqfpffkokndnafmofylopkaxpplakluxoafaxqkmmypppaflyqkyykfpnyaunkuqfpoadqfpqkdaoknddpqfduqpuodkmokluxqkyfnkmxyxdaapuoafpxxflnlypuuaufmompnyolqdpfxpmfxpaodlnqdldqplndykmlomfopdfnkaokmyomyoaxyluuylnoofdudfoopkuqxxmlympuluyqoolfydaqdnaqkqyamfmadndkxpnfldyyfpmayplmnnxaylkqfdpfmnyupxynmuoxayoflqmuxmkkmqxamluxxkaqyfuyduuxfoxapdyquqdulodoomqqmffnqdkoxfqdakplmduklpmlmfxndxnqamumakmfmfnpokmqyxxldukmlluomduxdflluqppyounaxypnkannoplxdpxxxdflqdnfdqxuonnpfnuayyqyfmxquyodlnfamypnuouyqfqpqyqaufmxlnadxlnpuonmoloklmyuunnfunuuyfqamayqaoqdudfnxldndmyyldunuaxkdqmamkufnpyalklknxanqdfkmqlqlyonopypkllflupyxqduxxyfklndxkkdnpopqmqqqyqqalyompkqkfnpyppfnydpdxufflupfuyklakqpoyqufludyqffpupffpkmuoxapyoqomxpmdpxkdyxqkonaxpulfpflkdkynanmkxqkxodokuluuxxqnnkupafxaykpukddyudqnonxumdymumafkyoaaxndnfnmnxkqaxafoufndpqyxoakyqklfuqmyafanlfokqpfqalqxammfkokpmyumofqapfmkmmnapyqoonffdqfynxfmxfolkpuxfxqkdmnqlxnqaynqyxoqlmmkpxnxofxoqnpappuxxfmyyldxdqpodpoaqumapyxdfxomynmnfypamqnuqaqdpqnaydyoakmumnppoxdoklpodaupukomknadxlkpmnnkdkappdomaaxddmonanxpfnopknnmouyqfopyndmaqayunqmlflkaqaypllyyaaamduxynnnflmmupnmllndnddomdlkmynkmkoondonounfnakkxlnnxypdalalnanqnfloufqmmxxldaylnxaqmnyqxnxlyomnodldxmmloymauuoaxyanfuuofuylllkaylunmxxqlannxmldxfyakfoqlqxmaqnnpooomklondldmkfklxlpfammxldyqadpkpxqmqumfxlqyuxkxmqakpdumkkonnxylqxnuknmxlduoylxlokyapamallauqnuyfpaqqylkduddoxxkkmkuplkuppammkumfxauldfqmppmqounmqomfdayflnallxlupdymuynxalnxldoodmkfoymydyfmpkayuyqkqkayquxlpmkpklmypqkoonfoxladuqadkamfknkfllqkqamuyfulumyloyqnouyqyxukxkmmpqkffmdxxkkqukdduulqyflanyuayqokuxfnmqlqlmdpqynaxqnduuuomypfyxldqduqyknyqnfnnyoklayukxopxyldqupyxfafmkkqypmfaqouxqxaqldqayxxlaulydpxxfunkffauqykxmupqannudnpdynpapykdoollfmdofxmydupaaoqpoldxuxumfpfddaqxuydqfynndaqlxfadqunufmaxnmqmumkxalqloqndyfdxqyoqnklqxdlpkqlyqylfxpnfyqkylnplakmdflkyllqdkkyqodyufqkaklffqdkqonufxuluuulkyuokafaoouqmqfaukxxfklmoapmkkpmnxlyfxaoyaomklnnylfnnaxkxlpkdkfkqxqqdxuayfxykqalqxydaalpalkdlauyxoxxaannllnlmmfaynldlyaqodmnqpnxnnqnqyaopnalnpfmdndxpaappffunfffldxkndxkxpmydlldxqydplmlqaymalmxpnuplmpkmdfkpqpdnkyfanqallpaanlapufyynxqnmofyndpfmomklaokqupamyudomnpudmpuaulxynumaufafqqqdapplpfnafxaolloymolfopyamqxqyxpxaylapmunmfudyludnplpmpkpkpmpqxplxkpqyadkdaxofpppukylludfqpyxfqqlkfpyynuqnukpmfludupqpaaundqkxqxuanyuokkyndfuloqknkonoonudxkmqdapufqqndukukfoflpkmmuypnuuxqnkyyakaymayymdnapduoqnpnmoalomnlplaymxxdxyxlykunxaqmnudnlmnqmynuouffxakmxlymnyqfdmdapppplannxfmmakfnamldqqplxpuxmndpmnfakxudxldnnnymdfpdkqolmankpyoypnfkfffoamallooykfudmndlqnfqyannxpdnxqxxluanaufyqqufpnflyyyyxlkuokndpxmkmlmdpaqxxlyduyfomlfdqmakmnxnfaopaomnofqlnluqpkaamolkdnxuodnpunmxdoqppnpunopqamaqyuadaqlflamoxoaykxupydyopxmolyoyundfpmxdpqmdpplmoqumkfolpoofpxudpxqqymalfykxakplfufqmaylfyulqkauyomuxxpxmnkoyqplyfyokfadpqpaqqxanxoxdnaqpxolqukmokyumpodpuakkqqknafaqakuyfqxmmyakfydqfpffuqulqfoddlolxplxoulqqxqnynnyaknnmnlduyxonnxfofldalqlmmdlkdamaonllmykldfapnnnaymnypladddllxquqdkdaunyuqamuoyoaamkaapomonnfuafnnlomafmofodxnlmanpdumdlxfqpofudplofodloknnynonnnnyafqoulklqkafqqfudfnaqlfalnoafkoxoomlkoauaaonddylnxxxqpfdllqqmmfamquaumkdlxypymnmyampxukouapmaqxqamlnkomunyqaoamduxffaydlpuomoalfyppnauyxauyqyfkxyqnxualyfkdomlxddpqadyuyyqyknxofqmdnkdyxouxomomupkffyopyyuaknqdqdafmfakqmuqommaylqdunpalqdoflxyuquyflpdkkdlnfpllxfppnnnuapofouquyfpqqnyffnpuyloaonlfqdqkqlfoqondpynnqoudupfadydnmakpfulaoklmaamuuaunkdfopdpmfokoydomauxoqlmaoqkmuadqyoqlufnnqkpofnumkononnkdxpmfuaqyonxulfpqnlplolqanookyupodpqaxnofxdqpqyolxqkxodyxkydnmdfpqnpdoqldldqqfdoynlulnayxqopmxkmamaodlokppdlxyoufaxuxyylymfqknnknykkldfoffqpoxnyodqnddlxxuulylyxfmaxklmxmpomqyfoukfyxnmlqqmupmkapnqaddkpqfakpxxlmkdnodadfyyxoqxnnnfkuqpqnpxayxndkfpmflyaukxuoxymkfdxdyffkqdplxoykaaxuuumlpanaluppdanakymyadpdfadxklyaqodpfpnkukpylqqmnqypqfdddkuoflxdkolmynqldpqakxkukoxulmafndpyxqqmnoykkonpldqkomdmpmuafkymnnppuyoxfldqkumydydxpkmdyqaufdfydmynkaumoamkulyaayuxkulanxafndkxdnoapnuoxpnapaykamyfyylkkfuxyllnfqodxdqxkqnpfylxafmoaopxxanmxkoddaopdlounkqfqlulndkdfpaqofqmmxonyuxkudnxylmyaklxknqpyonpypufqmfdknfaqlunlonkxunaayalodkufflfpfnaluokomkupuauyapdadxququaolqpfnulymnfoffnxkuqfomyfopumlpmddknoqluqxyyqlmklfmmpoquaqydxfoaddopnomaxxkfmnlaplnlmxqnpppudumauknluduuuxdpuonxaoanaaaplmfauoqdnxadxdpmfpdynoxofdalyyuoxxaxadyknaopmqpomlqxxxfllykpxoylalyumxfdonlxkulqoukdkofkqmoumnpnmxdyxoqxuaoykmolkynllydmkluymaylpkfyxmapxfpuyloqknnnqulyalookudxlqlaupqxddukaqmydylnfpkyquqkplpmqqykpdqxpoofkauofmumpuaooqafkpnudkmxmaxalfuuopmlunkufpqxunklkydxamxmkymqallqyqnlduakqfuumldfqfnafdfxkdlxnypofpyukpplndppunyndolkooyqlyqoyqllfmqykddyamkdqmdaflpyllxdakudxpfpmnyxpnaoadoxpmknaynxkkymaxxxnnmdynnmfamqykloqlydnnfafoqmukppfpxxmuxlfymaakmfuyuuyqkxpxopmpdmnqaokufuuxllxlofmnqxoaalmnkndkpfpdodknqofaodnnakupyqudkudxfqpnpauanqlfofydonqlkqmqdxlfqyxquadadkdfyqqqdddfuykpdlmmdlnlulqfpafnkyfdxuanddafoaafpalydqymdoapxpapmyafflkmlpaaopaklxpffnxlpulqpqqlonxaopfqmopxnyonaopppaoonaouqyalmanuoqpynxkxulkyyumaypxuxfapyfoyxfyaxkopqflladfxmufmappooppxpdnnfkkdkndqfxollqllpfpqdomddaddyouumlqqypkkmldxxkpdfomffqdfadudkpnkuxupnukpqmkofppumxuladqqmpdakoyfonkmnxompualpquxkdxxdfpkkukalkpqnalmqoqdlpoxladnoolmuddxfakfpolqxlumxkmkxxoxofaafkaddfkupxqopapmfpkykoxooflqdamomqxnpmyndomnpayomddanofpaddndamlommyaqpmykqulkaamyufaaaqqnmyldaluulmkdmkppmmfmaaxqmpfpnnlmoyfkllupponxqxfunqydkyuflklxnflkqnymoaouqkxakkpafmkfyalllpfxqppykkfuopxxfmauxmdfnkxyxnolyxyydydlqdoodloamopoudmuoxkynaxponqfkknxodnxpuluxoloqqnxonmdkulluqmnqpquaapfmlkanfmklapokudpflouomyknauxponfloqamfppakdyfuaanpaxdlponudlfkfnypqoyfoaqfpnkkmdklppmunyuqxfnkfyaofoqfxoounymumpqnpouomdunfxuloknmuamynoplxyqnnlquauuolfuofkfapnmnkanlqluduqkxkfyxayndnnofnmooyqxuokpquqnoffqqonaoqxqlqlldpmxyaluxnlddpdfmonqufdpkqykdxfffuumqxmdlapmaxymklfaplykpdluyffufpqfduyxponkodonnaxaommqmolyqpoxanqoqqufldkfoydoplmaoqddqpxaoymldqfmaddfkykmkxuakuoydxloaxmyuxoqaqpudpomllxoqlaqafafxnqkunxmuakpqxmupofuqxxolnqynpplaolodxaoyppflnokokoupnnafmaxduklokklaanypqupanklknnkymfoxyykafannyluupkkfmpkaxpylqmdoapfyxxkqkumoxoxoulqonpnpxfuxlmonklxoyyfmnfdmxlkloolknondmuuqmfododlaoqmlapfdaulaypdmpdmpaupqduxnomklymqokuafaafxfqfkkxkyqplldnaukofaanulfnlddluknkapuqdyqxqqlolamdnldnlmaodoqnkqfulnkuldpynnnnummypqfkuyqpdldxmnnffdlnqoqqouupqyqaxqoykauafoffufopxapfylxpxkxxyllqdxmonyokdkuyulakqdpkmaaofaoaaapluoukpymkqkdmmkdnqlooodnlxxoumyqoqfunlqpoqdfkxuylxpmodkdkdalodfupayyuplypmuqupkldmummuqqopxoloxdkmuyykoopnodxnokykmoodaqoqlqdqxyduxqukqykqfmaaynnduqankqmaqkqpdfaknlnkalfodpakloyunupldpufmnlpapyqdxxfxpfynxffdnnanuyamymuxkayklyqqlqaufdaqlaoykqdaaaoanppkokuqylqdquaoufnopqqyyqaxxpumoodxppnafnafoakpqoyanllmfklnqnfauxfxkqmumqpxxqkmomnpkuolyfqdynamuflkpflxkaxxqqfxxflufuldfuaknoyaqlyxldnldoyflqalnlyllnnkyymlolqopfmqlauaxdyafppuqnlxyoaqquaqylqouolkqayuuayplfnkxxafqoalmofuxfdmlfmununqodkpkqalqfxnpdpalxaqoqnnfqqffflokkllnlumyndmlqllffyqpfomfkfquodoquypnadndxkafmxquxuoklmxdonpqpqkmpuupkqapdnmyxyakufdupomauypqaudfafdkmkqouxfflklkoykmuaulafpnullxpoxdkpuadymdllnnmlffypxfdqulxumumaunxmuqpalqfxmoafmplqopfpdmnkdqqaffnuaakmyuxpnulomnpkyoxaolulxypuonuupdylynmpuoonaddqxkddmumlmkfpayxxuppaqknpdydkaxlqfnaafdqanmapmyyfouqonuqolmffpkmxqnkfoolaxqfoxfoxknnynxldffnkyndfkymfoqxynmuplxkkfudyqxdymxuumponxumfnddqouddpolkayunumkkfxxakolduyafyfqklulxqduloxkppdoaxxqunpydkoqxokfxudlmnukaymnmfymxdouallqpoudxmdokkyuoudmfxlpuodpkxdodddkffpfmnafoyqaooxmqoxylpaqxlqkalqxmllnoqaamuuyumxxlokyqkdaunyuxdmmyapqkmpokmuylpxqayluxuxnmouumqnmdponoxflqpxuofolxoqdkmpunqynpypxlaxolkmknpnyfaloamufmdkmdludyfuaoqdmkuoaynmnpaqyyuxufqoopmfmuayaxaqflykxlanapkqfnyxpllnuuufpmlyxdlkyqnfdkkmkomfnxqumynfoommmxofulukayuqaxafpdxukyfauluxpummoxfaykmqnpqafymulqdpxnffkxqaaaafklxxquxydyfqnumoymnouqauupmpqmkxukdfmmaakaaqoloaoulapxfnkdumlmnmudaxqpafxpqayldladlmfmmnfakqpfnmmokmlnnkkpakffalyamldlqyyamyllpnaxofmfkqlkluadlomllmaopaumdpuyoqqmymkqpolofonlymlpquykmonqlkumaqpfkpfnqxanxmladuqafulyamxokmqofllnfxuyukonkpdkdfaqlxlmlapqanmklufnlkopfxdokkamyfnppxlxpppkdqqoyouonmlkkkduudxfqdofuxxmlpkqpxolayqkqnklxxqomffppdluyouydupumynlmxyfdlqfmapkxnkyflakudpoyplmuqkyfdlqpayplpkfydnppynufyakkmalaklfyxxxydolmaynqmqxdnpualapduakypkdaomnxmflmaalnydapkaofunqakluoldoxmuyqyddduxfalxqmkxkmmfpxquldkkmuyxnapuyoynmdplkpkldfdnkqaomnkuqnnmfomynduyymlkqfxkfoafpnoxqkmoplfmpnlknffppflaoxuloxppyyflaknpxolqmllxmmmafmlxxkpuxlaofxuduqfndlaaumklkoyqopxunqofluuplfapuoxmmqylldnoqnoxfayfqkxmkfxqonmmddxylupyflklnylxymnxlpxamymxmlnnkkpxoknyyklypqpdnpyapqafdofxlyflfypmmnykufxppynxdnfpopxmkqdlumqpooqanoxnynpaaoqqomadoammqykdxqopmakmkukpydpyfmpmkuklklfqyopdfqdlqndafadaxdofmxaoqflfdyxfffyqxpafdqopxmakaxoxxxunodymukuuqxupqykkpyqkupkkpxnflmyakuyqomnkqapkfaykpflnykdklpumpnpqoqnkkddfddadqlylayymxkfmndkpyumpnflmnxfmadoflaxxkuuunfnnfyynxmfxfdxdxoanqapommnxfklpoxukopanlfdkpxyadxfynfuyoadllmknddpyakxudluffkqolmyqxonlnolunnolukmqnpuauylokqfaynmolkpnxkumonmuykpmudynlylfdlpouqpmaddqlydffaokaqqnany";

            string ret = "NO";
            var s11 = s1.Distinct();
            var s22 = s2.Distinct();
            if (s11.Intersect(s2).Any())
            {
                ret = "YES";
            }
            Console.WriteLine(ret);
        }
        private static void MissingNumbers()
        {
            int[] arr = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            // sort both arry
            Array.Sort(arr);
            Array.Sort(brr);

            IEnumerable<int> d1 =  arr.Distinct();
            IEnumerable<int> d2 = brr.Distinct();

            ArrayList al = new ArrayList();
   
            foreach (var item in d1)
            {
                int count1 = 0;
                int count2 = 0;
                int i = 0;

                while (i < arr.Length)
                {
                    if (item==arr[i] )
                    {
                        count1++;   
                    }                        
                    i++;
                }
                int j = 0;
                while (j < brr.Length)
                {
                    if (item==brr[j])
                    {
                        count2++;    
                    }                        
                    j++;
                }
                if (count1 > count2)
                {
                    al.Add(item);
                }
                else if(count1 < count2)
                {
                    al.Add(item);
                }
                else
                {
                    continue;
                }
            }
            int[] res = al.OfType<int>().ToArray();
        }

        private static void SubsetsWithAUniqueSum()
        {
            string[] v = Console.ReadLine().Split(new char[] {' '});
            int k = Convert.ToInt32(v[1]);
            string[] sv = Console.ReadLine().Split(new char[] { ' ' });
            int[] s = Array.ConvertAll(sv, x => int.Parse(x));

            int sum = 0;
            List<int> lst = new List<int>();
            for(int i=0; i<s.Length-(k-1); i++)
            {
                int a = s[i];
                int b = i+1, c=0;
                while(b<s.Length)
                {
                    c = b;
                    while (c<s.Length-1)
                    {
                        c++;
                        int temp = s[i] + s[b] + s[c];
                        if (lst.Contains(temp))
                        {
                            lst.Remove(temp);                            
                        }
                        else { lst.Add(temp); }
                    }
                    b++;
                }
            }
            foreach (var item in lst)
            {
                sum = sum + item;
                Console.WriteLine(sum);
            }
        }

        private static void FunnyString()
        {
            string s = "acxz";
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            string r = new string(c);
            string ret = "Not funny";
            int count=0;
            for(int i=1; i<s.Length; i++)
            {
                int val = s[i] - s[i - 1];
                int val2 = Math.Abs(r[i] - r[i - 1]);
                if(val != val2)
                    break;
                else
                {
                    count++;
                    continue;
                }
            }
            if(count==s.Length-1)
            {
                Console.WriteLine( "Funny");
            }
        }

        private static void FindMaximumSubArrayAddition()
        {
            long[] a = new long[] { 3, 3, 9, 9, 5 };
            long m = 7;

            long temp = 0;
            List<long> lst = new List<long>();
            int count = 1;
            for (int i = 0; i < a.LongLength; i++)
            {
                int j = i;
                while (j < a.LongLength )
                {
                    int k = 0;
                    int x = j;
                    temp = 0;
                    while (k < count)
                    {
                        temp = temp + a[j];
                        k++;
                        j--;
                    }
                    j = x;
                    temp = temp % m;
                    lst.Add(temp);
                    j++;
                }
                count++;
            }
            Console.WriteLine(lst.Max(x => x));
        }

        private static void Pairs()
        {
            string str = "1 5 3 4 2";
            string[] str1 = str.Split(' ');
            int[] nums = Array.ConvertAll(str1, Int32.Parse);
            int k = 2;
            int i = 0, j = 1, count = 0;
            Array.Sort(nums);
            while (j < nums.Length)
            {
                var diff = nums[j] - nums[i];

                if (diff == k)
                {
                    count++;
                    j++;
                }
                else if (diff > k)
                {
                    i++;
                }
                else if (diff < k)
                {
                    j++;
                }
            }
            Console.WriteLine(count);       //Output: 43253
        }

        private static void MininumLoss()
        {
            int[] p = new int[] { 5,10,3 };

            int min = p[0];
            int temp = 0;
            for (int i = 0; i < p.Length; i++)
            {
                int j = i + 1;                
                while (j<p.Length)
                {
                    if (p[j] < p[i])
                    {
                        temp = p[i] - p[j];
                        if (temp <min)
                        {
                            min = temp;
                        }
                    }
                    j++;
                }                
            }
            Console.WriteLine(min);
        }

        private static void IceCreameParlor()
        {
            int m = 4;
            int[] arr = new int[] { 2 ,2, 4, 3};

            int[] a = new int[2];
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 0;
                while (j < arr.Length)
                {
                    if (i != j)
                    {
                        if (m == arr[i] + arr[j])
                        {
                            a = new int[] { i + 1, j + 1 };
                            found = true;
                            break;
                        }
                    }
                    j++;
                }
                if (found)
                {
                    break;
                }
            }
            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }
            
        }

        private static void BetweenTwoSets()
        {
            int[] a = { 1};  //1
            int[] b = {72,48 }; // 72,48--o/p - 8 //100 -o/p: 9
            int x = 1;
            List<int> lst = new List<int>();
            while (x <= 100)
            {
                Boolean b1 = true;
                for (int i = 0; i < a.Length; i++)
                {
                    if (x % a[i] != 0)
                    {
                        x++;
                        b1 = false;
                        break;
                    }
                }
                if (b1)
                {
                    int c = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (b[j] % x != 0)
                        {
                            x++;
                            break;
                        }
                        c++;
                    }
                    if (c==b.Length)
                    {
                        lst.Add(x);
                        x++;
                    }     
                }                
            }
            Console.WriteLine(lst.Count);
        }

        private static void DayOfTheProgrammer()
        {
            int year = 1918;
            string ret = String.Empty;
            int days = 31 + 31 + 30 + 31 + 30 + 31 + 31;
            Boolean leap = false;
            if (year <= 1917 && year >= 1700)
            {
                if (year % 4 == 0)
                {
                    leap = true;
                }
            }
            
            if (year >= 1919)
            {
                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                {
                    leap = true;
                }
            }

            if (leap)
            {
                days = days + 29;
                int diff = 256 - days;
                ret = diff + "." + "09" + "." + year;
            }
            else
            {
                if (year == 1918)
                {
                    days = days +15;
                    int d2 = 256 - days;
                    ret = d2 + "." + "09" + "." + year;
                }
                else
                {
                    days = days + 28;
                    int d = 256 - days;
                    ret = d + "." + "09" + "." + year;
                }
            }
            Console.WriteLine(ret);
        }

        private static void FindCaesarCipher()
        {
            string s = "Hello_World!";
            int k = 8;

            StringBuilder sb = new StringBuilder();
            Byte[] bytes = Encoding.ASCII.GetBytes(s);
            foreach (byte b in bytes)
            {
                int i=0;
                k = k % 26;
                if(b >64 && b <91)
                {
                    i = b + k;
                    if (i>90)
                    {
                        i = i - 90;
                        i = 64 + i;
                    }
                    char c = Convert.ToChar(i);
                    sb.Append(c);
                }
                else if(b>96 && b<123)
                {
                    i = b + k;
                    if (i > 122) 
                    {
                        i = i - 122;
                        i = 96 + i;
                    }
                    char c = Convert.ToChar(i);
                    sb.Append(c);
                }
                else
                {
                    sb.Append(Convert.ToChar(b));
                }
                //if (b != 45)
                //{
                //    int i = b + k;
                //    if(i>122)
                //    {
                //        i = i - 122;
                //        i = 96 + i;
                //    }
                //    char c = Convert.ToChar(i);
                //    sb.Append(c);
                //}
                    
                
            }
            Console.WriteLine(sb.ToString());
        }

        private static void FindLonelyInteger()
        {
            int[] a = new int[] {34, 95, 34, 64, 45, 95, 16, 80, 80, 75, 3, 25, 75, 25, 31, 3, 64, 16, 31};

            if (a.Length ==1)
            {
                Console.WriteLine(a[0]);
            }

            int val = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                int j = 0;
                while (j < a.Length)
                {
                    if (i !=j)
                    {
                        if (a[i] == a[j])
                        {
                            val = a[i];
                            count++;
                            break;
                        }
                    }
                    j++;                  
                }
                if (count == 1)
                {
                    val = a[i];
                    break;
                }
            }
            Console.WriteLine(val);
        }

        private static void FindSubStringAsHackerrank()
        {
            string s = "eobzhylmpbzusxoregoaaktdmujvmqxksxnizeqqaxlbvkpdculskdzghysxjqvssyhvedwjhgxbwpozzdkzeqdyiupuegycqrajnirytljyphcnptugbzzcyaykeebzojzqbxixbtyofrqxrxbkzcuqjuxmbzyrdhlfcanpifrphphyyiuxrmtveedrkbuvvqezvjnergkglgepydfawekpctqprklejvzwxbzyyrvlwwfmtbkcimycaibrlbeourwnozcqhivyftifseeoditykszusyyfztwjodhclvjgwsvulqlmaddpnssgutespkyrsclyoenuzjagssqielhajdwpwzrpwbzkskuoikdkubmsxiwbtuswemqreguafhjwaozwwgxnnzfgxxivvdeuzhizvlhbzwjqyrhatuqpixdblhsfwlmyqsmrylotserddrbltefxaadzahieerxyaavlpguxuiwqamasmcufxtkcowdcikgyyqrimrhxieddawuchtgpestbyzpeedfjjedctwdwhytgtitvwonculywpdvlsebazzqroglxkegxztdcquhjiqnyubkskeegmneofvbybeoaeybluimrnozromhxkstehpuetbhfcalyxgzqzaqkpuguwzfezcxrylvztyehesjtbzdipvgygrqegytxmhmmnwpqkyjgsmeqsgceqtbnkmoaxzrgbjvmlmmtuuyurosjwvuoxogmtfjswbjtqexyzavktrptxbwxaradcugsmpqbszjmcefkrqqupzxxylcosifilravaizewtmivmqozqomhegzxfokldmovgzgdycxdffiqtgitaxbcpkgbkjltkunfwqexwojrcqhduwikcngnfzpubrwlsjtluktowswghncnbrtfiakzuykhkzmyxbeifvcjllclooblaetedvdxfkittovyqdbnczbzieviqprwuznjmfylptzvkgzzffkoxtiyofdrxjgxknrsmmnodlymucosomsnhxctarlqfhplzsynidjffvdibummuorcuhrbmihvbuecccicradezaywmxxasgqekeakgatqsidjmjrwvozxyeocqffdmaenynryqvuybfqvkpoyclhqrgwbliyhjmgxgxikiysfpecheeqnaffmadkbndxrvylbygxdnlybqfyxresnpzooshqfwczlzkdiigfzumfuelastwhcmlhakqdajxtmccpdmvdxiplgipnwomsjweqbetyxwvbzjaaqsnhhmiuwpsjfbykbhyrxzlnyxlvezdsdvtyaqotafgtgholxjjdiiuulobgceufezpdtlplhbekfykntamakjkvwzvglbnohdioxzsvefffqtprncgmtuxpcpmodhwvnglenshwhllzkbrfxcrndtapvovcjxyldacwofsewiwctmmkswwykwqycvyehtswzxlqvlbewojmhbqhnvecxgbjhojdpjnmzkpyrgrsryuavalgneaydyujxbldhgtpjpbqpwmzbneijazuwmirabevsvhrdwjwxquyiyhpcaijsqxbxcvcvfxipwtnojxoctpqsdvhzpdzxajxpewpfilrceqbqdolsbceitvcwuuwetuufyluauaurmxbeyaemswvdvxuhjgjtutpcydcabglzijdgcerbvztbhfmcbgzsnydofvqmbbxsqhnxkpbbsymzuurmabneovgqgyzhkxcancthfcdndomwwounmdqwcmibbjhhjqjpgyyxrviatuttpfxvjufzrwrndgkqkyftageiqyzyuhyghxognzavjqwxqqjacznuawvlbzsvpmoyqqmhzwnfiqzipvcixapdqvvlahpyxcmkptlnfrgnqcmgrnnbvcdnxolyitzwsktdmpefsjgcyvveazbjgyzepulqicofothkdqqyvxpxrntovtcwclxixptymqkdgqgoclumnkfpgkbvmzhydimguptkywbcawckqjbxockduiwbbikywhwtxocdvmulucoccexmvszbicmcdgfqgzyyrwjmbuzsiktiidxysgzszqbtcxxjczloolrggjchotvpwjseslekpwjceoabfmdlatsyncbriwspyahevsxdzmeeifwzixfrqmwcyakbpeupmmbwwsdqvmvgacbpldvlcrxztelmumeuanxajkotiirpvmjaouchayclcgrvlgyhgvbjthjijpaemtmegvmfssvhtnmjlrohyzmruzqmebptvlroebiucxxkchyawwgxxgtnwbksbiylofpkjpwuvawuqnotorqsxqirrvuzeomqujryeivxxocbvnylumrblpusgriiaoxerbxnydpvngbojbwadwlpdfpppkfnfybillwaphezscznydxraxapeotffllktncdteyxqcthqlzqujeniapdbrovjdyrmzyfnvyrmmyeivuzglywbxibfmgpwjatotuhohikilwiihlrcnhjeazhqirmrvdinvnhnssapxwcdeohevrkghwgmtlsxcqhizqyypqptonktjhdhixwxtmsgwryuazivculzayrrwovetkynzrulpdffuuwipfjogyocqzxnnsqjrhlggsgicvbfbgcxcznlenyoqjtraprbzyunfikxcjfeatybuvfxdvgewvucmyhalxlsdjdzguumweakgcpiuzywhrwdmpxwbgkoanemsammoiungoevvluhfaylgrefysgcyflvhffneuyjrojglbtonjzsnqzxejjqrvdcratqwowfpjfplcwcofhuftzcgdwefustmuybhxqojjjyexxfuocqnbxcziobmfrzcdexioyazlbgpqkhvpkwwurylgqmzrowrzmdfzhioomdsemfuduuatnjztzklkcsrcbgfpuhdtpnvvoacylhfchhtnebzeonwkxoxzbqaahipjojnofgqrfadbmyahohjijdeuifjyvelpqlnxomhujjzgrktfewdwjnlneujnzwjpwxcxjcipazkkxpbauknwzojpvbqunvrxcsfcoeltcgrslrfylbeqicvglmkesteuclonjdqvlblfyqnyiktlyyqikeihgapstjfhqphvzlkvkmgduccjdouinjaxsilmmfcygamjorwwubojcnypnxcykoaxbacpwzlyxhkqaqlvtolspdpmgrsehdzbiablodrzommbaamvsfzokqdtgujujuoiwjemqptpmpqnshyqspatxlemwgqnyzgipevlgfnxmdfgrsnekgmvotmnbiuymjvwufabnqkaskglifpkpgvgcvfyclfyhmeeanuyahsqqkpsexzeqwkkgdkmqkhjtrvjiivpkqwgpnmrtegbezljegrkdixfacqifkefhygodiyoufuwmrgutluelkeekzuubqciofkonrcbvkjdrxzyxcwwwdebmehbtapioswehhqdxstvkzdprgfdlzhxrrnjsbcuxxcxrqufryidzkaoncdwxmopeqxpzsicyystxzuqdzatxnyceqarddqlguhtxknyofrqpntuctdybfkrxjruarjcbewstdnslnheoqqdckutliwnqoozlcveebaortfyfhrdazdkwlrmowajadqhsmrrhexkjpgtztydrjsrqmdtxdykqtedxcvldgdikqsoalxvecsgbkgwgjybozszhouagvatuovxwextoirjvxxchdkxyzqmcozynfhvilteaostnmglqayyjgojpngeeqzpaoxarwwuxeszdgxzrgvwjybacxzjfruxdfyjoswknmjbluvqkyhgrmuzzxnwxwprdeamysofpspwjbgtwronxebhukklzbterqxrcuxcxyoguiqtyuxkytijzpjooajlakhzxauazfjxnbaanndnqqcbbcyruyhwdahupguylyjefesxxckmcvzrtwnarfgbqhabgulnxbeuiqgzivmcruqvrdytpszcgvkuydlwvbrnxdwterbffsgwurwdrgziqvbcwjthfnvgtrwsnlgrylcwhavxlizqagnotmqghtwfkxvdusfgotgkxxopeapgisiblxyoyjhrnqifzuszhuzbkasjfqbsngfpxooanacswvusmignifwwoawbulbhifvqulxdqqceklgfdejpeatuuztrcyzofbgjylrysgdkrbpqhdbxckqzxnjdqlpdabjkuqnqacebrdcbirwufxxxqgagemyknymiowzuhpjbacjajwieydppujogtltiizeqdvitbtbafzcrhyqxiboxzfaatgikxeisoccqxiukcoonjshgpbrucfrbezhfmjmsrwlhcfqftlmvttditrpjtqentefsjipupmabmbetvioxrgydmfapthenwfcycdxhbbgrmwlydamonxwszijjdwczvmpieopamqviumxaiyltctykqsesattodiejcejokxzfjpkiyjwxnvywnzzrayievazfrrchbvrydwruzwqqkjldowmpdzlxknfqslbsftgtlinzdezoacylvyiiepxpgvvmxiyusxvpuphsooqhsvjaawbkomnsastrjsyosjnqbrdtpamshghbettqwadluewlnmwpsgfkauvrdyngnuurorxumtlvnvoodewyudfevxtnmoipzjuvmuzhrnzbobwotpxfbdjmfdocuhlrfxcuimaxivyssvjqscrbbiagkjzikefvlzjlzkubsomscujberuwbhutodnmpckzjcemyidedstramjtcjsvvxjqlrumpuoujvdmwbrtbsawstiykkifxhvhtxuchefxwujoswnbcqsbioeoltkijsgwgdqudhklaljxpxnzrtttnfvmewidditgvfnztehowgrmugijkutwcdbaefbmhvepiiqhmbjxptvoqjvstxamnubcjfyquiecgnirryhrlykwjxdqjwutekdkeiutfkokwufucflrrjaynasftkoephgjoxgtqjxmnpcxvjebwspxszpxygvrllmkqglxavpottgxfzxyoescouqyqmmiuseanoyvrliakzakcxceifbcccslvxmywwonldcjwdsarhgdgaqxatfpkjjimqkyilpnawpmgaqweozsgfrujueszjtbhjfzzsialaglnjmpuecvjrulfgscwxtwcpirxehzzoecyscobypqokhxgvysuganhywrjthbfuafasctysizgmwlsmwmoejnyvlpnhuydufbmfapuvoqpysxhuhzaobvqxnvwsvjoxltyqstmpndcujlvuvunwuhggiwjhxwlboripisuseuhqgbwwawidhogmmrhojcnhgydnuberanhpioarfkretasqbejkbytnrkogsuhzcqmvpqclfftravzzrrroawyclrgvgoyedckgxufzuknbmzzlnilulisbnxtueljexnjffhcokprdtgrhtilaknwqxbztxipbqkwbrhhghybbfbnrobnacxpdrhucsgmmpufalunmzzmjlsildhhlbpgtvpliqbstpmgzvnploffjxhvykhrtxxsonvzrsftszslxxufnjkmpdxkihchkdmbrtlgtiqvjzwijqqwynglmcxiptknftyzsxowpnrfmaiwryqzzlguyxzdfizbrvfodpntgfuibklajcczisksanhzdgszhjqhegpbrwrnknmlvgppuzothlftlyamsgrhqsubopmhxtolltvmaddrcgdifropisdulrmoiroqjnrjanynbxqgffavrsustoezbxqertdgndfohwuwkvkxcarngycxhaavcqfowjxsvdflwummkvyuymofqpsoxxtvuditeylshopxtlvemxemtdfmpzixrnsjbfawlybuwafpdmdexatybstfhowumrmkjkohacwrxleswclvtmvsmbqymcizboomgvxlovbjtmwwmaoqkjxegysimkuiujlpnfmtkqwxtsyudirkmmnjbysvtlzrskhltnrkptrikjoivyqajynxxuplmduikczuwlipgglkrgrlyzkdgroktwzttzouhxvuorzxsuvggamlacwbttnhmqcwjsetbstagyebujpuhxhnmvdtymurozalwncrwvywduuolqtextagcfnxckxevrqzgpmdgojkjvtvqhapcqcotuxmoulpiyxwwqunawdszrwochgmvgdxgzyljaqtnbitdumwxxqchnusvyswsjmnpzooqqwsvohufnkakqmldchfckjtnghhqjujxutiexbrenybejqbfysiawvbdelvuijjepqgclbdzqxpcriosxppvhbbrghvzdhehhoskxyucpylrwyshkjaylgargctknozkottfnmfgbmvrhdwxlhbooyvopiriobyydjpfhtdkgzibmcvpjgwbzwacwzcncfoictfrdneoydgimuwwgttgbzviveiagrwkssxynrokcfrpnsdcvtqlbybdwfcuwuxxfmoycninrvfbqiyeapnotenedkuwnodvfwsqxoilogjesenbujnzzlknpujedweeflotmamxlhazkvimfgusvkrtpxqrjtxlswspytkdufgvyicrzwqfrdtyhxlectqisjdpnewatmvwqjwilpahkrzrpsbbmikdsrubzgkjdejgetchbmvqqebmgheplzaupqhwmnobnnzctdmggxpuhiwvmvjkuvntyxvyniqytmeewwjqsclplrealtbwclokffhaurqftrcgmbsfylyngilinnmovoyrndfiicwpjfkbgioptlrsrixjqblytoawteghedirwuelvszrwerkycpiikqkpuonincucrbsgvvytitnfkyjaezokjopndbshbivcnckwleyifhivqwtowkcgobgwogyujvfncqhjdsnmisdcqqnelqtdaqorgwzzfnbwnqirmsyndtrikizozaewhxqhslsjzyqgykqjlzmeibxyiklfuxvnvfnegtdqsmqxtasriwspwqvmxesidnfxibyvhrfjbqutmqqaihwvxnfkebqdjryfbardewekubkllbrtuqlabmhtayfjcryzsrckfikvyfgwdsnvdbaqkggqiwhiprdmagyqasyjydebnkdavodrraplgwsusjoxxiluzptgrqueriwsvocfkjgczysjgqhdvhufnknmsowebgqgjdzytdhjvwmggnwhjqbtgyqmnqtsfoydigcdyzswtkjjnsyclbyfkpgarssugrhjygplpjdqtkiohymagubzcnmnyohckwthweogvohxvpmrzssigeofpgsbodtycwbaaouorkojurkvcjhtfjszfkczwdoijyafdpqsslfjveiujzbyxezbadtyatbczitjsgjxiwddzilitnefnlyirdqkbvcgxsxarmrplrpgcutxysxnghmcvjfkwmjvxqoqbflautmsvfwlpqteirnguhsasziundswzetrxjrcbdwjpmqlqmnoeadunatidqpywbvfsoocjhsirqeluqdpcsmpnelsqvvgqlxcdnvcwxcbwuqnzyrbbxmipvmfnrrhzgewepbnkfkjrkpdevmgirtllzbqyqmcxurgxrauvgnfgebttczcofzqznxnyxwpxyfiandjekmzndaepsurhxtxkdizraidatgbgrbcaabxjntmgcifpqfmbgdpiiiembdseiklklrfzwzgegdexujjhtvynbqdulmyhhvxwrjtqtoorrskraswkobdptyjldhyjyfhzyfbzxuajsuabpphrpugrluorwukkswonxqygwomvyslpgnujrudpvcwzjxjebmkdqyijtupwrerfyvmueiemytyxmorohyoarjxlpmdjjpdrgdolxizycehulzbwhskboxvrvnvljjeaqnimbrfpkfipcrfdttoxxjuavvxmrqtttcsttdlvzsyscaxiytcskzrudprvondiskekugukiouexoalssshquvdvvvkptbjdjdqatjczvgdxgtafyqhofpijioowamdudaoagcvjdhehbymhfjtaucxpyshnffgmbckwczzexvjrseqkgfiespynmzzzjqjnzvcrlnssstkgivzvamsycnlueocecbhhrtdyzeubyaqrdetizyuzsmojfekqqlkyfykmwtvnxhdsukmbmmwjeffpribjlajqupjsgondwdmjbgifmwlohhvudnhgqtubcionetvushdaaqxcqupymilywa";
            string org = "hackerrank";
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (j<org.Length && s[i] == org[j])
                {
                    j++;
                }
            }
            if (j == org.Length)
            {
                Console.WriteLine("YES");
            }
            else
                Console.WriteLine("NO");
        }

        private static void FindSubstring()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int q = Convert.ToInt32(tokens_n[1]);
            string s = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbfefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefeefeefefeefefeefeefefvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvddvddvdvddvdvddvddvdvddvdvddvddvdvdtbtbbtbtbbtbbtbtbbtbtbbtbbtbtbbtbbtbtbbtbtbbtbbtbtbbtbtbbtbbtbtbbtbbtbtbbtbtbbkrkrrkrkrrkrrkrkrrkrkrrkrrkrkrrkrrkdsdssdsdssdssdsdssdsdsbbbbbbbbbbbbbbbbbbbbbbbbbbbpbpihmiqoyrufakigfvuygumaxadgulmhvgjwkvwztiitrzeekjwofeweljjpovbxcsptoubkbwdhuevenunkdihviazzniynifemteabxzzhbgesjxjwlinoswmplbzqxdskndmbojzmwszzgzavjgfxxtlvtilsncpilivurbkfryjywbwjuohfckgavuflwnjhofthtkwowqfdfdlunousyvengfefdkccmjwajrxzvzbqykfqewbywskdqvdcnfwifebmxrmpdcwwwwvxwvsijnexvlalavsuxtojamyelihms";
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_left = Console.ReadLine().Split(' ');
                int left = Convert.ToInt32(tokens_left[0]);
                int right =Convert.ToInt32(tokens_left[1]);
                // your code goes here

                string s1 = s.Substring(left, (right - left) + 1);

                List<string> lst = new List<string>();
                int k = s1.Length;
                int l = 1;
                for (int i = 0; i < s1.Length; i++)
                {
                    k = k - i;
                    int m = 0;
                    while (k > 0)
                    {
                        if (lst.Contains(s1.Substring(m, l)))
                        {
                            m++;
                            k--;
                            continue;
                        }
                        else
                        {
                            lst.Add(s1.Substring(m, l));
                        }
                        m++;
                        k--;
                    }
                    k = s1.Length;
                    l++;
                }
                Console.WriteLine(lst.Count);
            }
        }

        private static void SuperReducingString()
        {
            string s = "bb";
            string temp = s;
            int i = 0;
            while (temp.Length > 0)
            {
                if (i!= temp.Length && temp[i] != temp[i + 1])
                {
                    i++;
                    if (temp.Length==i+1)
                    {
                        break;
                    }
                    continue;
                }
                else if(temp[i] == temp[i + 1])
                {
                    temp = temp.Remove(i, 2);
                    i = 0;
                }
            }
            Console.WriteLine(temp);
        }

        private static void CheckBeautifulString()
        {
            string str = "91011";
            string t = "";
            for(int i =0; i<str.Length-1; i++)
            {
                t += str[i];
                int val = Convert.ToInt32(t);
                int n = val + 1;
                string str1 = n.ToString();
                t += str1;
                i = i + str1.Length;
                if (t.Length==str.Length)
                {
                    if(t==str)
                    {
                        Console.WriteLine("Yes {0}", str[0]);
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                //// Get first index.               
                //if (i == 0)
                //{
                //    t = str[i].ToString();
                //}
                //int val = Convert.ToInt32(t);
                //int n = val + 1;
                //string str1 = n.ToString();

                //int j = i+1;
                //int k = 0;
                //while(k < str1.Length )
                //{
                //    string ss1 = str1[k].ToString();
                //    string ss2 = str[j].ToString();
                //    if( ss1== ss2)
                //    {
                //        k++;
                //        j++;
                //    }
                //    else
                //    {
                //        str1 = str[i] +""+ str[j];
                //        t = str1;
                //        j--;
                //        break;
                //    }
                //}
                //if (str1.Length==k)
                //{
                //    t = str1;
                //    //i = j - 2;
                //}
                //i = j;
            }
        }
                
        private static void ApplyResourceFile()
        {
            string[] cultureNames = { "en-US", "sv-SE" };
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("Strings", "Resources", null);

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                string greeting = rm.GetString("Greeting", CultureInfo.CurrentCulture);
                Console.WriteLine("\n{0}!", greeting);
                Console.Write(rm.GetString("Prompt", CultureInfo.CurrentCulture));
                string name = Console.ReadLine();
                if (!String.IsNullOrEmpty(name))
                    Console.WriteLine("{0}, {1}!", greeting, name);
            }
            Console.WriteLine();
        }

        private static void AppleOrangeRange()
        {

            int[] apple = new int[] { -2, 2, 1 };
            int[] orange = new int[] { 5, -6 };
            int s = 7;
            int t = 11;
            int a = 5; int b = 15;
            int m = apple.Length;
            int n = orange.Length;

            for (int i = 0; i < m; i++)
            {
                int tmp = 0;
                if (apple[i] > 0)
                    tmp = a + apple[i];
                else
                    tmp = a + apple[i];
                apple[i] = tmp;
            }

            int temp = 0;
            for (int j = 0; j < n; j++)
            {
                if (orange[j] > 0)
                    temp = b + orange[j];
                else
                    temp = b + orange[j];
                orange[j] = temp;
            }

            int appCount = 0;
            int orgCount = 0;
            for (int k = 0; k < m; k++)
            {
                if (s <=apple[k] && apple[k] <= t)
                {
                    appCount++;
                }
            }
            for (int l = 0; l < n; l++)
            {
                if (s<=orange[l] && orange[l] <= t)
                {
                    orgCount++;
                }
            }

            Console.WriteLine(appCount);
            Console.WriteLine(orgCount);
        }

        private static void RondingStudentGrade()
        {
            int[] grades = new int[] { 73, 67, 38, 33 };

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 40)
                {
                    int min = 40 - grades[i];
                    if (min < 3)
                    {
                        grades[i] = CalculateMultiple(grades[i]);
                    }
                }
                else
                {
                    grades[i] = CalculateMultiple(grades[i]);
                }
            }

            for(int j=0; j<grades.Length; j++)
            {
                Console.WriteLine(grades[j]);
            }
        }

        private static int CalculateMultiple(int grade)
        {
            // Find the multiple of 5
            int temp = grade;
            int finalGrade = grade;

            bool div = true;
            while (div)
            {
                if (temp % 5 == 0)
                {
                    div = false;
                    continue;
                }
                else
                {
                    div = true;
                }
                temp = temp + 1;
            }
            int diff = temp - grade;
            if (diff < 3)
            {
                finalGrade = temp;
            }
            else
            {
                finalGrade = grade;
            }
            return finalGrade;
        }

        private static string ReduceString()
        {
            string temp = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            int j = 0;

            if (temp.Length > 0)
            {
                for (int i = 1; i < temp.Length; i++)
                {
                    if (temp.Length == 2)
                    {
                        i = 0;
                    }
                    j = i -1;                    

                    if (temp[i] != temp[j])
                    {
                        continue;
                    }
                    else if (temp[i] == temp[j])
                    {
                        temp = temp.Remove(i, 2);
                    }
                }
            }
            else
            {
                return string.Empty;
            }
            if (temp.Length == 0)
                return "Empty String";

            return temp;
        }
    }

    public class DelegateDemo
    {
        public delegate int Del(string message);
        
        //create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}