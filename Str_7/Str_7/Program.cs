using System;
using System.Text;
namespace Str_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            int count = 0;
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int index = 0; index < str.Length; index++)
            {
                if(str[index] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count + 1);
        }
    }
}
