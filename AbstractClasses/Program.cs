using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
           // Database database = new Database(); //abstract sınıflar da interface ler gibi "new" lenemezler.
            
            Database sqldatabase = new SqlServer();
            sqldatabase.Add();
            sqldatabase.Delete();

            Database oracledatabase = new Oracle();
            oracledatabase.Add();
            oracledatabase.Delete();
            Console.ReadLine();
        }
    }
    
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
        
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultOracle");
        }
    }
}
