﻿namespace ForOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i, n, sum = 0;

            Console.WriteLine("Näita summat paaritutest arvudest: \n");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Paaritud numbrid on: ");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }

            Console.Write("Paarituid arve on {0} ja need moodustavad summa: {1} \n", n, sum);
        }
    }
}
