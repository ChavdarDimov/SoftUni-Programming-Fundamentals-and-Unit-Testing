using System.Runtime.ExceptionServices;

int N = int.Parse(Console.ReadLine());

static void printLines (int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

static void printTriangle (int number)
{
    for (int i = 1; i <= number; i++)
    {
        printLines(i);
    }

    for (int i = number - 1; i >= 1; i--)
    {
        printLines(i);
    }
}

printTriangle(N);
