using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class Manager : Employee
    {
        public Manager(string name, string street, string city, string state, string postalCode)
            : base(name, street, city, state, postalCode)
        { 
        }

        public Manager(string name, string street, string city, string state, string postalCode, string salary)
            : base(name, street, city, state, postalCode, salary)
        { }

        public string ApprisalFeedback()
        {
            return "Manager is giving appraisal feedback.";
        }

        public override string DoWork()
        {
            return "Manager is doing work!";
        }

        public override string DoWork(string workType)
        {
            return "Manager: " + workType;
        }
    }
}
