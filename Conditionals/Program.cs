using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 12;

            if (number < 5)
            {
                Console.WriteLine("Number is less than 5");
                Console.ReadLine();
            }
            else if (number < 10)
            {
                Console.WriteLine("Number is less than 10");
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Number is something else");
                Console.ReadLine();
            }

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0 and 100");
                Console.ReadLine();
            }
            else if (number == 100 && number <= 200) {
                Console.WriteLine("Number is between 0 and 100");
                Console.ReadLine();
            }
            else if (number>200 || number < 0)
            {
                Console.WriteLine("Number is out of bonds");
                Console.ReadLine();
            }
        }
    }
}
