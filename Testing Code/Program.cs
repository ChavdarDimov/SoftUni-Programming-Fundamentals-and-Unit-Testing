using System.ComponentModel.Design;

namespace Testing_Code
{
    internal class Program
    {
        static void Main()
        {
            string cycleEnd = "";
            int balance = 0;

            while (cycleEnd != "End")
            {
                string input = Console.ReadLine();

                if (input > 0)
                {
                    balance = balance + input;
                }
                if (input < 0)
                {
                    balance = balance - input;
                }
            }
        }
    }
}
