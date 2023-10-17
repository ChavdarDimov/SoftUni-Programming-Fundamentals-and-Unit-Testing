int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

bool isIdentical = true;

for (int index = 0; index < arrayOne.Length; index++)
{
    if (arrayOne[index] != arrayTwo[index])
    {
        isIdentical = false;
        Console.WriteLine("Arrays are not identical.");
        break;
    }
}

if (isIdentical)
{
    Console.WriteLine("Arrays are identical.");
}