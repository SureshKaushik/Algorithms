using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaysianNetwork.Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindProbabilityOfCancer();
            Console.ReadLine();
        }
    }
//        public static void FindProbabilityOfCancer()
//        {
//            //find Smoker = Y, Smoker = N
//            Console.WriteLine("Enter Yes or No.");
//            string smoker = Console.ReadLine();

//            if(smoker.ToLower()=="yes")
//            {
//                //H-B-F, H-L-F
//                Console.WriteLine("Enter Bromchitis present then Yes else No");
//                string bromC = Console.ReadLine();
//                if (bromC.ToLower() == "yes")
//                {

//                }
//            }

//            if(smoker.ToLower()=="no")
//            {
//                Console.WriteLine("Not smoker");
//            }

//        }

//        public static void SampleExample1()
//        {
////            Example 5.1 Suppose your favorite stock NASDIP is down-graded by a reputable
////analyst and it plummets from $40 to $10 per share. You feel this is a good
////buy, but there is a lot of uncertainty involved. NASDIP’s quarterly earnings are
////about to be released and you think they will be good, which should positively influence
////its market value. However, you also think there is a good chance the whole
////market will crash, which will negatively influence NASDIP’s market value. In
////an attempt to quantify your uncertainty, you decide there is a .25 probability
////            the market will crash, in which you case feel NASDIP will go to $5 by the end
////of the month. If the market does not crash, you feel by the end of the month
////NASDIP will be either at $10 or at $20 depending on the earnings report. You
////think it is twice as likely it will be at $20 as at $10. So you assign a .5 probability
////to NASDIP being at $20 and a .25 probability to it being at $10 at month end.
////Your decision now is whether to buy 100 shares of NASDIP for $1000 or to
////leave the $1000 in the bank where it will earn .005 interest in the next month.
////            One way to make your decision is to determine the expected value of your
////investment if you purchase NASDIP and compare that value to the amount of
////money you would have if you put the money in the bank. Let X be a random
////variable, whose value is the worth of your $1000 investment in one month if you
////purchase NASDIP. If NASDIP goes to $5, your investment will be worth $500,
////if it stays at $10, your investment will be worth $1000, and if it goes to $20, it
////will be worth $2000. Therefore,

