using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer aSqlServer = new SqlServer();
            aSqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        //method override yapmak istersek, süper class ın methodlarını virtual olarak tanımlarız
        //interface lerde böyle birşey kullanılmaz
        public virtual void Add() 
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
           // base.Add();
           Console.WriteLine("Added by Sql code");
        }
    }
    class MySqlServer : Database
    {

    }
}
