namespace _07._Sum_of_Digits_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandInput = Console.ReadLine();

            while (commandInput != "End")
            {
                int numberToProcess = int.Parse(commandInput);
                int sum = 0;

                for (int number = numberToProcess; number > 0; number /= 10)
                {
                    int digit = number % 10;
                    sum += digit;
                }

                Console.WriteLine($"Sum of digits = {sum}");

                commandInput = Console.ReadLine();
            }

            Console.WriteLine("Goodbye");
        }
    }
}