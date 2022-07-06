using System;
namespace quiz04
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int num = int.Parse(Console.ReadLine()!);
            for (int i = num; i > 0; i--)
            {
                for (int j = 0; j < num-i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < num-(num-i); k++)
                {
                    Console.Write("*");
                }

                for (int l = num-(num-i)-1; l > 0; l--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}