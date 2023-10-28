int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

int rotations = int.Parse(Console.ReadLine());

int[] result = new int[numbers.Length];

for (int i = 0; i < numbers.Length; i++)
{
    int newIndex = (i - rotations + numbers.Length) % numbers.Length;
    result[newIndex] = numbers[i];
}

Console.WriteLine(string.Join(" ", result));