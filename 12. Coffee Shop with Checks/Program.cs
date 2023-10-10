namespace _12._Coffee_Shop_with_Checks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();

            bool orderValid = true;
            double price = 0;

            if (order == "coffee")
            {
                price = 1.00;
            }
            else if (order == "tea")
            {
                price = 0.60;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                orderValid = false;
            }

            if (orderValid)
            {
                String extra = Console.ReadLine();

                if (extra == "sugar")
                {
                    price = price + 0.40;
                }
                else if (extra == "no")
                {
                    price = price;
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                    orderValid = false;
                }
            }

            if (orderValid)
            {
                Console.WriteLine($"Final price: ${price:f2}");
            }
        }
    }
}