using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number:");
            string num = Console.ReadLine();
            string flip = "";

            for (int i = num.Length; i > 0; i--)
            {
                flip += num[i - 1];
            }

            bool res = false;

            if (num == flip)
            {
                res = true;
            }
            Console.WriteLine(res);
        }
    }
}
