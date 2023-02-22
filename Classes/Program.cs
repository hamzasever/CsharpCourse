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
        {/*
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "İstanbul";
            customer.FirstName = "hamza";
            customer.LastName = "sever";

            //bu şekilde de nesne oluşturulabilir.
            Customer customer2 = new Customer
            {
                Id = 1,
                City = "Ankara",
                FirstName = "deniz",
                LastName = "sever"
            };

            Console.WriteLine(customer2.FirstName +" \n"+ customer2.LastName);
*/
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();

            customer.Id = 1;
            customer.FirstName = "hamza";
            customer.LastName = "sever";
            customer.City = "istanbul";
            

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "deniz",
                LastName = "sever",
                City = "istanbul"
            };

            Console.WriteLine(customer2.FirstName+" "+customer2.LastName);
            Console.ReadLine();

        }
    }
}

