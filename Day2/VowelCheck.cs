using System;

namespace MyConsoleApp.Day2;

public class VowelCheck
{
    public static void CheckVowel()
    {
        char ch = char.Parse(Console.ReadLine());

        switch (char.ToLower(ch))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
    }
}
