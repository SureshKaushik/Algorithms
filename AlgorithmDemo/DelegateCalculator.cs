using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public delegate int CalcDelegate(int a, int b);
    class DelegateCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public void Calculate()
        {
            CalcDelegate cd = Add;
            int sum = cd(10, 20);
            Console.WriteLine("sum : {0}", sum);

            cd = Multiply;
            int mul = cd(5, 10);
            Console.WriteLine("multiply : {0}", mul);

            cd = Substract;
            int sub = cd(20, 10);
            Console.WriteLine("subtract:{0}", sub);

            cd = Divide;
            int div = cd(10, 2);
            Console.WriteLine("Divide: {0}", div);
        }

    }
}
