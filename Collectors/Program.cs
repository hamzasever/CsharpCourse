using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * ArrayMethod();
            List();*/

            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("Table","tablo");
            dictionary.Add("Computer","Bilgisayar");

         //   Console.WriteLine(dictionary["Table"]);
          //  Console.WriteLine(dictionary["Glass"]);
          foreach (var item in dictionary)
          {
              Console.WriteLine(item.Value);
            }

            // / Console.WriteLine(dictionary["Table"]);
            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));
            Console.ReadLine();

        }

        private static void List()
        {
            //tip güvenli koleksiyonlar
            List<string> cities = new List<string>();
            cities.Add("ankara");
            cities.Add("adana");

            cities.Add("istanbul");
            Console.WriteLine(cities.Contains("ankara"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            /* List<Customer> customers = new List<Customer>();
           customers.Add(new Customer { Id = 1, FirstName = "hamza" });
           customers.Add(new Customer { Id = 2, FirstName = "deniz" });
           */
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {Id = 1, FirstName = "hamza"});
            customers.Add(new Customer {Id = 2, FirstName = "deniz"});

            /* foreach (var customer in customers)
           {
               Console.WriteLine(customer.FirstName);
           }
           */

            var customer2 = new Customer //bu şekilde de nesne oluşturulabiliyor
            {
                Id = 3, FirstName = "Ahmet"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Ali"},
                new Customer {Id = 5, FirstName = "Veli"}
            });
            var count = customers.Count;
            Console.WriteLine("count:{0} ", count);
            //  customers.Clear();//listenin tüm elemanlarını siler
            /*   Console.WriteLine(customers.Contains(new Customer{Id=1,FirstName = "hamza"}));
            Bu şekilde contains metodu çağırılırsa false döndürür. çünkü new customer() denilince yeni bir referansı gösterecektir
            */
            Console.WriteLine(customers.Contains(customer2)); // bu şekilde nesnenin referansını yazmak gerek
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count2 = customers.Count;
            Console.WriteLine("count:{0} ", count2);

            //  Console.WriteLine(count);
            Console.ReadLine();
        }

        private static void ArrayMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("ankara");
            cities.Add("adana");

            cities.Add("istanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
