﻿namespace _02._Odd_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(number);
        }
    }
}