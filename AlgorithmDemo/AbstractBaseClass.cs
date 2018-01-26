using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    abstract class AbstractBaseClass
    {

        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod();
        public abstract int X { get; }
        public abstract int Y { get; }
    }

    class DerivedClassAbs : AbstractBaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X
        {
            get { return _x + 10; }
        }

        public override int Y
        {
            get { return _y + 20; }
        }
    }

    public class Base
    {
        public virtual void Method1()
        { 
            Console.WriteLine("Base Class - m1"); 
        }

        public virtual void DoWork(int param)
        {
            Console.WriteLine("Base - Dowork");
        }

        //public void Method2()
        //{ Console.WriteLine("Base Class - m2"); }
    }
    public class Derived : Base 
    {
        public virtual void Method1()
        { 
            Console.WriteLine("Derived Class - m1"); 
        }
        public override void DoWork(int param)
        {
            Console.WriteLine("Derived - Dowork");
        }

        public void DoWork(double param)
        {
            Console.WriteLine("Drived - Dowork double");
        }

        //public void Method2()
        //{ }
    }
    public class AnotherDerived : Derived
    { 
        
    }

    public class CallBaseClass
    {
        public static void Call()
        {
            Base bc = new Base();
            bc.Method1();
            //bc.Method2();

            Derived dc = new Derived();
            dc.DoWork(10);

            ((Base)dc).DoWork(20);

            //Base bc1 = new Derived();
            //bc1.Method1();

            //AnotherDerived ad = new DerivedClass();
            //ad.Method1();
        }
    }

    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base = Mehtod2");
        }
    }
    
    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived new - Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

    public class OverrideNewKeywordDemo
    {
        public void Call()
        {
            BaseClass b = new BaseClass();
            b.Method1();
            b.Method2();

            DerivedClass d = new DerivedClass();
            d.Method1();
            d.Method2();

            b = (BaseClass) d;
            b.Method1();
            b.Method2();

            d =(DerivedClass) b;
            d.Method1();
            d.Method2();
        }
    }
}
