namespace _06._Exam_Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToExam = int.Parse(Console.ReadLine());

            for (int day = daysToExam; day > 0; day -= 1)
            {
                Console.WriteLine($"{day} days before the exam");
            }

            Console.WriteLine("The exam has come");
        }
    }
}