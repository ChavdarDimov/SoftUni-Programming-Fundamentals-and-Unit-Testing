namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countOfNights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            int discountPercentage = 0;
            double discount = 0;

            if (countOfNights > 14)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50.00 * countOfNights * 0.7;
                    apartmentPrice = 65.00 * countOfNights * 0.9;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * countOfNights * 0.8;
                    apartmentPrice = 68.70 * countOfNights * 0.9;

                }
                else
                {
                    studioPrice = 76.00 * countOfNights;
                    apartmentPrice = 77.00 * countOfNights * 0.9;
                }
            }
            else if (countOfNights > 7)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50.00 * countOfNights * 0.95;
                    apartmentPrice = 65.00 * countOfNights;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * countOfNights;
                    apartmentPrice = 68.70 * countOfNights;

                }
                else
                {
                    studioPrice = 76.00 * countOfNights;
                    apartmentPrice = 77.00 * countOfNights;
                }
            }
            else
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50.00 * countOfNights;
                    apartmentPrice = 65.00 * countOfNights;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * countOfNights;
                    apartmentPrice = 68.70 * countOfNights;
                }
                else
                {
                    studioPrice = 76.00 * countOfNights;
                    apartmentPrice = 77.00 * countOfNights;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}