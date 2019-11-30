using System;
using System.Threading;
using System.Threading.Tasks;

namespace RpiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //new System.Threading.Timer((e) => WriteToDb(),
            //    null,
            //    TimeSpan.Zero,
            //    TimeSpan.FromSeconds(2))
            //Console.WriteLine("Hopp1");
            //while (true)
            //{

            //}

            //Timer timer = new Timer(WriteToDb, null, 0, 3000);


            Console.WriteLine("Hopp2");

            Console.ReadLine();
        }
        static void WriteToDb(Object o)
        {
            Console.WriteLine(DateTime.Now);

        }

        async Task<int> TestToDB()
        {
            
            return 1;
        }
    }
}
