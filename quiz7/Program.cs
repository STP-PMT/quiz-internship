using System;
namespace quiz07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of seconds");
            int sec = int.Parse(Console.ReadLine()!);
            int hh, mm, ss;

            ss = sec % 60;
            sec /= 60;
            mm = sec % 60;
            hh = sec / 60;

            Console.WriteLine("result : {0:D2}:{1:D2}:{2:D2}",hh,mm, ss);
        }
    }
}