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
        
        var Sub = cal.Subtraction(a, b);
        Console.WriteLine(Sub);

        var Mul = cal.Multiplication(a, b);
        Console.WriteLine(Mul);

        var Div = cal.Division(a, b);
        Console.WriteLine(Div);

        var Mod = cal.Modulus(a, b);
        Console.WriteLine(Mod);

       

        Console.ReadKey();
    }
}