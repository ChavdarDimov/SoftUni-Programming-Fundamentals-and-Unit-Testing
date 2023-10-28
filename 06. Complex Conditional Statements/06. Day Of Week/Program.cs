namespace _06._Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputDay = int.Parse(Console.ReadLine());

            if (inputDay == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (inputDay == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (inputDay == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (inputDay == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (inputDay == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (inputDay == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (inputDay == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}