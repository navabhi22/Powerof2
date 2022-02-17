using System;

namespace PowerOf2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N ");
            int N = Convert.ToInt32(Console.ReadLine());
            PowerOfTwo.PowerOf2(N);
        }
    }
}