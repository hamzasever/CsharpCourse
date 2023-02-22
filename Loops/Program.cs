using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For döngüsü
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //While döngüsü
            //int number = 100;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //Console.ReadLine();

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("Tihis is a prime number");
            }
            else
                Console.WriteLine("This is not a prime number");
            Console.ReadLine();

        }

        //Asal mı metodu
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

    }
}
