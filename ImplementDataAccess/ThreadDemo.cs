using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class ThreadDemo
    {
        public void Beta()
        { 
            while(true)
            {
                Console.WriteLine("Beta method called in its own thread.");
            }
        }
    }
}
