
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Calculator calc = new Calculator();
int result = calc.Add(1, 2);
Console.WriteLine(result);
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}
