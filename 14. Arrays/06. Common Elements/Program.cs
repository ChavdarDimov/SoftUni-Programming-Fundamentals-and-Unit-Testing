using System.Runtime.ExceptionServices;

int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

foreach (int i in arrayOne)
{
    foreach (int j in arrayTwo)
    {
        if (i == j)
        {
            Console.Write(i + " ");
            break;
        }
    }
}