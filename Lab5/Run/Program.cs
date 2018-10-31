using Lab5;
using System;


namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork test = new UnitOfWork();
            test.Cities.CreateCity("test", "test2", 22, 22);
            test.Save();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
