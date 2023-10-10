namespace _06._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int stepsCounter = 0;
            String input = "";

            while (stepsCounter < 10000)
            {
                input = (Console.ReadLine());
                
                if (input == "Going home")
                {
                    stepsCounter = stepsCounter + int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    stepsCounter = stepsCounter + int.Parse(input);
                }

            }

            int difference = 0;

            if (stepsCounter >= stepsGoal)
            {
                difference = stepsCounter - stepsGoal;
            } 
            else if (stepsCounter < stepsGoal)
            {
                difference = stepsGoal - stepsCounter;
            }

            if (stepsCounter >= stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            } 
            else
            {
                Console.WriteLine($"{difference} more steps to reach goal.");
            }
        }
    }
}