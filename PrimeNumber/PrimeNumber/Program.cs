using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            bool IsPrime = true;
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("{0} is a Prime Number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number.", number);
            }
        }
    }
}
