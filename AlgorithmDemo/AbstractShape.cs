using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    abstract class AbstractShape
    {
        abstract public int Area();
    }
    class Square : AbstractShape
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }

        interface I
        {
            void M();
        }

        abstract class C : I
        {
            public abstract void M();
        }

    }
}
