using System;
namespace quiz2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("S1");
            string? s1 = Console.ReadLine();
            Console.WriteLine("S2");
            string? s2 = Console.ReadLine();
            int total = 0;

            if (s1!.Length == s2!.Length)
            {
                string s1ToUpper = s1.ToUpper();
                string s2ToUpper = s2.ToUpper();

                for (int i = 0; i < s1.Length; i++)
                {
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1ToUpper[i] == s2ToUpper[j])
                        {
                            total++;
                            break;
                        }
                    }
                }
                if (total == s1.Length)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}