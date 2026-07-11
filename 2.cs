using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");

        string name = "Mandil";
        int age = 30;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");

        if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Minor");
        }

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Count: {i}");
        }
    }
}
