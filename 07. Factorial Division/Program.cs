static int FactorialCalculator(int number)
{
    int output = 1;

    for (int factorial = 1; factorial <= number; factorial++)
    {
        output = output * factorial;
    }

    return output;
}

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factorialOne = FactorialCalculator(num1);
int factorialTwo = FactorialCalculator(num2);

int result = factorialOne / factorialTwo;

Console.WriteLine(result);