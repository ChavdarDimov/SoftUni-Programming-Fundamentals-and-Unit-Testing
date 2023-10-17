int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];

for (int index = 0; index <= numbers.Length - 1; index++)
{
    numbers[index] = int.Parse(Console.ReadLine());
}

for (int indexReverse = numbers.Length -1; indexReverse >= 0; indexReverse--)
{
    Console.Write(numbers[indexReverse] + " ");
}