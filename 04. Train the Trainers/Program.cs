using System.Runtime.ExceptionServices;

namespace _04._Train_the_Trainers
{
    internal class Program
    {
        static void Main()
        {
            int juryMembers = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalAverage = 0;
            int presentationsCount = 0;

            while (presentation != "Finish")
            {
                double presentationSum = 0;

                for (int i = 0; i < juryMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    presentationSum += grade;
                }

                double averageGrade = presentationSum / juryMembers;
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                totalAverage += averageGrade;
                presentationsCount++;

                presentation = Console.ReadLine();
            }

            if (presentationsCount > 0)
            {
                double finalAverage = totalAverage / presentationsCount;
                Console.WriteLine($"Student's final assessment is {finalAverage:f2}.");
            }
        }
    }
}