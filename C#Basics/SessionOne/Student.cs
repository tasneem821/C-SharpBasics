using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOne
{
    // simple class to used in naming and reference type
    internal class Student
    {
        public string FullName { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"the student name is {FullName}");
        }
    }
}
