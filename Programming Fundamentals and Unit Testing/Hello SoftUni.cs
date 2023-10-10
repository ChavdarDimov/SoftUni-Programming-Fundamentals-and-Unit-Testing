using System.ComponentModel.Design;

namespace Programming_Fundamentals_and_Unit_Testing
{
    internal class Hello
    {
        static void Main(string[] args)
        {
           Console.Write("Enter a number between 1 and 7 for a day of the week:");
            
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                default: Console.WriteLine("Error"); break;
            }
        }
    }
}