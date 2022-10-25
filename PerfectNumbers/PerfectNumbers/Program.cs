using System;

namespace PerfectNumbers
{
    internal class Program
    {
        //Returns true if n is perfect
        static bool Perfect(int n)
        {
            // To store sum of divisors
            int sum = 1;

            // Find all divisors and add them
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                    {
                        sum = sum + i + n / i;
                    }
                    else
                    {
                        sum = sum + i;
                    }
                }
            }



            // If sum of divisors is equal to n, then n is a perfect number
            
            if (sum == n && n != 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the Input Value");

            int input = Int32.Parse(Console.ReadLine());
            for (int n = 2; n < input; n++)
            {
                if (Perfect(n))
                {
                    System.Console.WriteLine(n + " is a perfect number");
                }
            }
        }
    }
}