//            // .5 % -----------$20 ........... 100 shares
//            // .25%------------$10
//                 }
//    }

    //public interface ICloningService
    //{
    //    T Clone<T>(T source);
    //}

    //public class CloningService : ICloningService
    //{
    //    public T Clone<T>(T source)
    //    {
    //        // Please implement this method
    //        //throw new NotImplementedException();
    //         return (T)this.MemberwiseClone();
    //    }

    //    // Feel free to add any other methods, classes, etc.
    //}

    //public enum CloningMode
    //{
    //    Deep = 0,
    //    Shallow = 1,
    //    Ignore = 2,
    //}

    //[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    //public sealed class CloneableAttribute : Attribute
    //{
    //    public CloningMode Mode { get; }

    //    public CloneableAttribute(CloningMode mode)
    //    {
    //        Mode = mode;
    //    }
    //}

    //public class CloningServiceTest
    //{
    //    public class Simple
    //    {
    //        public int I;
    //        public string S { get; set; }
    //        [Cloneable(CloningMode.Ignore)]
    //        public string Ignored { get; set; }
    //        [Cloneable(CloningMode.Shallow)]
    //        public object Shallow { get; set; }

    //        public virtual string Computed => S + I + Shallow;
    //    }

    //    public struct SimpleStruct
    //    {
    //        public int I;
    //        public string S { get; set; }
    //        [Cloneable(CloningMode.Ignore)]
    //        public string Ignored { get; set; }

    //        public string Computed => S + I;

    //        public SimpleStruct(int i, string s)
    //        {
    //            I = i;
    //            S = s;
    //            Ignored = null;
    //        }
    //    }

    //    public class Simple2 : Simple
    //    {
    //        public double D;
    //        public SimpleStruct SS;
    //        public override string Computed => S + I + D + SS.Computed;
    //    }

    //    public class Node
    //    {
    //        public Node Left;
    //        public Node Right;
    //        public object Value;
    //        public int TotalNodeCount =>
    //            1 + (Left?.TotalNodeCount ?? 0) + (Right?.TotalNodeCount ?? 0);
    //    }

    //    public ICloningService Cloner = new CloningService();
    //    public Action[] AllTests => new Action[] {
    //        SimpleTest,
    //        SimpleStructTest,
    //        Simple2Test,
    //        NodeTest,
    //        ArrayTest,
    //        CollectionTest,
    //        ArrayTest2,
    //        CollectionTest2,
    //        MixedCollectionTest,
    //        RecursionTest,
    //        RecursionTest2,
    //        PerformanceTest,
    //    };

    //    public static void Assert(bool criteria)
    //    {
    //        if (!criteria)
    //            throw new InvalidOperationException("Assertion failed.");
    //    }

    //    public void Measure(string title, Action test)
    //    {
    //        test(); // Warmup
    //        var sw = new Stopwatch();
    //        GC.Collect();
    //        sw.Start();
    //        test();
    //        sw.Stop();
    //        Console.WriteLine("{title}: {sw.Elapsed.TotalMilliseconds:0.000}ms");
    //    }

        //public void SimpleTest()
        //{
        //    var s = new Simple() {I = 1, S = "2", Ignored = "3", Shallow = new object()};
        //    var c = Cloner.Clone(s);
        //    Assert(s != c);
        //    Assert(s.Computed == c.Computed);
        //    Assert(c.Ignored == null);
        //    Assert(ReferenceEquals(s.Shallow, c.Shallow));
        //}

        //public void SimpleStructTest()
        //{
        //    var s = new SimpleStruct(1, "2") {Ignored = "3"};
        //    var c = Cloner.Clone(s);
        //    Assert(s.Computed == c.Computed);
        //    Assert(c.Ignored == null);
        //}

        //public void Simple2Test()
        //{
        //    var s = new Simple2() {
        //        I = 1,
        //        S = "2",
        //        D = 3,
        //        SS = new SimpleStruct(3, "4"),
        //    };
        //    var c = Cloner.Clone(s);
        //    Assert(s != c);
        //    Assert(s.Computed == c.Computed);
        //}

    //    public void NodeTest()
    //    {
    //        var s = new Node {
    //            Left = new Node {
    //                Right = new Node()
    //            },
    //            Right = new Node()
    //        };
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(s.TotalNodeCount == c.TotalNodeCount);
    //    }

    //    public void RecursionTest()
    //    {
    //        var s = new Node();
    //        s.Left = s;
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(null == c.Right);
    //        Assert(c == c.Left);
    //    }

    //    public void ArrayTest()
    //    {
    //        var n = new Node {
    //            Left = new Node {
    //                Right = new Node()
    //            },
    //            Right = new Node()
    //        };
    //        var s = new[] {n, n};
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(s.Sum(n1 => n1.TotalNodeCount) == c.Sum(n1 => n1.TotalNodeCount));
    //        Assert(c[0] == c[1]);
    //    }

    //    public void CollectionTest()
    //    {
    //        var n = new Node {
    //            Left = new Node {
    //                Right = new Node()
    //            },
    //            Right = new Node()
    //        };
    //        var s = new List<Node>() {n, n};
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(s.Sum(n1 => n1.TotalNodeCount) == c.Sum(n1 => n1.TotalNodeCount));
    //        Assert(c[0] == c[1]);
    //    }

    //    public void ArrayTest2()
    //    {
    //        var s = new[] {new [] {1, 2, 3}, new [] {4, 5}};
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(15 == c.SelectMany(a => a).Sum());
    //    }

    //    public void CollectionTest2()
    //    {
    //        var s = new List<List<int>> {new List<int> {1, 2, 3}, new List<int> {4, 5}};
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(15 == c.SelectMany(a => a).Sum());
    //    }

    //    public void MixedCollectionTest()
    //    {
    //        var s = new List<IEnumerable<int[]>> {
    //            new List<int[]> {new [] {1}},
    //            new List<int[]> {new [] {2, 3}},
    //        };
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(6 == c.SelectMany(a => a.SelectMany(b => b)).Sum());
    //    }

    //    public void RecursionTest2()
    //    {
    //        var l = new List<Node>();
    //        var n = new Node { Value = l };
    //        n.Left = n;
    //        l.Add(n);
    //        var s = new object[] {null, l, n};
    //        s[0] = s;
    //        var c = Cloner.Clone(s);
    //        Assert(s != c);
    //        Assert(c[0] == c);
    //        var cl = (List<Node>) c[1];
    //        Assert(l != cl);
    //        var cn = cl[0];
    //        Assert(n != cn);
    //        Assert(cl == cn.Value);
    //        Assert(cn.Left == cn);
    //    }

    //    public void PerformanceTest()
    //    {
    //        Func<int, Node> makeTree = null;
    //        makeTree = depth => {
    //            if (depth == 0)
    //                return null;
    //            return new Node {
    //                Value = depth,
    //                Left = makeTree(depth - 1),
    //                Right = makeTree(depth - 1),
    //            };
    //        };
    //        for (var i = 10; i <= 20; i++) {
    //            var root = makeTree(i);
    //            Measure("Cloning {root.TotalNodeCount} nodes", () => {
    //                var copy = Cloner.Clone(root);
    //                Assert(root != copy);
    //            });
    //        }
    //    }

    //    public void RunAllTests()
    //    {
    //        foreach (var test in AllTests)
    //            test.Invoke();
    //        Console.WriteLine("Done.");
    //    }
    //}

    //public class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        var cloningServiceTest = new CloningServiceTest();
    //        var allTests = cloningServiceTest.AllTests;
    //        while (true) {
    //            var line = Console.ReadLine();
    //            if (string.IsNullOrEmpty(line))
    //                break;
    //            var test = allTests[int.Parse(line)];
    //            try {
    //                test.Invoke();
    //            }
    //            catch (Exception) {
    //                Console.WriteLine("Failed on {test.GetMethodInfo().Name}.");
    //            }
    //        }
    //        Console.WriteLine("Done.");
    //    }
    //}
}
