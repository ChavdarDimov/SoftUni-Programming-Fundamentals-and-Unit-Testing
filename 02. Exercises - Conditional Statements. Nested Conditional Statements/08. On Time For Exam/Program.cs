namespace _08._On_Time_For_Exam
{
    internal class Program
{
    static void Main(string[] args)
    {
        var examH = int.Parse(Console.ReadLine());
        var examM = int.Parse(Console.ReadLine());
        var arrivalH = int.Parse(Console.ReadLine());
        var arrivalM = int.Parse(Console.ReadLine());

        string output = string.Empty;
        DateTime examTime = DateTime.ParseExact($"{examH}:{examM:D2}", "H:mm", null);
        DateTime arrivalTime = DateTime.ParseExact($"{arrivalH}:{arrivalM:D2}", "H:mm", null);
        TimeSpan timeDifference = TimeSpan.FromTicks(Math.Abs((examTime - arrivalTime).Ticks));

        if (arrivalTime > examTime)
        {
            if (timeDifference.TotalMinutes < 60)
            {
                output = $"Late\r\n{timeDifference.TotalMinutes} minutes after the start";
            }
            else
            {
                output = $"Late\r\n{(int)timeDifference.TotalHours}:{timeDifference.Minutes:D2} hours after the start";
            }
        }
        else if (examTime >= arrivalTime && timeDifference.TotalMinutes <= 30)
        {
            output = "On time";
            if (examTime > arrivalTime)
            {
                output = $"On time\r\n{timeDifference.TotalMinutes} minutes before the start";
            }
        }
        else
        {
            if (timeDifference.TotalMinutes < 60)
            {
                output = $"Early\r\n{timeDifference.TotalMinutes} minutes before the start";
            }
            else
            {
                output = $"Early\r\n{(int)timeDifference.TotalHours}:{timeDifference.Minutes:D2} hours before the start";
            }
        }

        Console.WriteLine(output);
    }
}
}