using System;
namespace quiz9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence ");
            string msg = Console.ReadLine()!;
            string[] words = msg.Split(' ');
            string result = "";
            foreach (string word in words)
            {
                string temp ="";
                for(int i = word.Length-1; i >= 0 ; i--)
                {
                    temp += word[i];
                }
                result += temp +" ";
            }
            Console.WriteLine(result);
        }
    }
}