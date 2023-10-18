using System.Windows.Input;

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int containNumber = int.Parse(command.Split(" ")[1]);
        bool doesContain = numbers.Contains(containNumber);
        
        if (doesContain)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    else if (command.StartsWith("PrintEven"))
    {
        for (int index = 0; index <= numbers.Count -1; index++)
        {
            if (numbers[index] % 2 == 0)
            {
                Console.Write(numbers[index] + " ");
            }
        }

        Console.WriteLine();
    }

    else if (command.StartsWith("PrintOdd"))
    {
        for (int index = 0; index <= numbers.Count - 1; index++)
        {
            if (numbers[index] % 2 != 0)
            {
                Console.Write(numbers[index] + " ");
            }
        }

        Console.WriteLine();
    }

    else if (command.StartsWith("GetSum"))
    {
        int sum = 0;

        for (int index = 0; index <= numbers.Count - 1; index++)
        {
            sum = sum + numbers[index];
        }

        Console.WriteLine(sum);
    }

    else if (command.StartsWith("Filter"))
    {
        string condition = command.Split(" ")[1];
        int number = int.Parse(command.Split(" ")[2]);

       if (condition == "<")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x < number)));
        }
        else if (condition == "<=")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x <= number)));
        }
        else if (condition == ">")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x > number)));
        }
        else if (condition == ">=")
        {
            Console.WriteLine(String.Join(" ", numbers.Where(x => x >= number)));
        }
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));


/* Solution #2
 * 
List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
 
string command = Console.ReadLine();
 
while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int numberContain = int.Parse(command.Split(" ")[1]);
        numbers.Contains(numberContain);
        if (numbers.Contains(numberContain))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
 
    else if (command.StartsWith("GetSum"))
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
 
        }
        Console.WriteLine(sum);
 
    }
 
    else if (command.StartsWith("PrintEven"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command.StartsWith("PrintOdd"))
    {
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
    else if (command.StartsWith("Filter"))
    {
        string condition = command.Split(" ")[1];
        int number = int.Parse(command.Split(" ")[2]);
 
        if (condition == "<")
        {
            foreach (int n in numbers)
            {
                if (n < number)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == ">")
        {
            foreach (int n in numbers)
            {
                if (n > number)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == ">=")
        {
            foreach (int n in numbers)
            {
                if (n >= number)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == "<=")
        {
            foreach (int n in numbers)
            {
                if (n <= number)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
 
    }
 
        command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));
*
*/