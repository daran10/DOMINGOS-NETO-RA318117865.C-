
using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            Console.WriteLine("How are you?");
            var tudo  = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.ReadKey(true);
            Console.Write("\nPress any key to exit...");
        }
    }
}
