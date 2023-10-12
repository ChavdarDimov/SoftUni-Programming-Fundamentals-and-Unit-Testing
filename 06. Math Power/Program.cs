int baseNumber = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

static int mathPower(int baseNumber, int power)
{
    int output = (int)Math.Pow(baseNumber, power);
    return output;
}

Console.WriteLine(mathPower(baseNumber, power));