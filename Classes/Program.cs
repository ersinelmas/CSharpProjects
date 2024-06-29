using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Remove();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();

            Customer customer = new Customer();
            customer.FirtName = "Test";
            customer.LastName = "Test";
            customer.City = "Test";
            customer.Id = 1;

            Customer customer2 = new Customer
            {
                City = "Test",
                Id = 2,
                LastName = "Test",
                FirtName = "Test",
            };

            Console.WriteLine(customer.FirtName);
            Console.ReadLine();
        }
    }
} 
