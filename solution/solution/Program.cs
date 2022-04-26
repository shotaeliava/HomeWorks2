using System;

namespace solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("My name is Shota Eliava");
            Console.WriteLine("What Yours?");
            string Texst = Console.ReadLine();
            Console.WriteLine("Your?" + Texst);
        }
    }
}
