namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main()
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                    break;

                int hallSize = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                while (soldTickets < hallSize)
                {
                    string soldTicketType = Console.ReadLine();
                    if (soldTicketType == "End")
                        break;

                    soldTickets++;
                    switch (soldTicketType)
                    {
                        case "student": studentTickets++; break;
                        case "kid": kidTickets++; break;
                        case "standard": standardTickets++; break;
                    }
                }

                double percentageFull = (double)soldTickets / hallSize * 100;
                Console.WriteLine($"{movieName} - {percentageFull:f2}% full.");
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * studentTickets / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTickets / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidTickets / totalTickets:f2}% kids tickets.");
        }
    }