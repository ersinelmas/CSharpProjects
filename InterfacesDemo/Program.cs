using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers) {
                worker.Work();
            }

            IEater[] eaters = new IEater[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eater in eaters) {
                eater.Eat();
            }

            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEater
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEater, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager is eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager is getting salary");
        }

        public void Work()
        {
            Console.WriteLine("Manager is working");
        }
    }

    class Worker : IWorker, IEater, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker is eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker is getting salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker is working");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working");
        }
    }
}
