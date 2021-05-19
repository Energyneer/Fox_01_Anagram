using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Console.WriteLine(Anagram.Reverse(inputLine));
        }
    }
}
