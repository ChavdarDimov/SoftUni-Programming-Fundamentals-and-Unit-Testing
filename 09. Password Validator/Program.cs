using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        if (!PasswordValidatorLength(password))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }

        if (!PasswordValidatorOnlyLAndD(password))
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }

        if (!PasswordValidator2Digits(password))
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

        if (PasswordValidatorLength(password) && PasswordValidatorOnlyLAndD(password) && PasswordValidator2Digits(password))
        {
            Console.WriteLine("Password is valid");
        }
    }

    static bool PasswordValidatorLength(string password)
    {
        return password.Length >= 6 && password.Length <= 10;
    }

    static bool PasswordValidatorOnlyLAndD(string password)
    {
        for (int checker = 0; checker < password.Length; checker++)
        {
            char singleCharacter = password[checker];

            if (!char.IsLetterOrDigit(singleCharacter))
            {
                return false;
            }
        }

        return true;
    }

    static bool PasswordValidator2Digits(string password)
    {
        int digitCount = 0;

        for (int checker = 0; checker < password.Length; checker++)
        {
            char singleCharacter = password[checker];

            if (char.IsDigit(singleCharacter))
            {
                digitCount++;
            }

            if (digitCount >= 2)
            {
                return true;
            }
        }

        return false;
    }
}