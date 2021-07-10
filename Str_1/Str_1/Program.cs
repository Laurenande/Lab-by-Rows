using System;
using System.Text;
namespace Str_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            StringBuilder str = new StringBuilder( Console.ReadLine());
            for (int index = 0; index < str.Length; index++)
            {
                switch (str[index])
                {
                    case 'a':
                        str[index] = 'b';
                        count++;
                        break;
                    case 'b':
                        str[index] = 'a';
                        count++;
                        break;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine(count);
        }
    }
}
