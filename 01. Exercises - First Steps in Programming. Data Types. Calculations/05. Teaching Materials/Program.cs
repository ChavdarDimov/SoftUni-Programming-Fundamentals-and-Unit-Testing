namespace _05._Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reqAmountOfNylon = int.Parse(Console.ReadLine());
            int reqLitresOfPaint = int.Parse(Console.ReadLine());
            int reqLitresOfThinner = int.Parse(Console.ReadLine());
            int hoursNeededForWork = int.Parse(Console.ReadLine());

            double nylonPrice = (reqAmountOfNylon + 2) * 1.50;
            double paintPrice = (reqLitresOfPaint + (reqLitresOfPaint * 0.1)) * 14.50;
            double thinnerPrice = reqLitresOfThinner * 5.00;
            double bagsPrice = 0.40;

            double totalPriceMaterials = nylonPrice + paintPrice + thinnerPrice + bagsPrice;
            double priceForCraftsmen = (totalPriceMaterials * 0.3) * hoursNeededForWork;

            double grandTotalPrice = totalPriceMaterials + priceForCraftsmen;

            Console.WriteLine(grandTotalPrice);

            
        }
    }
}