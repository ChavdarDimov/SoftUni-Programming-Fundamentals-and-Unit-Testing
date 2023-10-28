
    internal class Program
{
    static void Main(string[] args)
    {
        var degreese = int.Parse(Console.ReadLine());
        var dayTime = Console.ReadLine();
        var outfit = string.Empty;
        var shoes = string.Empty;
        if (degreese >= 10 && 18 >= degreese)
        {
            if (dayTime == "Morning")
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (dayTime == "Afternoon" || dayTime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        else if (degreese > 18 && 24 >= degreese)
        {
            if (dayTime == "Morning" || dayTime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (dayTime == "Afternoon")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        else if (degreese >= 25 && 42 >= degreese)
        {

            if (dayTime == "Morning")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (dayTime == "Afternoon")
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else if (dayTime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        Console.WriteLine($"It's {degreese} degrees, get your {outfit} and {shoes}.");
    }
}
