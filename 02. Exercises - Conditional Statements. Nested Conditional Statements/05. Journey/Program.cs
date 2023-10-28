namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            String season = Console.ReadLine();

            String holidayType = "";
            String destination = "";
            double amountSpent = 0.0;

            switch (season)
            {
                case "summer":
                    holidayType = "Camp";

                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        amountSpent = budget * 0.30;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        amountSpent = budget * 0.40;
                    }
                    else
                    {
                        destination = "Europe";
                        amountSpent = budget * 0.90;
                        holidayType = "Hotel";
                    }
                    break;
                case "winter":
                    holidayType = "Hotel";

                    if (budget <= 100)
                    {
                        destination = "Bulgaria";
                        amountSpent = budget * 0.70;
                    }
                    else if (budget <= 1000)
                    {
                        destination = "Balkans";
                        amountSpent = budget * 0.80;
                    }
                    else
                    {
                        destination = "Europe";
                        amountSpent = budget * 0.90;
                    }
                    break;
            }
      
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {amountSpent:f2}");
        }
    }
}