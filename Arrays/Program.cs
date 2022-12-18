using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        // Unidimensional Array
            // Beginner
            string[] students = new string[3];
            students[0] = "Furkan";
            students[1] = "Cagri";
            students[2] = "Kemal";
            // Elementary
            string[] students1 = new string[3]{ "Furkan", "Cagri", "Kemal" };
            // Intermediate
            string[] students2 = new[] { "Furkan", "Cagri", "Kemal" };
            // Advanced
            string[] students3 = { "Furkan", "Cagri", "Kemal" };
            // Error State exceeds student3 index limit
            //students3[3] = "Mustafa";

            foreach (var student in students3)
            {
                Console.WriteLine(student);
                Console.WriteLine("*********");
            }
        // Multi-Dimensional Array
            string[,] regions=new string[5,3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }

            Console.ReadLine();

        }
    }
}
