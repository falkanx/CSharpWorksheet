using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(), 
                new Worker(), 
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats=new IEat[2]
            {
                new Worker(), 
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager(),

            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

        }
    }

    interface IWorker
    {
        void Work();
    }
    //SOLID, Interface Segregation
    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }


    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("I am Manager and I am Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("I am Manager and I get my Salary.");
        }

        public void Work()
        {
            Console.WriteLine("I am Manager and I am Working");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("I am Worker and I am Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("I am Worker and I get my Salary.");
        }

        public void Work()
        {
            Console.WriteLine("I am Worker and I am Working");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I am Robot and I am Working");
        }
    }
}
