using System;

namespace Str_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое ФИО");
            string[] str = Console.ReadLine().Split(' ');
            string fio = str[1].Substring(0, 1) + ". " + str[2].Substring(0, 1) + ". " + str[0];
            Console.WriteLine(fio);
        }
    }
}
