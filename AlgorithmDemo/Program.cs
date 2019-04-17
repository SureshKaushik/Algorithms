using ImplementDataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    class BaseCls
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");


        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }
    class ChildCls: BaseCls
    {
        public override void Method1()
        {
            Console.WriteLine("Child - Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("Child - Method2");
        }
    }

    class Car
    {
        public void DescribeCar()
        {
            Console.WriteLine("Four wheels and an engines.");
            ShowDetails();
        }

        public void ShowDetails()
        {
            Console.WriteLine("Standard transportation.");
        }
    }

    class ConvertibleCar: Car
    {
        public void ShowDetails()
        {
            Console.WriteLine("A roof that opens up.");
        }
    }

    class MiniVan: Car
    {
        public void ShowDetails()
        {
            Console.WriteLine("Carries seven peoples.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {



            //DesignPatternDemo.AbstractFactoryPatternDemo();
            //DesignPatternDemo.FactoryMethodDemo();
            //DesignPatternDemo.SingletonPatternDemo();
            //CheckInheritanceFeature();
            //Car c1 = new Car();
            //c1.DescribeCar();
            //c1.ShowDetails();

            //ConvertibleCar c2 = new ConvertibleCar();

            //DelegateCall();

            //EventCall();

            //DISample.CallConstructorInjection();
            // DISample.CallPropertyInjection();

           // Console.ReadLine();

            //ChildCls c2 = new BaseCls();
            //c2.Print();

            /*
            AddTwoNumbers();

            add.Add();

            DisplayArrayElements();
            
            SelectBestCandidate();


                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i] + " ");
                }

                Console.WriteLine("Bubble Sort: ");

            DriveInfoClassDemo();
            LinkedListOps.CountLinkedList();

            Square sq = new Square(12);
            Console.WriteLine("Area of square = {0}", sq.Area());

            DerivedClass dc = new DerivedClass();
            dc.AbstractMethod();
            Console.WriteLine("x = {0}, y = {1}", dc.X, dc.Y);

            DelegateCall();

            EventCall();

            LinqDemo.MergeListRemoveDuplicate();
            LinqDemo.GetListCustomers();
            ArrayDemo.RotateArrayBasedonPivot();
            ArrayDemo.FindSumofTwoElement(6);
            LinqDemo.MergeTwoSortedArray();
            ThreadStartDemo();

            ArrayDemo.PolindromCheck();
            ArrayDemo.FindPolindromeFromString();

            CallBaseClass.Call();

            NCERT_Maths10.CalculateHCF(225,135);
            NCERT_Maths10.FindPrimeNumber();
            NCERT_Maths10.CreatePrimeNumber();
            ArrayDemo.FindDuplicateValueFromArray();
            ArrayDemo.FindkthSmallestElement(2);
            StringDemo.StringConcat();
            double amount = 10000;

            for (int year = 1; year <= 3; year++)
            { 
                Console.WriteLine("Please enter investment type: ");
                string investType = Console.ReadLine();
                double profit = InvestmentStrategy.InvestPlanning(amount, year, investType);
                Console.WriteLine("Total profit of amount: {0} is {1}.", amount, profit);
                amount = amount + profit;
            }
            Console.WriteLine("Total amount is {0}", amount);

            RodCuttingProblem.FibonacciSeries();
            int[] A = { 10, 8, 2, 9, 5, 6 };
            int p=0;
            int r = A.Length;
            RodCuttingProblem.MergeSort(A, p, r);

            RodCuttingProblem.FindRepeatedElement();
            ReverseArrayUsingFunc();

            ReverseArray();

            FindSmallestLargestCount();

             Start: Another
            Console.WriteLine("Hello World!");

            BaseDerivedClassDemo();
            int value;
            OutExample.Method(out value);
            Console.WriteLine("Out value: " + value);

             Another Solution: Program page
            Console.Write("Hello World !");

            List<Shape> lstShape = new List<Shape>();

            lstShape.Add(new Rentangle());
            lstShape.Add(new Circle());
            lstShape.Add(new Triangle());

            foreach (var s in lstShape)
            {
                s.Draw();
            }

            BaseClass bc = new BaseClass();
            bc.DoWork();

            DerivedClass dc = new DerivedClass();
            dc.DoWork();

            BaseClass bcd = new DerivedClass();
            bcd.DoWork();


             It is useful to create directory i.e. folder (.Net Framework)
            Directory.CreateDirectory("C:\\FileProgramDemo");

            string machineName = Environment.MachineName;
            OperatingSystem os =  Environment.OSVersion;
            int numberOfProcessors = Environment.ProcessorCount;
            bool is64Bit = Environment.Is64BitProcess;
            bool isCLRShuttingDownStarted = Environment.HasShutdownStarted;
            string sysDirectory = Environment.SystemDirectory;

            Console.WriteLine("Machine Name: " + machineName + "Operating System Version: " + os);
            Console.WriteLine("Number of Processors: " + numberOfProcessors);
            Console.WriteLine("IS 64 Bit Process: " + is64Bit);
            Console.WriteLine("IS CLR shutting down started: " + isCLRShuttingDownStarted);
            Console.WriteLine("System Directory Full Path: " + sysDirectory);

            //Get logical drives

            string[] drives = Environment.GetLogicalDrives();

            foreach(string dr in drives)
            {
                DriveInfo di = new DriveInfo(dr);
                long totalFreeSpace = di.TotalFreeSpace;
                long totalSize = di.TotalSize;

                Console.WriteLine("Total Free Space in the Drive {0}: " + totalFreeSpace);
                Console.WriteLine("Total Size: " + totalSize);

                if (!di.IsReady)
                    Console.WriteLine("Drive is not ready.", di.Name);

                DirectoryInfo dirInfo = di.RootDirectory;
            }

            GenericList<int> intList = new GenericList<int>();
            intList.Add(10);
             >
            intList.Add(20);

            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("Suresh");
            stringList.Add("Manish");
            stringList.Add("Ajay");

            GenericList<GenericExample> lstGenericExample = new GenericList<GenericExample>();
            lstGenericExample.Add(new GenericExample());
            lstGenericExample.Add(new GenericExample());

             Generic class


            try
            {
                TestThrow();
            }
            catch (CustomeException ex)
            {                
                Console.WriteLine(ex.InnerException.Message);
            }

            var list = new List<string>();
            list.Add("Ramesh");
            list.Add("Manish");
            list.Add("Raju");

            // Collection list type as int
            var numbers = new List<int> { 10, 11, 22, 3, 4, 5, 6, 7, 8, 9 };

            for (var index = numbers.Count - 1; index >= 0; index--)
            {
                // Remove odd value from list.
                if (numbers[index] % 2 == 1)
                {
                    numbers.RemoveAt(index);
                }
            }

            numbers.Sort();
            int num = numbers.BinarySearch(25);

            Console.WriteLine("FInd num: " + num);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


             Dictionary Demo.
            Dictionary<string, Person> dictPersons = new Dictionary<string, Person>();

            try
            {
                dictPersons.Add("Manish",
                 new Person
                 {
                     Name = "manish",
                     PersonalNumber = "11026934",
                     EnterpriseNumber = "manish.yadav",
                     Age = 22
                 }
                );

                dictPersons.Add("Ajay",
                    new Person
                    {
                        Name = "Ajay",
                        PersonalNumber = "11026935",
                        EnterpriseNumber = "ajay.kesherwani",
                        Age = 23
                    });

                dictPersons.Add("Suresh",
                        new Person
                        {
                            Name = "Suresh",
                            PersonalNumber = "11026924",
                            EnterpriseNumber = "suresh.kumar.kaushik",
                            Age=25
                        });

                foreach (KeyValuePair<string, Person> kvp in dictPersons)
                {
                    Console.WriteLine(kvp.Key + " Name: " + kvp.Value.Name + "  Personal Number: " + kvp.Value.PersonalNumber);
                }

                if (dictPersons.ContainsKey("Raju") == true)
                {
                    Console.WriteLine("Key contains: ");
                }
                else
                    Console.WriteLine("Not contains");

                Person person = null;
                if (dictPersons.TryGetValue("Raju", out person) == false)
                {
                    Console.WriteLine("Key Not Found !");
                }
                else
                    Console.WriteLine("Key Found : " + person.Name);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception occured due to ArgumentException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured due to Exception other than ArgumentException: " + ex.Message);
            }

            // Collectionlist with Custome type
            var personList = new List<Person>
            {
                new Person {Name="Suresh", PersonalNumber ="11026924", EnterpriseNumber = "suresh.kumar.kaushik"},
                new Person {Name="Manish", PersonalNumber="123456789", EnterpriseNumber="manish.yadav"}
            };

            foreach (Person person in personList)
            {
                Console.WriteLine(person.Name + " " + person.PersonalNumber + " " + person.EnterpriseNumber);
            }

            foreach (string names in list)
            {
                Console.WriteLine(names);
            }

            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine(list[index]);
            }

             Kind of Collections

             1. System.Collections.Generics
             2. System.Collections.Concurrent
             3. System.Collections
             4. Visual basic collection class

             Using LINQ to Access a collection

            List<int> intList1 = new List<int> { 1, 2, 3 };
            List<int> intList2 = new List<int> { 2, 4, 5, 3 };

            var uniqueList = intList1.Concat(intList2).Distinct();

            foreach (var item in uniqueList)
            {
                Console.WriteLine(item);
            }

            var cars = new List<Car>
            {
                new Car {Name = "car1", Color = "blue", Speed = 20},
                new Car {Name= "car2", Color = "green", Speed=50},
                new Car {Name= "car3", Color = "yellow", Speed = 20},
                new Car{Name = "car4", Color = "green", Speed = 50},
                new Car {Name = "car5", Color = "blue", Speed = 20},
                new Car {Name = "car6", Color = "yellow", Speed = 20}
            };

            cars.Sort();

            foreach(var car in cars)
            {
                Console.WriteLine("Name: " + car.Name + "  Color: " + car.Color + "  Speed: " + car.Speed);
            }

             Defining a custom collection.
            var colors = new AllColor();

            foreach (Color color in colors)
            {
                Console.WriteLine(color.Name + " ");
            }

            Iterators.

            foreach (int number in EvenSequence(5, 18))
            {
                Console.WriteLine(number.ToString() + " ");
            }

            Student myStudent = new Student();
            myStudent.firstName = "Suresh";
            myStudent.lastName = "Kaushik";
            myStudent.score1 = 90;
            myStudent.score2 = 80;

            double avg = myStudent.CalcAverage();
            Console.WriteLine("Average: " + avg);

            StudentClass myStudentClass = new StudentClass();
            myStudentClass.score1 = 90;
            myStudentClass.score2 = 95;

            avg = myStudentClass.CalcAverage();
            Console.WriteLine("Student Class Average: " + avg);

            Employee Suresh = new Employee("Suresh Kaushik", "Thanda", "Hyderabad", "Telangana State", "5000081");

            Suresh.Insurance = new InsuranceInfo() { Name = "Child Policy", ID = 10003 };

            Manager Raju = new Manager("Raju Sinha", "Madhapur", "Hyderabad", "TS", "457986423");

            Console.WriteLine(Suresh.ToString());
            Console.WriteLine(Raju.DoWork());

            Employee Manish = new Manager("Manish Yadav", "SBSE area", "Korba", "CG", "456789");

            Console.WriteLine(Suresh.DoWork("Reading"));
            Console.WriteLine(Raju.DoWork());
            Console.WriteLine(Raju.DoWork("Programming"));
            Console.WriteLine("Manager Manish : " + Manish.DoWork("Playing"));

            Console.WriteLine("===================");

            List<Employee> employees = new List<Employee>();
            employees.Add(Suresh);
            employees.Add(Raju);
            employees.Add(Manish);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }

            Console.ReadKey();
            //End: Program page

            int value = 1;
            RefExample.Method(ref value);
            Console.WriteLine("ref example: " + value);
            Console.ReadKey();
            //End: Another
            
            // Start: Event and delegates
            var clock = new Clock();
            var logger = new Logger();
            var visibleClass = new VisibleClock();
            visibleClass.Subscribe(clock);
            logger.Subscribe(clock);
            clock.RunClock();
            //End: Event and delegate            
            FindDuplicateString();
            FindMaxFromArray();
            LinkedListCount();
            StringDemo.CheckStringContainsPolindrome();

            Base A = new Base();
            Console.WriteLine("From base Class: ");
            A.Print();
            A.PrintAbstract();

            Derived B = new Derived();
            Console.WriteLine("From Derived class..");
            B.Print();
            B.PrintAbstract();

            Base a1 = new Derived();
            a1.Print();

            Derived b1 = new Base();
            b1.Print();

            HashtableDemo.Hashtable();
            
            OverrideNewKeywordDemo obj = new OverrideNewKeywordDemo();
            obj.Call();
             * 
             * */

            //ReplaceSentence();

            //int[] A = new int[10];
            //Random rd = new Random();
            //for (int i = 0; i < A.Length; i++)
            //{   
            //    A[i] = rd.Next(1, 10);
            //}

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //int n=10, sum = 0;
            //for (int j = 0; j < n - 1; n++)
            //{
            //    sum = sum + A[i] * b ^ j;
            //}

            //DelegateCall();

            StringDemo.StringMatchingBruteForce();


            // Shallow and Deep copy demo

            ShallowAndDeepCopyExample.ShallowAndDeep();


            Console.ReadLine();
        }

        private static void LeftRotate()
        {
            int k = 2;
            int j;
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (k > 0)
                {
                    temp = a[i];
                    k--;
                }
                j = i + 1;
                if (j <= a.Length - 1)
                    a[i] = a[j];

                if (j == a.Length)
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

            for (int i = 0; i < Arr.Length; i++)
            {
                int j = 0;
                while (j < Arr.Length)
                {
                    if (i == j)
                    {
                        j++;
                        continue;
                    }

                    if (i < j)
                    {
                        if (Arr[i] > Arr[j])
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
                L[i] = A[p + i - 1];
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
            for (int k = p - 1; k < r; k++)
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



        private static void BitArrayAddition()
        {
            int[] A = { 1, 2, 3, 4 };
            int[] B = { 2, 3, 4, 6 };
            int[] C = new int[A.Length];

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            for (int j = 0; j < C.Length; j++)
            {
                Console.WriteLine(C[j]);
            }

            Console.WriteLine("----------------------------------");

            string[] C1 = new string[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                // Convert to Binary element.
                string bitString = ConvertToBinary(A[i] + B[i]);
                C1[i] = bitString;
            }

            for (int j = 0; j < C1.Length; j++)
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



        private static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        private static void CheckInheritanceFeature()
        {
            BaseCls b1 = new BaseCls();
            b1.Method1();
            b1.Method2();

            ChildCls c1 = new ChildCls();
            c1.Method1();
            c1.Method2();

            BaseCls b2 = new ChildCls();
            b2.Method1();
            b2.Method2();

            //ChildCls cb = new BaseCls();            
        }

        public static void StreamReadWrite()
        {
            //Get directory information from c drive.
            DirectoryInfo[] dirs = new DirectoryInfo(@"C:\").GetDirectories();

            //Write to Writetxt.txt file line by line using StreamWriter.
            using(StreamWriter writer = new StreamWriter(@"c:\Writetxt.txt"))
            {
                foreach(DirectoryInfo di in dirs)
                {
                    writer.Write(di.Name);
                }
            }

            //Read Writetxt.txt file and display to Screen.
            string line = "";
            using(StreamReader reader = new StreamReader(@"c:\Writetxt.txt"))
            {
                if ((line = reader.ReadLine()) != null)
                {
                    
                }
            }
        }

        public static void ReplaceSentence()
        {
            string str = "Hello this is Suresh Kumar Kaushik";

            str = str.Replace(' ', '_');
            Console.WriteLine(str);
        }

        private static void AddTwoNumbers()
        {
            Console.WriteLine("Please enter num1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter num2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            AddTwoNumbers add = new AddTwoNumbers(num1, num2);
        }

        private static void DisplayArrayElements()
        {
            Console.WriteLine("Hello World!");

            int[] num = { 12, 5, 4, 3, 1, 10, 8 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        

        private static void SelectBestCandidate()
        {
            int[] score = { 70, 50, 60, 90, 80 };
            int bestscore = 70;

            int[] bestCandidate = new int[score.Length];
            int count = 0;
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= bestscore)
                {
                    bestCandidate[count] = score[i];
                    count++;
                }
            }

            for (int j = 0; j < count; j++)
            {
                if (bestCandidate[j] != 0)
                {
                    Console.WriteLine(bestCandidate[j]);
                }
            }
        }

        private static void DriveInfoClassDemo()
        {
            DriveInfoClass dic = new DriveInfoClass();
            dic.GetDriveInfoDetails();

            DriveInfoClass.ListDirectories(new System.IO.DirectoryInfo(@"C:\Program Files"), "*a*", 5, 0);

            try
            {
                DriveInfoClass.DirectoryMove("D:\\Accenture", "D:\\Hello World\\TestMove");
                DriveInfoClass.GetDirectoryUsingFile();
                DriveInfoClass.DeleteFile();
                DriveInfoClass.CopyFiles();
                DriveInfoClass.GetPathDetails();

                DriveInfoClass.FileCreateTextDemo();

                DriveInfoClass.WebRequestDemo();

                string data;

                //Task<data> = DriveInfoClass.CreateandWriteAsyncToFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DelegateCall()
        {
            DelegateTest dt = new DelegateTest();
            dt.DelegateMethod();

            DelegateCalculator dc = new DelegateCalculator();
            dc.Calculate();
        }

        private static void EventCall()
        {
            EventDemo ed = new EventDemo();
            ed.RaiseSampleEvent();
            //ArrayDemo.BinarySearch();
            Console.ReadLine();

            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total.");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        private static void ThreadStartDemo()
        {
            ThreadDemo td = new ThreadDemo();
            Thread t = new Thread(new ThreadStart(td.Beta));
            t.Start();
            while (!t.IsAlive) ;
            Thread.Sleep(100);
            t.Abort();
            t.Join();
            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished.");
            try
            {
                Console.WriteLine("Try to restart the Beta method.");
                t.Start();
            }
            catch (ThreadStateException e)
            {
                Console.WriteLine("Exception occured: {0}", e.Message);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Environment.Exit(0);
        }

        private static void LinkedListCount()
        {
            LinkedListDemo head = new LinkedListDemo();
            head.Data = 1;

            LinkedListDemo second = new LinkedListDemo();
            second.Data = 2;

            LinkedListDemo third = new LinkedListDemo();
            third.Data = 3;

            head.Next = second;
            second.Next = third;

            int counter = 0;
            LinkedListDemo current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
                counter++;
            }
            Console.WriteLine("Total count in LinkedList is: {0}", counter);
        }
        public static void FindMaxFromArray()
        {
            int[] A = { 95, 78, 88, 99 };

            int max = A[0];
            int i = 1;
            while (i < A.Length)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                i++;
            }
            //Output: 99
            Console.WriteLine("Max value is: {0}", max);
        }

        public static void FindSecondMaxFromArray()
        {
            int[] A = { 80, 90, 99 };
            //Output: 90
        }

        public static void FibonacciSeries()
        {
            int i = 0, j = 1, result;
            Console.Write(i + " " + j);

            // Using iterative
            //for (int k = 2; k < 10; k++)
            //{
            //    result = i + j;
            //    Console.Write(" " + result + " ");
            //    i = j;
            //    j = result;
            //}

            int n = 0;
            while (n < 5)
            {
                int l = FindFibSeries(i, j);
                Console.Write(" " + l + " ");
                i = j;
                j = l;
                n++;
            }
        }
        public static int FindFibSeries(int i, int j)
        {
            int result;
            return result = i + j;
        }

        

        public static void FindRepeatedElement()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 10 };
            int status = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (A[i] != A[j])
                        continue;
                    else
                    {
                        status = A[i];
                        break;
                    }
                }
            }

            if (status != 0)
            {
                Console.WriteLine("Repeated element found: {0}", status);
            }
        }

        public static void FindDuplicateString()
        {
            string s1 = "kumarkaushik";
            string s2 = null;
            //string[] s2 = new string[s1.Length];
            ArrayList al = new ArrayList();
            ArrayList al2 = new ArrayList();
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    //Console.WriteLine(s1[i]);
                    if (i != j && s1[i] == s1[j])
                    {
                        //if (!al.Contains(s1[i]))
                        //{
                        //al.Add(s1[i]);
                        s2 = s1.Remove(j, 1);
                        //}
                    }
                }
            }
            for (int i = 0; i < s2.Length; i++)
            {
                Console.Write(s2[i] + " ");
            }
            //foreach(char ch in al)
            //{
            //    int ind = s1.IndexOf(ch);
            //    if (s1.Contains(ch))
            //    {
            //        s1.Remove(ind, 1);
            //    }
            //    Console.Write(ch + " ");
            //}
        }

        private static void BaseDerivedClassDemo()
        {
            Base b = new Base();
            b.Print();

            Derived d = new Derived();
            d.Print();

            Base b1 = new Derived();
            b1.Print();

            //Derived d1 = new Base();
            //d1.Print();
        }
        public class OutExample
        {
            public static void Method(out int num)
            {
                num = 40;
            }

            //public static void SampleMethod(out int i)
            //{
            //    i = 50;
            //}

            //public static void SampleMethod(ref int i)
            //{ }

            public void SampleMethod(int i)
            { }

            public void SampleMethod(out int i)
            {
                i = 60;
            }
        }

        public class RefExample
        {
            public static void Method(ref int i)
            {
                i = i + 44;
            }
        }

        class Base
        {
            public void Print()
            {
                Console.WriteLine("base - Print()");
            }

            public virtual void PrintAbstract()
            {
                Console.WriteLine("Hello from base..");
            }
        }
        class Derived : Base
        {
            public void Print()
            {
                Console.WriteLine("derived - Print()");
            }

            public virtual void PrintAbstract()
            {
                Console.WriteLine("Hello form derived..");
            }
        }

        private static void ReverseArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 8, 10 };

            Console.WriteLine("Simple Array element.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            int first = 0;
            int last = array.Length - 1;

            while (first < array.Length / 2)
            {
                //update array using swaping.        
                int temp = array[first];
                array[first] = array[last];
                array[last] = temp;
                first = first + 1;
                last = last - 1;
            }
            Console.WriteLine("Reverse array element: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void ReverseArrayUsingFunc()
        {
            ArrayList list = new ArrayList { 1, 2, 3, 4 };

            list.Reverse();

            foreach (int element in list)
            {
                Console.WriteLine(element + " ");
            }
        }
    }        
    public class ThreadDemo
    {
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Beta method called in its own thread.");
            }
        }
    }
    public class InvestmentStrategy
    {
        public static double InvestPlanning(double amountInvest, int year, string investType)
        {
            double profit = 0;
            switch (investType)
            {
                case "FD":
                    profit = amountInvest * 0.09 * year;
                    break;
                case "RD":
                    profit = amountInvest * 0.08 * year;
                    break;
                default:
                    profit = amountInvest * 0.07 * year;
                    break;
            }
            return profit;
        }
    }

    public class RodCuttingProblem
    {
        public static double RodCutting()
        {
            int n = 0;
            if (n == 0)
            {
                return 0;
            }
            int q = 0;
            for (int i = 1; i <= n; i++)
            {
                //q = max(q, P[i] + RodCutting(P, n - i));
            }
            return 0.0;
        }
    }
    class LinkedListDemo
    {
        public int Data { get; set; }
        public LinkedListDemo Next { get; set; }
    }
}
