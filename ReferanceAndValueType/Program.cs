using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitive değişkenlerde değer atama, dizilerde referansla atama yapılır
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities = new string[] {"ankara","adana","afyon"};//orn: referan no 101
            string[] cities2 = new string[] {"bursa","bolu","izmir"};////orn: referan no 102
            cities2 = cities;// cities in referans değeri cities2 ye atandı.
                             // cities2 referans no 101 oldu. 102 nolu referansı gösteren nesne kalmadığı için garbagecollector tarafından bellekten silinecektir

            cities[0] = "istanbul";
            Console.WriteLine(cities2[0]); 

            foreach (string city in cities2) {
                Console.WriteLine(city);
            }
            

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            dataTable2 = dataTable;
            

            Console.ReadLine();


        }
    }
}
