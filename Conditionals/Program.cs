using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 89;
            // IF ELSE CONDITION TEST
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if(number ==20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}
            // SWİTCH CASE CONDITION TEST
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}
            // MULTİ CONDITIONS TEST
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            // NESTED CONDITION TEST
            if (number<=100)
            {
                if (number>=90)
                {
                    Console.WriteLine("Number is between 90-100");
                }
                else
                {
                    Console.WriteLine("Number is less than 90");
                }


            }

            Console.ReadLine();
        }
    }
}
