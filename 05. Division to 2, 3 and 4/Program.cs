namespace _05._Division_to_2__3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int divisibleBy2Count = 0;
            int divisibleBy3Count = 0;
            int divisibleBy4Count = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    divisibleBy2Count++;
                }
                if (input % 3 == 0)
                {
                    divisibleBy3Count++;
                }
                if (input % 4 == 0)
                {
                    divisibleBy4Count++;
                }
            }

            double percentDivisibleBy2 = (double)divisibleBy2Count / n * 100;
            double percentDivisibleBy3 = (double)divisibleBy3Count / n * 100;
            double percentDivisibleBy4 = (double)divisibleBy4Count / n * 100;

            Console.WriteLine($"{percentDivisibleBy2:f2}%");
            Console.WriteLine($"{percentDivisibleBy3:f2}%");
            Console.WriteLine($"{percentDivisibleBy4:f2}%");
        }
    }
}