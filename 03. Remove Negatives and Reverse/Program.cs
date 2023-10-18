List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

for (int index = numbers.Count - 1; index >= 0; index--)
{
    if (numbers[index] < 0)
    {
        numbers.RemoveAt(index);
    }
}

numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else if (numbers.Count >= 1)
{
    Console.WriteLine(string.Join(" ", numbers));
}