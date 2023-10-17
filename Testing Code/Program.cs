string firstInput = Console.ReadLine();
double balance = 0;

while (firstInput != "End")
{
    double nextInput = double.Parse(firstInput);

    if (nextInput >= 0)
    {
        balance += nextInput;
        Console.WriteLine($"Increase: {nextInput:F2}");
    }
    else
    {
        double absoluteValue = -nextInput;
        balance -= absoluteValue;
        Console.WriteLine($"Decrease: {absoluteValue:F2}");
    }

    firstInput = Console.ReadLine();
}

Console.WriteLine($"Balance: {balance:F2}");