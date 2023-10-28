namespace _01._Market_Place
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String product = Console.ReadLine();
            String day = Console.ReadLine();

            double price = 0.0;

            if (product == "Banana" && day == "Weekday")
            {
                price = 2.50;
            }
            else if (product == "Banana" && day == "Weekend")
            {
                price = 2.70;
            }

            if (product == "Apple" && day == "Weekday")
            {
                price = 1.30;
            }
            else if (product == "Apple" && day == "Weekend")
            {
                price = 1.60;
            }

            if (product == "Kiwi" && day == "Weekday")
            {
                price = 2.20;
            }
            else if (product == "Kiwi" && day == "Weekend")
            {
                price = 3.00;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}