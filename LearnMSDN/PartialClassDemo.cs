using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    #region Partial class demo1
    /// <summary>
    /// It is possible to split the definition of a class, a struct, an interface or a method 
    /// over two or more source files.
    /// Each source file contains a section of the type or method definition, 
    /// and all parts are combined when the application is compiled.
    /// </summary>
    

    /// Situaltions
    /// 1. When working on large projects, spreading a class over separate files enables multiple programmers to work on it an the same time.
    /// 2. When working with automatically generated source, code can be added to the class withoud having to 
    /// recreate the source file.
    /// Visual studio used this approach when it created Windows Forms, Web sevice wrapper code. and so on. You can created code
    /// that uses these classes withoud having to modify the file created by visual studio.
    ///
    public partial class Employee
    { 
        public void DoWork()
        { }
    }

    public partial class Employee
    {
        public void GoToLunch()
        { }
    }

    #endregion 

    #region Partial class demo2
    /// <summary>
    /// Partial class restrictions
    /// 1. All partial type definitions meant to be parts of the same type must be modified with partial.
    /// 2. The partial modifier can only appear immediatetly before the keywords class, struct, or interface.
    /// 3. Nested partial types are allowed in partial-type definitions
    /// 4. All partial-type definitions meants to be parts of the same type must be defined in the same assembly and the same module (.exe or .dll file)
    /// Partial definitions cannot span multiple modules.
    /// 5. The class name and generic-type parameters must match on all partial-type definitions.
    /// Generic types can be partial. Each partial declaration must use the same parameter names in the same order
    /// </summary>
    public partial class Coords
    {
        private int x;
        private int y;

        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Coords
    {
        public void PrintCoords()
        {
            Console.WriteLine("Coords: {0} {1}", x, y);
        }
    }
    #endregion 

    #region Partial interface and struct
    partial interface ITest
    {
        void Interface_Test();
    }

    partial interface ITest
    {
        void Interface_Test2();
    }

    partial struct S1
    {
        void Struct_Test() { }
    }
    partial struct S2
    {
        void Struct_Test2() { }
    }
    #endregion

    public class PartialClassDemo
    {
        #region Partial Method
        // Definition is file1.cs
        /// <summary>
        /// 1. Partial method decalrations must vegin with the contextual key partial and the method must return void.
        /// 2. Can have in or ref but not out parameters
        /// 3. are implicitly private, and therefore they cannot be virtual
        /// 4. cannnot be extern, because the prsence of the vody determines whether they are defining or implementing.
        /// 5. can have static and unsage modifiers.
        /// 6. can be generic.
        /// 7. the following kewords on a partial-type definition are option -> public, private, protected, internal, 
        /// abstract, sealed, base class, new modifier (nested parts), and generic constraints
        /// </summary>
        //partial void onNameChanged();

        // Implementation is file2.cs
        //partial void onNameChanged()
        //{
        //    // method body
        //}
        #endregion
        public static void PartialClassDemoMethod()
        {
            Coords myCoords = new Coords(10, 15);
            myCoords.PrintCoords();
        }
    }
}
