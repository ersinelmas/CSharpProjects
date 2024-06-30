using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Customer { Id = 1, Name = "Ali", Surname = "Veli", CreditCardNumber = "1234567890" },
                new Student { Id = 2, Name = "Ayşe", Surname = "Fatma", StudentNumber = "9876543210" },
                new Person { Id = 3, Name = "Hayri", Surname = "Kemal" }
            };  

            foreach (var person in people)
            {
                Console.WriteLine(person.Name +" "+ person.Surname);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Student : Person
    {
        public string StudentNumber { get; set; }
    }
}
