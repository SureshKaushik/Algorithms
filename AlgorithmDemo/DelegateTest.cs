using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    delegate double MathAction(double num);
    class DelegateTest
    {
        static double Double(double input)
        {
            return input * 2;
        }
        public void DelegateMethod()
        {
            MathAction ma = Double;
            double multiByTwo = ma(4.5);
            Console.WriteLine("multi By two : {0}", multiByTwo);

            //Instantiate delegate with anonymous method:
            MathAction ma2 = delegate(double input)
            {
                return input * input;
            };

            double square = ma2(5);
            Console.WriteLine("squar : {0}", square);

            // Instance delgete with lambda expression.
            MathAction ma3 = s => s * s * s;
            double cube = ma3(5);
            Console.WriteLine("cube : {0}", cube);
        }
    }
}
