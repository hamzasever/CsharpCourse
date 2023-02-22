using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

           //var result =  add2(10,20);
           // Console.WriteLine(result);
           // Console.ReadLine();

            int number1 = 3;
            int number2 = 5;
            int number3 = 6;

            var result = Multiply(number1, number2);
            var result2 = Multiply(number1, number2, number3);
            Console.WriteLine("result: " + result + "\n" + "result2: " + result2);
            

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
            //  var result = add3( ref number1, number2);
            //var result = add3(out number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);
            //Console.ReadLine();
        }

        //static void add()
        //{
        //    Console.WriteLine("Added!");
        //}

        //static int add2( int number1, int number2) 
        //{
        //    var toplam = number1 + number2;
        //    return toplam;
        //}

            //ref keyword
        ////static int add3(ref int number1, int number2)//ref keywordu parametrenin referans değerini kullan demek
        ////{
        ////    number1 = 30; //referans değer
        ////    return number1 + number2;
        ////}

            //out keyword
        //static int add3(out int number1, int number2)//out keywordu ref ile aynı işi yapar. tek farkı değişkene ilk değer atamak zorunda kalmazsın.
        //{
        //    number1 = 30; //referans değer
        //    return number1 + number2;
        //}

        //method overloading yapma
        static  int Multiply(int number1, int number2) {
            return number1 * number2;
        }
        static  int Multiply(int number1, int number2, int number3) {
            return number1 * number2 * number3;
        }

        //challenge params keyword: metoda aynı tipte istediğimiz kadar parametre gönderebiliyoruz.
        static int Add4(params int[] numbers)
            //static int Add4(int number, params int[] numbers, int number2) bu şekilde kullanım hata verir. params ile başlayanlar son parametre olmalıdır.
        {
            return numbers.Sum();
        }
    }
}
