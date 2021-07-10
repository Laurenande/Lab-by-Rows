using System;
using System.Text;
namespace Str_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Введите строку:");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int index = 0; index < str.Length; index++)
            {
                switch (str[index])
                {
                    case 'v':
                        str[index] = 'V';
                        count++;
                        break;
                    case 'c':
                        str[index] = 'C';
                        count++;
                        break;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine(count);
        }
    }
}
