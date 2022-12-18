using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types
            // Console.WriteLine("Hello World!");
            // double used to hold decimal numbers
            double number5 = 10.4;
            // decimal used to convert integers to decimals
            decimal number6 = 10;
            // char
            char character = 'A';
            // conditions True Or False
            bool condition = false;
            // byte max value 0 and 255
            byte number4 = 255;
            // short max value 32767 and -32768
            short number3 = 32767;
            // int max value 2147483647 and -2147483648
            int number1 = 2147483647;
            // long max value 9223372036854775807 and -9223372036854775808
            long number2 = 9223372036854775807;
            // var keeps the value assigned to the variable in the value's type.
            var number7 = 10;
            // number7 = "A";
            
            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("condition {0}", condition);
            Console.WriteLine("Character is : {0}",(int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday=10,Tuesday=20,Wednesday=30,Thursday,Friday,Saturday,Sunday
    }
}
