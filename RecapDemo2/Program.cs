using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator=new Creator();
            creator.Maker =new Animal();
            creator.Add();
            Console.ReadLine();
        }
    }

    class Creator
    {
        public IMaker Maker { get; set; }
        public void Add()
        {
            Maker.Log();
            Console.WriteLine("Living beings added!");
        }
    }

    class Animal:IMaker
    {
        public void Log()
        {
            Console.WriteLine("Animal Created!");
        }
    }

    class Monster : IMaker
    {
        public void Log()
        {
            Console.WriteLine("Monster Created!");
        }
    }

    class Human : IMaker
    {
        public void Log()
        {
            Console.WriteLine("Human Created!");
        }
    }

    interface IMaker
    {
        void Log();
    }
}
