using Sum2BigNums;
using System;

class Program
{
    static void Main()
    {
        var adder = new BigNumberAdder();

        Console.WriteLine("Enter the first number:");
        string num1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string num2 = Console.ReadLine();

        string result = adder.Sum(num1, num2);
        Console.WriteLine($"The sum of {num1} and {num2} is {result}");
    }
}
