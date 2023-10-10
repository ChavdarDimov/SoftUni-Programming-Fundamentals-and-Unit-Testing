using System.ComponentModel.Design;

namespace _04._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradeThreshold = int.Parse(Console.ReadLine());

            int poorGradeCounter = 0;
            int solvedExercises = 0;
            double sumOfGrades = 0.0;
            String lastProblem = "";

            while (poorGradeCounter < poorGradeThreshold)
            {
                String nextExercise = Console.ReadLine();

                if (nextExercise == "Enough")
                {
                    break;
                }

                lastProblem = nextExercise;

                double nextGrade = double.Parse(Console.ReadLine());
                solvedExercises++;
                sumOfGrades = sumOfGrades + nextGrade;

                if (nextGrade <= 4)
                {
                    poorGradeCounter++;
                }
            }
            if (poorGradeCounter >= poorGradeThreshold)
            {
                Console.WriteLine($"You need a break, {poorGradeCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfGrades / solvedExercises:f2}");
                Console.WriteLine($"Number of problems: {solvedExercises}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}