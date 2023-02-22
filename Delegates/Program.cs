using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //Func VE Action Örnek uygulama

            //handleexception(() => //()=>{find();} ben sana parametresiz bir method gönderiyorum "[=> lamda demek]"bu methodun karşılığı da {find();} bu süslü parantez içinde yazılan kod kümesi demektir
            //{
            //    find();
            //});


            Console.WriteLine(Topla(2, 3));
           
            Func<int, int, int> add = Topla; // Func<int,int,int> (parametre,paarametre,dönüş tipi)
            Console.WriteLine(Topla(3, 5));

            Func<int> getRandomNumber = delegate () //parametresiz delegate çalıştırıyor
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000); //aynı işi yapan kofun faklı sonuç vermesi için araya gecikme zamanı ekledik milisaniye cinsinden
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
    
        //Action Delegasyonu
        //private static void HandleException(Action action)
        //{
        //     try
        //    {
        //     action.Invoke();
        //     }
        //     catch (Exception exception)
        //     {
        //         Console.WriteLine(exception.Message);
        //     }
        //}


}
