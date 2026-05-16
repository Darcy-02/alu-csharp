using System;
class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10);
        Console.Write(lastDigit);
        return lastDigit;
    }

    static void Main(string[] args)
    {
        PrintLastDigit(98);
        PrintLastDigit(0);
        PrintLastDigit(-1024);
        Console.WriteLine();
    }
}