namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            String day = Console.ReadLine();

            if (hours >= 10 && hours <= 18)
            {
                if (day == "Sunday")
                {
                    Console.WriteLine("closed");
                }
                else
                {
                    Console.WriteLine("open");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}