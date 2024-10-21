using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    public static void Main(string[] args)
    {
        CheckForPositiveNegativeZero(0);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(-1);
        Console.WriteLine();

        FindMinimum(24,12,6);
        FindMinimum(24,3,6);
        FindMinimum(2,3,6);
        Console.WriteLine();

        FindMaximum(24,12,6);
        FindMaximum(24,3,65);
        FindMaximum(2,34,6);
        Console.WriteLine();

        IsDivisibleBy5(5);
        IsDivisibleBy5(23);
        IsDivisibleBy5(30);
        Console.WriteLine();

        CheckEvenOrOdd(5);
        CheckEvenOrOdd(22);
        CheckEvenOrOdd(30);
        Console.WriteLine();

        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('h');
        CheckVowelOrConsonant('A');
        Console.WriteLine();

        DisplayDayOfWeek(3);
        DisplayDayOfWeek(7);
        DisplayDayOfWeek(5);
    }

    public static void CheckForPositiveNegativeZero(double number)
    {
        Console.WriteLine($"Your Number is {(number > 0 ? "Positive" : number < 0 ? "Negative" : "Zero")}.");
    }

    public static void FindMinimum(int x, int y, int z)
    {
        int min = x;
        min = min > y ? y : min;
        min = min > z ? z : min;
        Console.WriteLine($"The minimum value is {min}.");
    }

    public static void FindMaximum(int x, int y, int z)
    {
        int max = x;
        max = max < y ? y : max;
        max = max < z ? z : max;
        Console.WriteLine($"The maximum value is {max}.");
    }

    public static void IsDivisibleBy5(int x)
    {
        Console.WriteLine($"{x} is {(x%5 != 0 ? "not " : "")}divisible by 5.");
    }

    public static void CheckEvenOrOdd(int x)
    {
        Console.WriteLine($"{x} is an {(x%2 == 0 ? "Even" : "Odd")} number.");
    }

    public static void CheckVowelOrConsonant(char x)
    {
        char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
        Console.WriteLine($"{x} is a {(vowels.Contains(Char.ToLower(x)) ? "Vowel" : "Consonant")}.");
    }

    public static void DisplayDayOfWeek(int day)
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.WriteLine(days[day - 1]);
    }
}
