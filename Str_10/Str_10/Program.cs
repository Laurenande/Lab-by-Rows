using System;

namespace Str_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C:\\WINDOWS\\WORK\\my.txt";
            string[] str1 = str.Split('\\');

            foreach (var strSplit in str1)
            {
                Console.WriteLine(strSplit);
            }
        }
    }
}
