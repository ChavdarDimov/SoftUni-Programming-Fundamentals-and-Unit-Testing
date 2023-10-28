namespace _03._Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = int.Parse(Console.ReadLine());

            int inputNumbers = 0;
            int biggestNumber = int.MinValue;

            for (int i = 0; i < amountOfNumbers; i++)
            {
                inputNumbers = int.Parse(Console.ReadLine());

                if (inputNumbers > biggestNumber)
                {
                    biggestNumber = inputNumbers;
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
}