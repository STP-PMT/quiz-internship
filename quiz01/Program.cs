using System;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrays = new();
            Console.WriteLine("Input integer. [Pass 'S' to submit]");
            while (true)
            {
                string? msg = Console.ReadLine();
                Console.SetCursorPosition(0, Console.CursorTop--);
                if (msg!.Equals("s") || msg!.Equals("S"))
                {
                    break;
                }
                else
                {
                    try
                    {
                        arrays.Add(int.Parse(msg));
                        Console.SetCursorPosition(0, Console.CursorTop-1);
                        Console.WriteLine("Arrays : [{0}]", string.Join(", ", arrays));
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Plase input integer only.\n");
                    }
                }
            }
            Console.WriteLine("Input Sum.");
            try
            {
                int sum = int.Parse(Console.ReadLine()!);
                int[] num = arrays.ToArray();
                List<int> used = new List<int>();
                Console.WriteLine("Result :");
                for (int i = 0; i < num.Length; i++)
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (num[i]+num[j] == sum && i != j)
                        {
                            if (!(used.Contains(num[i])&&used.Contains(num[j]))){
                                used.Add(num[i]);
                                used.Add(num[j]);
                                Console.WriteLine("{0} , {1}", num[i], num[j]);
                            }
                        }
                    }
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Plase input integer only.\n");
            }
        }
    }
}
