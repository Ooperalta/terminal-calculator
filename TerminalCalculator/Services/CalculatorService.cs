namespace TerminalCalculator.Services;

public class CalculatorService : ICalculatorService
{

    private readonly List<string> _history = new List<string>();

    public CalculatorService()
    {
        LoadHistoryFromFile();
    }
    public double Add(double num1, double num2)
    {
        double result = num1 + num2;
        string historyEntry = $"{num1} + {num2} = {result}";
        LogOperation(historyEntry);
        return result;

    }

    public double Subtract(double num1, double num2)
    {
        double result = num1 - num2;
        string historyEntry = $"{num1} - {num2} = {result}";
        LogOperation(historyEntry);
        return result;
    }
    public double Multiply(double num1, double num2)
    {
        double result = num1 * num2;
        string historyEntry = $"{num1} * {num2} = {result}";
        LogOperation(historyEntry);
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
            string historyEntry = $"{num1} / {num2} = {result}";
            LogOperation(historyEntry);
            return result;
        }

    }

    public void LogOperation(string operation)
    {
        _history.Add(operation);
        File.AppendAllText("History.txt", operation + Environment.NewLine);
    }

    public void LoadHistoryFromFile()
    {
        if (File.Exists("History.txt"))
        {
            _history.AddRange(File.ReadAllLines("History.txt"));
        }
    }

    public List<string> GetHistory()
    {
        return _history;
    }


}