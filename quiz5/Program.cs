namespace quiz5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input number 1 - 4 only.");
            int n = int.Parse(Console.ReadLine()!);
            int[] number = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < n-(n-i)+1; k++)
                {
                    Console.Write("{0} ", number[index]);
                    if (index+1 < number.Length)
                    {
                        index++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}