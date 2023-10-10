namespace _03._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            int output = 0;

            if (points >= 0 && points <= 3)
            {
                output = points + 5;
            }
            else if (points >= 4 && points <= 6)
            {
                output = points + 15;
            }
            else if (points >= 7 && points <= 9)
            {
                output = points + 20;
            }

            Console.WriteLine(output);
        }
    }
}