List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Delete"))
    {
        int deleteNumber = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAll(number => number == deleteNumber);

        command = Console.ReadLine();
    }

    else if (command.StartsWith("Insert"))
    {
        int insertNumber = int.Parse(command.Split(" ")[1]);
        int numberPosition = int.Parse(command.Split(" ")[2]);
        numbers.Insert(numberPosition , insertNumber);

        command = Console.ReadLine();
    }
}

Console.WriteLine(string.Join(" ", numbers));