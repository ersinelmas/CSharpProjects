using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Ersin";
            string student2 = "Elmas";
            string student3 = "Özge";

            string[] students = {student1, student2, student3};
            foreach (string student in students) { 
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3]
            {
                {"İstanbul", "Bursa", "Kocaeli"},
                {"İzmir", "Manisa", "Aydın"},
                {"Antalya", "Adana", "Mersin"},
                {"Ankara", "Konya", "Kayseri"},
                {"Samsun", "Trabzon", "Ordu"},
                {"Van", "Malatya", "Elazığ"},
                {"Gaziantep", "Şanlıurfa", "Diyarbakır"}
            };
            Console.WriteLine("************");
            for (int i = 0; i <= regions.GetUpperBound(0); i++) {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) {
                    
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("************");
            }
            
            Console.ReadLine();
        }
    }
}
