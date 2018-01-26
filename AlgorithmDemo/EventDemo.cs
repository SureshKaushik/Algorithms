using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    public class SampleEventArgs
    {
        public SampleEventArgs(string s)
        { 
            Text = s;
            Console.WriteLine("Called: {0}", Text);
        }
        public string Text { get; private set; }  //readonly
    }
    public class EventDemo
    {
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);

        public event SampleEventHandler SampleEvent;

        public virtual void RaiseSampleEvent()
        {
            if (SampleEvent != null)
            {
                SampleEvent(this, new SampleEventArgs("Hello"));
            }
        }
    }
}
