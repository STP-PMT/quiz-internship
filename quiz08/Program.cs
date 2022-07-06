using System;
namespace quiz08
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter product price");
            int price = int.Parse(Console.ReadLine()!);

            if (price <= 1000)
            {
                int change = 1000 - price;
                int[] coin = new int[] { 500, 100, 50, 10, 5, 1 };
                Console.WriteLine("\nจำนวนเงินทอน {0} บาท", change);
                for (int i = 0; i < coin.Length; i++)
                {
                    if (coin[i] >= 50)
                    {
                        Console.WriteLine("{0}\t: {1} ใบ",coin[i], change / coin[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0}\t: {1} เหรียญ", coin[i], change / coin[i]);
                    }

                    change = change % coin[i];
                }
            }
        }
    }
}