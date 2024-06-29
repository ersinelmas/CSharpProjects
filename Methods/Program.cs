using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var res = AddWithParams(15, 28);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        
        static int AddWithParams(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
