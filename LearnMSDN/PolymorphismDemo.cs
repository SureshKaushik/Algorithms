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

    #region Versioning with override and virtual keywords
    /// <summary>
    /// /Example - 1
    /// </summary>
    class GraphicsClass
    {
        public virtual void DrawLine()
        {
            Console.WriteLine("Base class DrawLine method.");
        }
        public virtual void DrawPoint()
        {
            Console.WriteLine("Base class DrawPoint method.");
        }
    }

    class YourDerivedGraphicsClass:GraphicsClass
    {
        public void DrawRectangle()
        {
            Console.WriteLine("Derived class DrawRactangle method.");
        }

        public override void DrawLine()
        {
            Console.WriteLine("Derived class drawline implementation");
            //base.DrawLine();
        }

        public override void DrawPoint()
        {
            Console.WriteLine("Derived class drawPoint implementation");
            //base.DrawPoint();
        }
    }

    public class Base1
    {
        public virtual void DoWork(int param)
        {
            Console.WriteLine("Base, value: {0}", param);
        }
    }

    public class Derived1: Base1
    {
        public override void DoWork(int param)
        {
            Console.WriteLine("Derived, value: {0}", param);
            //base.DoWork(param);
        }
        public void DoWork(double param)
        {
            Console.WriteLine("Derived, value: {0}", param);
        }
    }

    #endregion

    #region When to use override and new keywords
    /// <summary>
    /// In c#, amethod in a derived class can have the same name as a method in the vase class.
    /// You can specify how the methods interact by using the new and override keywords.
    /// The override modifier extends the vase class methods, and the new modifier hides it.    
    /// </summary>
    class Base2
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }
    class Derived2:Base2
    {
        public void Method2()
        {
            Console.WriteLine("Derived- Method2");
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

        public static void VirtualMethodVersioning()
        {
            GraphicsClass baseClass = new GraphicsClass();
            baseClass.DrawLine();
            baseClass.DrawPoint();

            YourDerivedGraphicsClass derivedClass = new YourDerivedGraphicsClass();
            derivedClass.DrawLine();
            derivedClass.DrawPoint();
            derivedClass.DrawRectangle();
            ((GraphicsClass)derivedClass).DrawLine();

            //YourDerivedGraphicsClass derived2 = new GraphicsClass();            // Error: cannot implicit convert GraphicsClass to YourDerivedGraphicsClass
            //derived2.DrawLine();
            //derived2.DrawPoint();
            //derived2.DrawRectangle();

            GraphicsClass baseClass2 = new YourDerivedGraphicsClass();
            baseClass2.DrawLine();
            baseClass2.DrawPoint();                       

        }
        public static void VirtualMethodVersioning2()
        {
            int val= 5;

            Base1 b = new Base1();
            b.DoWork(val);

            //Derived1 d = b; //Error: cannot convert Base1 to Derived1 (Casting missing)
            //b.DoWork(5);

            Derived1 d1 = new Derived1();
            d1.DoWork(val);  // double/int param

            ((Base1)d1).DoWork(val);
        }
        public static void UseOverrideAndNew()
        {
            Base2 bc = new Base2();
            Derived2 dc = new Derived2();
            Base2 bcdc = new Derived2();

            bc.Method1();
            bc.Method2();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();
            bcdc.Method2();
        }
    }
}
