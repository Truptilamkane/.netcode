using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class employee1
    {
        public string EName;
        public int EId;
        public string EGender;
       
        static void Main1(string[] args)
        {
            employee1 e = new employee1();
            Console.WriteLine(e.EName ="Shree");
            Console.WriteLine(e.EId = 11);
            Console.WriteLine(e.EGender = "Male");
        }
    }
}
