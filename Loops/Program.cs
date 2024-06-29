using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i = i+2)
            {
                Console.WriteLine(i);
            }
            int number = 10;
            while (number>0)
            {
                Console.WriteLine(number);
                number--;
            }

            string[] names = {"Ersin"};
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false; break;
                }
            }
            return result;
        }
    }
}
