using System;

using CalculatorProject;
class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        Calculate cal = new();

        var result = cal.Addition(a, b);
        Console.WriteLine(result);
        
        Console.ReadKey();
    }
}