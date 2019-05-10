using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMSDN
{
    public class T1
    {
        public static int publicInt;
        internal static int internalInt;
        private static int privateInt = 0;

        static T1()
        {
            M1.publicInt = 1;
            M1.internalInt =2;            
            M2.publicInt = 3;
            M2.internalInt = 4;
        }

        public class M1
        {
            public static int publicInt;
            internal static int internalInt;
            private static int privateInt = 0;
        }

        private class M2
        {
            public static int publicInt = 0;
            internal static int internalInt = 0;
            private static int privateInt = 0;
        }
    }

    class AccessModifiersDemo
    {
        //Public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        // private: The type or member can be accessed only by code in the same class or struct.
        // protected: The type or member can be accessed only by code in the same class, or in a class that is deriver from that class.
        // internal: The type or memeber can be accessed any code in the same assembly, but not from another assembly.
        // protected internal: the type or member can be accessed by any code in the assembly in which it is declared, or from within a derived class in another assembly.
        // private internal: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived that class.

        public static void AccessModifierMethod()
        {
            T1.publicInt = 1;
            T1.internalInt = 2;
            // T1.privateInt = 3; inaccessible due to its protection level
            T1.M1.publicInt = 1;
            T1.M1.internalInt = 2;

            //T1.M1.privateInt = 3;
            //T1.M2.publicInt = 1;    // inaccessible outside T1
            //T1.M2.internalInt = 2;  // inaccessible outside T1
            //T1.M2.privateInt = 3;   // inaccessible outside M2
        }
    }
}
