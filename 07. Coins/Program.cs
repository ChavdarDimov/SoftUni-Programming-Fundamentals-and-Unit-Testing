namespace _07._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] coinValues = { 2.00m, 1.00m, 0.50m, 0.20m, 0.10m, 0.05m, 0.02m, 0.01m };


            decimal amount = decimal.Parse(Console.ReadLine());

            int totalCoins = 0;

            for (int i = 0; i < coinValues.Length; i++)
            {
                int coinCount = (int)(amount / coinValues[i]);
                totalCoins += coinCount;
                amount %= coinValues[i];
            }


            Console.WriteLine(totalCoins);
        }
    }
}

