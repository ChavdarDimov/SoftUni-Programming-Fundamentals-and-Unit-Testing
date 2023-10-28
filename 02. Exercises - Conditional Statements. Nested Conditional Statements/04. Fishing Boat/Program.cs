namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            String season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());


            int priceSpring = 3000;
            int priceSummerAndAutumn = 4200;
            int priceWinter = 2600;

            double priceAfterDiscount = 0.0;


            switch (season)
            {
                case "Spring":
                    if (fishermenCount < 7)
                    {
                        priceAfterDiscount = priceSpring * 0.9;
                    } 
                    else if (fishermenCount >= 7 &&  fishermenCount <= 11)
                    {
                        priceAfterDiscount = priceSpring * 0.85;
                    } 
                    else if (fishermenCount >= 12)
                    {
                        priceAfterDiscount = priceSpring * 0.75;
                    } break;
                case "Summer":
                    if (fishermenCount < 7)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.9;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.85;
                    }
                    else if (fishermenCount >= 12)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.75;
                    }
                    break;
                case "Autumn":
                    if (fishermenCount < 7)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.9;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.85;
                    }
                    else if (fishermenCount >= 12)
                    {
                        priceAfterDiscount = priceSummerAndAutumn * 0.75;
                    }
                    break;
                case "Winter":
                    if (fishermenCount < 7)
                    {
                        priceAfterDiscount = priceWinter * 0.9;
                    }
                    else if (fishermenCount >= 7 && fishermenCount <= 11)
                    {
                        priceAfterDiscount = priceWinter * 0.85;
                    }
                    else if (fishermenCount >= 12)
                    {
                        priceAfterDiscount = priceWinter * 0.75;
                    }
                    break;
            }
            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                priceAfterDiscount = priceAfterDiscount * 0.95;
            }

            double moneyLeft = groupBudget - priceAfterDiscount;
            double moreMoney = priceAfterDiscount - groupBudget;


            if (moneyLeft > 0)
            {
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money! You need {moreMoney:f2} leva.");
            }
        }
    }
}