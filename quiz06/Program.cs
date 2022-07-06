using System;

namespace quiz06
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers : ");
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()!);
                Console.SetCursorPosition(0, Console.CursorTop-1);
                Console.WriteLine("Arrays : [{0}]", string.Join(", ", numbers));
            }
            int[] values = MaxToMin(numbers);
            Console.Write("\nresult : ");
            Console.WriteLine("{0}", string.Join(", ", values));
        }

        public static int[] MaxToMin(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i]>numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}