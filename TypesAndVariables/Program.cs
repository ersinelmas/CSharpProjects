using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var number = 7;

            byte num1 = 255;
            short num2 = 15151;
            int num3 = 100022050;
            long num4 = 2485119615145;

            double num5 = 10.4;
            decimal num6 = 10.500025M;

            Console.WriteLine("Number 1 is {0}", num1);
            Console.WriteLine("Number 2 is {0}", num2);
            Console.WriteLine("Number 3 is {0}", num3);
            Console.WriteLine("Number 4 is {0}", num4);
            Console.WriteLine("Number 5 is {0}", num5);
            Console.WriteLine("Number 6 is {0}", num6);

            Console.WriteLine(Days.Monday);
            
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
