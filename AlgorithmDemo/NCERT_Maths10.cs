using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class NCERT_Maths10
    {
        /* To obtain the HCF of two positive integers, say c and d, with c > d, follow
        the steps below:
        Step 1 : Apply Euclid’s division lemma, to c and d. So, we find whole numbers, q and
        r such that c = dq + r, 0 ≤ r < d.
        Step 2 : If r = 0, d is the HCF of c and d. If r ≠ 0, apply the division lemma to d and r.
        Step 3 : Continue the process till the remainder is zero. The divisor at this stage will
        be the required HCF.
         * */

        /// <summary>
        /// Division Algorithm. Euclid's division lemma.
        /// </summary>
        /// <param name="value1">Value1</param>
        /// <param name="value2">Value2</param>
        public static void CalculateHCF(int value1, int value2)
        {
            int a = value1, b = value2;
            int hcfValue = 0;
            while (a > b)
            {
                int q = a / b;
                int r = a % b;
                if (r != 0)
                {                    
                    int val = b * q + r;
                    int temp = b;
                    b = r;
                    a = temp; 
                }
                else
                {
                    hcfValue = b;
                    break;
                }                
            }
            Console.WriteLine("a = {0} and b = {1}, HCF = {2}", value1, value2, hcfValue);
        }

        public static void FindPrimeNumber()
        {
            int num = 10;
            int k = 0;
            int i = 1;
            while (i < num)
            {
                if (num % i==0)
                {
                    k++;
                }
                i++;
            }
        }

        public static void CreatePrimeNumber()
        {
            int number = 100;
            bool isprime = true;
            for (int i = 2; i < number; i++)
            {
                for (int j = 2; j < number; j++)
                {
                    if ( i != j && i%j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    Console.Write(i + " ");
                }
                isprime = true;
            }
        }      
    }
}
