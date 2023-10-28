namespace _09._Ski_Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            String roomType = Console.ReadLine();
            String assessment = Console.ReadLine();

            int nights = daysToStay - 1;

            double singleRoom = 118.00;
            double apartment = 155.00;
            double president = 235.00;

            double singleRoomPrice = 0.00;
            double apartmentPrice = 0.00;
            double presidentPrice = 0.00;

            switch (roomType)
            {
                case "room for one person":
                    singleRoomPrice = nights * singleRoom;
                    if (assessment == "positive")
                    {
                        singleRoomPrice *= 1.25;
                    } 
                    else if (assessment == "negative")
                    {
                        singleRoomPrice *= 0.90;
                    } break;
                case "apartment":
                    if (nights < 10)
                    {
                        apartmentPrice = nights * apartment * 0.70;
                    }
                    else if (nights >= 10 &&  nights <= 15)
                    {
                        apartmentPrice = nights * apartment * 0.65;
                    }
                    else if (nights > 15)
                    {
                        apartmentPrice = nights * apartment * 0.50;
                    }
                    if (assessment == "positive")
                    {
                        apartmentPrice *= 1.25;
                    } 
                    else if (assessment == "negative")
                    {
                        apartmentPrice *= 0.90;
                    } break;
                case "president apartment":
                    if (nights < 10)
                    {
                        presidentPrice = nights * president * 0.90;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        presidentPrice = nights * president * 0.85;
                    }
                    else if (nights > 15)
                    {
                        presidentPrice = nights * president * 0.80;
                    }
                    if (assessment == "positive")
                    {
                        presidentPrice *= 1.25;
                    }
                    else if (assessment == "negative")
                    {
                        presidentPrice *= 0.90;
                    }
                    break;
            }
            
            if (roomType == "president apartment")
            {
                Console.WriteLine($"{presidentPrice:f2}");
            }
            else if (roomType == "apartment")
            {
                Console.WriteLine($"{apartmentPrice:f2}");
            }
            else if (roomType == "room for one person")
            {
                Console.WriteLine($"{singleRoomPrice:f2}");
            }


        }
    }
}