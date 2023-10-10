namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosesPrice = 5.0;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.0;
            double gladiolusPrice = 2.50;

            double totalPrice = 0.0;

            switch (flowersType)
            {
                case "Roses":
                    if (flowersCount > 80)
                    {
                        totalPrice = rosesPrice * flowersCount * 0.9;
                    }
                    else totalPrice = rosesPrice * flowersCount;
                    break;
                case "Dahlias":
                    if (flowersCount > 90)
                    {
                        totalPrice = dahliasPrice * flowersCount * 0.85;
                    }
                    else totalPrice = dahliasPrice * flowersCount;
                    break;
                case "Tulips":
                    if (flowersCount > 80)
                    {
                        totalPrice = tulipsPrice * flowersCount * 0.85;
                    }
                    else totalPrice = tulipsPrice * flowersCount;
                    break;
                case "Narcissus":
                    if (flowersCount < 120)
                    {
                        totalPrice = narcissusPrice * flowersCount * 1.15;
                    }
                    else totalPrice = narcissusPrice * flowersCount;
                    break;
                case "Gladiolus":
                    if (flowersCount < 80)
                    {
                        totalPrice = gladiolusPrice * flowersCount * 1.20;
                    }
                    else totalPrice = gladiolusPrice * flowersCount;
                    break;
            }
        double sumLeft = budget - totalPrice;
        double neededMoney = totalPrice - budget;

            if (sumLeft >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {sumLeft:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
            }
        }
    }