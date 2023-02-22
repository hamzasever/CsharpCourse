using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
         //   employeeManager.Logger = new DatabaseLogger(); // property tanımlanınca bu şekilde nesne oluşturulur
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10; // 
            //static method doğrudan sınıf adıyla çağırılabilir
            Utilities.Validate();
            Manager.DoSomething();
            //static olmayan method nesneyle çağırılabilir
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
           Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
           Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        // public ILogger Logger { get; set; } //property tanımlama
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
          //  Logger.Log();
           _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("added!");
            Message();
        }
    }

    static class Teacher // static class larda "new" leme yapılamaz.
    {
        public static int Number { get; set; }
    }

    static class Utilities //static sınıfın tüm metodları static olmak zorunda
    
    {
        static Utilities() //static contructor: mutlaka çalışması gereken kod varsa buraya yazılır
        {
            
        }
        public static void Validate() // doğrulama gibi durumlar için static class kullanılır, yada bir değişkenin tüm noktalardaki değerinin aynı olması gerektiğinde kullanılır
        {
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething() // static olmayan sınıfta static method ttanımlanabilir
        {
            Console.WriteLine("Validation is done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Validation is done2");
        }
    }
}
