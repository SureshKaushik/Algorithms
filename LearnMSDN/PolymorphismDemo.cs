using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get;private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

    class Circle: Shape
    {
        public override void Draw()
        {
            // code to draw a circle...
            Console.WriteLine("Drawing a circle");
            base.Draw();
        }
    }

    class Rectangle: Shape
    {
        public override void Draw()
        {
            // Code to draw a rectangle...
            Console.WriteLine("Drawing a Rectangle");
            base.Draw();
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            // Code to draw Triangle...
            Console.WriteLine("Drawing a Triangle");
            base.Draw();
        }
    }

    #region Polymorphism Overview - Virtual Members
    public class BaseClassVirtual
    {
        public virtual void DoWork() { }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClassVirtual : BaseClassVirtual
    {
        public override void DoWork() { }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }
    #endregion

    #region Polymorphism Overview - Hiding base class members with new members
    public class BaseClass
    {
        public void DoWork() { WorkField++; }
        public int WorkField;
        public int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DerivedClass : BaseClass
    {
        public new void DoWork() { WorkField++; }
        public new int WorkField;
        public new int WorkProperty
        {
            get { return 0; }
        }
    }
    #endregion

    #region Poly Overview - Preventing derived classes from overriding virtual members
    public class A
    {
        public virtual void DoWork() { }
    }
    public class B : A
    {
        public override void DoWork() { }        
    }
    public class C : B
    {
        public sealed override void DoWork() { }
    }
    public class D : C
    {
        public new void DoWork() { }
    }

    #endregion

    #region Poly Overview - Accessing Base class virtual members from derived classes
    public class Base
    {
        public virtual void DoWork() { }
    }

    public class Derived : Base
    {
        public override void DoWork()
        {
            // Perform derived's work here
            //...
            // call DoWork on base class
            base.DoWork();
        }
    }
    #endregion

    class PolymorphismDemo
    {
        public static void PolymorphismDemoMethod()
        {
            // Poly 1: A Rectangle, Triangle and Circle can all be used whereever a Shape is expected.
            // no cast is required because implicit conversion exits from a derived class to its base class.
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Circle(),
                new Triangle()
            };

            //  Poly 2: the virtual method Daw is invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        public static void HideBaseClassMemMethod()
        {
            DerivedClass B = new DerivedClass();
            B.DoWork();             // Class the new method.
            Console.WriteLine(B.WorkField.ToString());

            BaseClass A1 =(BaseClass) B;
            A1.DoWork();     // Calls the old method
            Console.WriteLine(A1.WorkField.ToString());
        }

        public static void VirtualMemberMethod()
        {
            DerivedClassVirtual B = new DerivedClassVirtual();
            B.DoWork(); 

            BaseClassVirtual A =(BaseClassVirtual) B;
            A.DoWork();
        }
    }
}
