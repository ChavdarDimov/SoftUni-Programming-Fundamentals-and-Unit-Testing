namespace _11._Coffee_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String drinkName = Console.ReadLine();
            String extra = Console.ReadLine();

            double finalPrice = 0;

            if (drinkName == "coffee")
            {
                finalPrice = 1.00;
            }
            else if (drinkName == "tea")
            {
                finalPrice = 0.60;
            }

            if (extra == "sugar")
            {
                finalPrice = finalPrice + 0.40;
            }

            Console.WriteLine($"Final price: ${finalPrice:f2}");
        }
    }
}