using System;

namespace FibonacciSeries
{
    internal class Fibonacci
    {
        static int p1 = 0;
        static int p2 = 1;
        static int p3;      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input Value");
            int count = Int32.Parse(Console.ReadLine());     
            Console.Write(p1 + " " + p2);

            for (int i = 2; i < count; i++)        
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;

            }
            Console.WriteLine();


        }

    }
}
