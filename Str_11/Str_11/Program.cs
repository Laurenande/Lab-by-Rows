using System;

namespace Str_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое ФИО");
            string[] str = Console.ReadLine().Split(' ');
            string fio = str[0] + " " + str[1].Substring(0, 1) + "." + " " + str[2].Substring(0, 1) + ".";
            Console.WriteLine(fio);
        }
    }
}
