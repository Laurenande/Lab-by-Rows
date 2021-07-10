using System;

namespace Str_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сроку:");
            string[] s = Console.ReadLine().Split(' ');
            //string[] arr = s.Split(' ');
            Console.WriteLine(s[0]);
        }
    }
}
