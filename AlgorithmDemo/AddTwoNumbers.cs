using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class AddTwoNumbers
    {
        private int Number2;
        private int Number1;
        public AddTwoNumbers(int num1, int num2)
        {
            this.Number1 = num1;
            this.Number2 = num2;
        }

        public void Add()
        {
            Console.WriteLine("Sum: {0}" , Number1 + Number2);
        }
    }
}
