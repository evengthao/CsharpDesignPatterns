using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LogManager lg = LogManager.Instance;

            lg.WriteLog("test");
            Console.WriteLine("test");

        }
    }
}
