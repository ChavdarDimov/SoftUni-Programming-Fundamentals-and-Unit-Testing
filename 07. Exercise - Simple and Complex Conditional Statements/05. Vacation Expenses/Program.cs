namespace _05._Vacation_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String season = Console.ReadLine();
            String type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            if (season == "Spring")
            {
                if (type == "Hotel")
                {
                    totalPrice = days * 30 * 0.80;
                }
                else if (type == "Camping")
                {
                    totalPrice = days * 10 * 0.80;
                }
            }

            if (season == "Summer")
            {
                if (type == "Hotel")
                {
                    totalPrice = days * 50;
                }
                else if (type == "Camping")
                {
                    totalPrice = days * 30;
                }
            }

            if (season == "Autumn")
            {
                if (type == "Hotel")
                {
                    totalPrice = days * 20 * 0.70;
                }
                else if (type == "Camping")
                {
                    totalPrice = days * 15 * 0.70;
                }
            }

            if (season == "Winter")
            {
                if (type == "Hotel")
                {
                    totalPrice = days * 40 * 0.90;
                }
                else if (type == "Camping")
                {
                    totalPrice = days * 10 * 0.90;
                }
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}