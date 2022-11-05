using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




class RandomPasswordGenerator
{
    private const string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
    private const string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
    private const string Digits = "0123456789";
    private const string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
    private const string AllChars = CapitalLetters + SmallLetters + Digits
    + SpecialCharacters;
    private static Random rnd = new Random();



    static void Main()
    {
        StringBuilder password = new StringBuilder();
        for(int i = 1; i <= 2; i++)
            {
            char capitalLetter = GenerateChar(CapitalLetters);
            InsertAtRandomPositions(password, capitalLetter);
            }
        for(int i = 1; i <= 2; i++)
            {
            char smallLetter = GenerateChar(SmallLetters);
            InsertAtRandomPositions(password, smallLetter);
            }
        char digit = GenerateChar(Digits);
        InsertAtRandomPositions(password, digit);

        for(int i = 1; i <= 3; i++)
            {
            char specialChar = GenerateChar(SpecialCharacters);
            InsertAtRandomPositions(password, specialChar);
            }
        int count = rnd.Next(8);
        for(int i = 1; i <= count; i++)
            {
            char specialChar = GenerateChar(AllChars);
            InsertAtRandomPositions(password, specialChar);
        }
        Console.WriteLine("Your New Password is:");
        Console.WriteLine(password);
        Console.WriteLine("Your password consists of {0} elements", password.Length);
        Console.WriteLine();
        Console.WriteLine();
    }
    private static void InsertAtRandomPositions(StringBuilder password, char character)
    {
        int randomPosition = rnd.Next(password.Length + 1);
        password.Insert(randomPosition, character);
    }
    private static char GenerateChar (string availableChars)
    {
        int randomIndex = rnd.Next(availableChars.Length);
        char randomChar = availableChars[randomIndex];
        return randomChar;
    }




}
