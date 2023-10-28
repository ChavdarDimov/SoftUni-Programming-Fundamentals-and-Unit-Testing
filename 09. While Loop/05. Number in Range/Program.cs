namespace _05._Number_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            bool inRange = input >= 1 && input <= 100;

            while (!inRange)
            {
                input = int.Parse(Console.ReadLine());
                inRange = input >= 1 && input <= 100;
            }

            Console.WriteLine(input);
        }
    }
}