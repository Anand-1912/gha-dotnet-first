using CalculatorLibrary;

namespace CalculatorConsole;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var calc = new AdvancedCalculator();

        Console.WriteLine($"The Sum of 10 and 20 is {calc.Add(10,20)}");
    }
}
