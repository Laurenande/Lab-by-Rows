using System;
using System.Text;
namespace Str_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string  str2, replacement;
            Console.WriteLine("Введите строку: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Введите что заменить: ");
            str2 = Console.ReadLine();
            Console.WriteLine("Введите на что поменять: ");
            replacement = Console.ReadLine();
            replaceStr(str, str2, replacement);
        }
        static void replaceStr(StringBuilder str, string str2, string replacement)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str2[0])
                {
                    str.Replace( str2, replacement);
                }
            }
            Console.WriteLine(str);
        }

    }
}
