using System.Runtime.ExceptionServices;

int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int index1 = 0;  index1 < arrayTwo.Length; index1++)
{
    for (int index2 = 0; index2 < arrayOne.Length; index2++)
    {
        if (arrayTwo[index1] == arrayOne[index2])
        {
            Console.Write($"{arrayTwo[index1]} ");
        }
    }
}

//var intersect = arrayOne.Intersect(arrayTwo);

//foreach (int i in intersect)
//{
//    Console.Write(i + " ");
//}