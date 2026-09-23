namespace TerminalCalculator.Services;

public interface ICalculatorService
{
    double Add(double num1, double num2);
    double Subtract(double num1, double num2);
    double Multiply(double num1, double num2);
    double Divide(double num1, double num2);

    void LogOperation(string operation);

    void LoadHistoryFromFile();
    List<string> GetHistory();

}