using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

         //  IPerson person = new Iperson()// interface ler "new" lenemez.

        // Demo();

        ICustomerDal[] customerDals = new ICustomerDal[2]
        {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal()
          //  new MySqlServerCustomerDal() interface kullanınca zaman içinde programa yeni bir özellik eklenirse güncellemek kolaylaşır.
        };
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
         Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            // customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer {Id = 1, FirtName = "hamza", LastName = "sever", Address = "istanbul"});

            Student student = new Student
            {
                Id = 2,
                FirtName = "deniz",
                LastName = "sever",
                Department = "Computer Sciences"
            };
            manager.Add(student); //( hata verdi. çünkü parametre olarak customer beklerken student girildi.)
            //public void Add(IPerson person) bu şekilde hata düzeldi.
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirtName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    //interface ne işe yarar

    class PersonManager
    {
        //public void Add(Customer customer)
        //{
        //    Console.WriteLine(customer.FirtName);
        //}
        public void Add(IPerson person) // bu şekilde yapınca tüm nesneleri parametre olarak alabiliyoruz
        {
            Console.WriteLine(person.FirtName);
        }
    }
}
