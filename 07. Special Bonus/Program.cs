namespace _07._Special_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            int previousNumber = 0;
            bool stopNumberFound = false;

            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber == stopNumber)
                {
                    stopNumberFound = true;
                    break;
                }

                previousNumber = currentNumber;
            }

            Console.WriteLine(previousNumber + (previousNumber * 0.20));
        }
    }
}