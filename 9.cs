using System;

class Program
{
    static void Main()
    {
        int result = AddNumbers(10, 20);

        Console.WriteLine($"Sum: {result}");

        string message = GetMessage("Mandil is");
        Console.WriteLine(message);
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static string GetMessage(string name)
    {
        return $"Hello, {name}!";
    }
}
