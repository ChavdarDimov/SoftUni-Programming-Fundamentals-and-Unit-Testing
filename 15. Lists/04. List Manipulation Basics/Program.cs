List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Add"))
    {
        int addNumber = int.Parse(command.Split(" ")[1]);
        numbers.Add(addNumber);

        command = Console.ReadLine();
    }

    else if (command.StartsWith("Insert"))
    {
        int insertNumber = int.Parse(command.Split(" ")[1]);
        int numberPosition = int.Parse(command.Split(" ")[2]);
        numbers.Insert(numberPosition, insertNumber);

        command = Console.ReadLine();
    }

    else if (command.StartsWith("RemoveAt"))
    {
        int removeAtNumber = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(removeAtNumber); ;

        command = Console.ReadLine();
    }

    else if (command.StartsWith("Remove"))
    {
        int removeNumber = int.Parse(command.Split(" ")[1]);
        numbers.Remove(removeNumber); ;

        command = Console.ReadLine();
    }
}

Console.WriteLine(string.Join(" ", numbers));