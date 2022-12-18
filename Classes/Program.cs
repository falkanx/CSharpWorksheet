using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager=new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer=new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Furkan";
            customer.LastName = "Alkan";

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Kemal", LastName = "Usta"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
