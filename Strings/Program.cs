using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Ersin Elmas";
            var result = sentence.Length;

            bool result1 = sentence.EndsWith("s");
            bool result2 = sentence.StartsWith("m");

            var result3 = sentence.IndexOf("is");
            var result4 = sentence.IndexOf(" ");
            var result5 = sentence.LastIndexOf(" ");
            var result6 = sentence.Insert(0, "Hello, ");
            var result7 = sentence.Substring(0, 5);
            var result8 = sentence.Replace(" ", "_");


            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
