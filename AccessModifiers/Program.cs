using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // It is used without the need for reference in the project it is connected to.
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        // Used in inherited classes
        protected int Id { get; set; }
        // It is used only in the code block it is in.
        private string Name { get; set; }

        public void Save()
        {
          
            
        }

        public void Delete()
        {
            
        }
    }

    class Student:Customer
    {
        public void Save2()
        {
           
           
        }
    }
    // It is also used to work in other projects.
    public class Course
    {
        public string Name { get; set; }
    }
}
