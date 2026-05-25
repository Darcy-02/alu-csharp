using System;

class Program
{
    static void Main(string[] args)
    {
        int[] newArray;

        newArray = MyArray.CreatePrint(5);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = MyArray.CreatePrint(16);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = MyArray.CreatePrint(0);
        Console.WriteLine("Array Length: " + newArray.Length);
        Console.WriteLine("----------------");
        newArray = MyArray.CreatePrint(-10);
    }
}