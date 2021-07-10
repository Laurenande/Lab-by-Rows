using System;
using System.Text;
namespace Str_6
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
