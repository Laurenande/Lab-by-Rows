using System;

namespace Str_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Введите строку ");
            str = Console.ReadLine();
            Console.WriteLine(str.Substring(str.LastIndexOf(" ")));
            Console.ReadKey();
        }
    }
}
