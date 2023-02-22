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
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            string[] students2 = { "Deniz", "Hamza", "Nadiye" };
            Console.WriteLine(students2[0]);

          //  Console.ReadLine();

            //Çok boyutlu dizi tanımlama

            string[,,] bolgeler = new string[4, 2, 3] //Üç boyutlu dizi tanımlama
            {
                {{ "istanbul","izmit","edirne"},{ "istanbul","izmit","edirne"}},
                {{"izmir","aydın","muğla"},{"izmir","aydın","muğla"} },
                {{"adana","mersin","antalya" },{"adana","mersin","antalya" }},
                {{"diyarbakır","mardin","batman" },{"diyarbakır","mardin","batman"}}
            };

            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++) //GetUpperBound(0) dizi boyutunun max değerini verir{4}
                                                                 //GetUpperBound(1) dizi boyutunun max değerini verir{2} //GetUpperBound(2) dizi boyutunun max değerini verir3}
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    for (int k = 0; k <= bolgeler.GetUpperBound(2); k++)
                    {
                        Console.WriteLine(bolgeler[i, j, k]);
                    }
                   
                }
                Console.WriteLine("------------");
            }
            Console.ReadLine();
           /* 
            string[,] regions = new string[7, 3] // iki boyutlu dizi
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"izmir","Muğla","Manisa"},
                {"Van","Ağrı","Kars"},
                {"Diyarbakır","Mardin","Urfa"}
            };

            
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("-----");
            }
            Console.ReadLine();*/
        }
    }
}
