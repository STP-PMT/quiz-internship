using System;

namespace quiz03
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
            int[] num = arrays.ToArray();
            int n = 0;
            string result = num[0]+"";
            
            for (int i = 1; i < num.Length; i++)
            { 
                if(num[i] - num[i-1] == 1)
                {
                    if(i+1 ==  num.Length-1)
                    {
                        result+="-"+num[i+1];
                    }
                    continue;
                }
               
                 if(i+1 < num.Length)
                {
                    if (num[i+1] -num[i]  != 1)
                    {
                        result+=","+num[i];
                    }
                    else
                    {
                        result+=","+num[i]+"-"+num[i+1];
                        continue;
                    }
                    
                    if (i+1 ==  num.Length-1)
                    {
                        result+="-"+num[i+1];
                    }
                }
             
            }
            Console.WriteLine(result);
        }
    }
}
