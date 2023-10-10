namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moneyNeededForVacation = int.Parse(Console.ReadLine());
            int availableMoney = int.Parse(Console.ReadLine());

            int daysCounter = 0;
            int daysSpentCounter = 0;

            while (availableMoney < moneyNeededForVacation && daysSpentCounter < 5)
            {
                daysCounter++;
                String actionType = Console.ReadLine();
                int amount = int.Parse(Console.ReadLine());

                if (actionType == "spend")
                {
                    availableMoney = availableMoney - amount;
                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    daysSpentCounter++;
                } 
                else if (actionType == "save")
                {
                    availableMoney = availableMoney + amount;
                    daysSpentCounter = 0;
                }

                if (daysSpentCounter >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCounter}");
                    }

                if (availableMoney >= moneyNeededForVacation)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                    }
            }
        }
    }
}