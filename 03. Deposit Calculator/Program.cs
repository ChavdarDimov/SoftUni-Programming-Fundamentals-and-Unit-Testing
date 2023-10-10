namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());

            double finalAnnualRate = annualRate / 100;

            double totalAmount = depositAmount + termOfDeposit * (depositAmount * finalAnnualRate) / 12;

            Console.WriteLine(totalAmount);
        }
    }
}