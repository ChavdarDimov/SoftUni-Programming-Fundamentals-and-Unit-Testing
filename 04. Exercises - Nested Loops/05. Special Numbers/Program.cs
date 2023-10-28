namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine() ?? "1");

            for (int cn = 1111; cn <= 9999; cn++)
            {
                string cnDigits = cn.ToString();
                bool isSpecial = true;

                foreach (char digitChar in cnDigits)
                {
                    int curDigitNumber = digitChar - '0';

                    if (curDigitNumber == 0 || number % curDigitNumber != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                    Console.Write(cn + " ");
            }
        }
    }