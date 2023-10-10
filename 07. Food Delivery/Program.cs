namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basketballFee = int.Parse(Console.ReadLine());

            double basketballSneakers = basketballFee - (basketballFee * 0.4);
            double basketballTeam = basketballSneakers - (basketballSneakers * 0.2);
            double basketball = basketballTeam * 0.25;
            double basketballAccessories = basketball * 0.20;

            double totalPrice = basketballFee + basketballSneakers + basketballTeam + basketball + basketballAccessories;

            Console.WriteLine(totalPrice);
        }
    }
}