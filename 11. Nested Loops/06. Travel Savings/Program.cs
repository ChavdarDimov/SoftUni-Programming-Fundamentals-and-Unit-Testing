namespace _06._Travel_Savings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double requiredBudget = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < requiredBudget)
                {
                    double addFunds = double.Parse(Console.ReadLine());
                    sum += addFunds;

                    Console.WriteLine($"Collected: {sum:f2}");
                }

                Console.WriteLine($"Going to {destination}!");
                
                destination = Console.ReadLine();
            }

            
        }
    }
}