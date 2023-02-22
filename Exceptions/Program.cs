using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //try catch yerine HandleException 
            HandleException(() => //()=>{Find();} ben sana parametresiz bir method gönderiyorum "[=> lamda demek]"bu methodun karşılığı da {Find();} bu süslü parantez içinde yazılan kod kümesi demektir
            {
                Find();
            });

            Console.ReadLine();

        }

        //Action Delegasyonu
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Engin", "Derin", "Salih"};

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }

            Console.ReadLine();
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] {"engin", "derin", "salih"};
                students[3] = "ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
