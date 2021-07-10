using System;
using System.Text;
namespace Str_3
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
                    case 'c':
                        str[index] = 'v';
                        count++;
                        break;
                    case 'C':
                        str[index] = 'V';
                        count++;
                        break;
                    case 'v':
                        str[index] = 'c';
                        count++;
                        break;
                    case 'V':
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
