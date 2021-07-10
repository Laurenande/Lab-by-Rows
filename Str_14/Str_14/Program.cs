using System;

namespace Str_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str2, replacement;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            Console.WriteLine("Введите что посчитать: ");
            str2 = Console.ReadLine();

            countSubstr(str, str2);
        }
        static void countSubstr(string str, string str2)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str2[0])
                {
                    if (str.Substring(i, str2.Length) == str2)
                    {
                        count++;
                        i += str2.Length - 1;
                    }
                }
            }
            Console.WriteLine(count);
        }

    }
}
