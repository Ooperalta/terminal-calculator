namespace TerminalCalculator.Services;

public class CalculatorService : ICalculatorService
{

    private readonly List<string> _history = new List<string>();
    public double Add(double num1, double num2)
    {
        double result = num1 + num2;

        _history.Add($"{num1} + {num2} = {result}");
        return result;

    }

    public double Subtract(double num1, double num2)
    {
        double result = num1 - num2;

        _history.Add($"{num1} - {num2} = {result}");
        return result;
    }
    public double Multiply(double num1, double num2)
    {
        double result = num1 * num2;

        _history.Add($"{num1} * {num2} = {result}");
        return result;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");

        }
        else
        {
            double result = num1 / num2;

            _history.Add($"{num1} / {num2} = {result}");
            return result;
        }

    }

    public List<string> GetHistory()
    {
        return _history;
    }


}