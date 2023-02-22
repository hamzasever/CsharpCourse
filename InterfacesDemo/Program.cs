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

            IEat[] eats = new IEat[2]
            {
                new Manager(), 
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();

        }
    }
    // SOLID: yazılım geliştirme prensiplerinin baş harfi
    /*
     .S — Single-Responsibility Principle(Tek Sorumluluk Prensibi)
    · O — Open-Closed Principle(Açık Kapalı Prensibi)
    · L — Liskov Substitution Principle ( Liskov’un Yerine geçme Prensibi)
    · I — Interface Segregation Principle ( Arayüz Ayrımı Prensibi)
    · D — Dependency Inversion Principle ( Bağımlılıkların Terslenmesi Prensibi)
     */
    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine(" I Worked");
        }

        public void Eat()
        {
            Console.WriteLine(" I Eated");
        }

        public void GetSalary()
        {
            Console.WriteLine(" I got salary");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine(" I Worked");
        }

        public void Eat()
        {
            Console.WriteLine(" I Eatted");
        }

        public void GetSalary()
        {
            Console.WriteLine(" I got salary");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine(" I worked");
        }
    }
}
