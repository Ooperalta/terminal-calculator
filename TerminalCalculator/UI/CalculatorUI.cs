using TerminalCalculator.Services;

namespace TerminalCalculator.UI;

public class CalculatorUI
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorUI(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }



    public void Run()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("""
            ===========================
               TERMINAL CALCULATOR
            ===========================
            1. Add
            2. Subtract
            3. Multiply
            4. Divide
            5. View History
            6. Complete Operation
            0. Exit
            ===========================
            Choose an option: 
            """);

            string? choice = Console.ReadLine();

            double num1;
            double num2;
            char operatorChar;
            double result;
            string askFirstNumber = "Enter the first number: ";
            string askSecondNumber = "Enter the second number: ";
            string askCompleteOperation = "Enter the complete operation (e.g., 5 + 3): ";

            switch (choice)
            {
                case "1":
                    num1 = GetNumberFromUser(askFirstNumber);
                    num2 = GetNumberFromUser(askSecondNumber);
                    result = _calculatorService.Add(num1, num2);

                    Console.WriteLine($"Result: {result}");
                    Console.ReadLine();
                    break;
                case "2":
                    num1 = GetNumberFromUser(askFirstNumber);
                    num2 = GetNumberFromUser(askSecondNumber);
                    result = _calculatorService.Subtract(num1, num2);

                    Console.WriteLine($"Result: {result}");
                    Console.ReadLine();
                    break;
                case "3":
                    num1 = GetNumberFromUser(askFirstNumber);
                    num2 = GetNumberFromUser(askSecondNumber);
                    result = _calculatorService.Multiply(num1, num2);

                    Console.WriteLine($"Result: {result}");
                    Console.ReadLine();
                    break;
                case "4":
                    num1 = GetNumberFromUser(askFirstNumber);
                    num2 = GetNumberFromUser(askSecondNumber);
                    ExecuteDivision(num1, num2);

                    break;
                case "5":
                    List<string> history = _calculatorService.GetHistory();
                    if (history.Count == 0)
                    {
                        Console.WriteLine("No history available.");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("Calculation History:");
                        foreach (string item in history)
                        {
                            Console.WriteLine(item);

                        }
                        Console.ReadLine();
                    }

                    break;
                case "6":
                    (num1, operatorChar, num2) = GetCompleteOperationFromUser(askCompleteOperation);
                    switch (operatorChar)
                    {
                        case '+':
                            result = _calculatorService.Add(num1, num2);
                            Console.WriteLine($"Result: {result}");
                            Console.ReadLine();
                            break;
                        case '-':
                            result = _calculatorService.Subtract(num1, num2);
                            Console.WriteLine($"Result: {result}");
                            Console.ReadLine();
                            break;
                        case '*':
                            result = _calculatorService.Multiply(num1, num2);
                            Console.WriteLine($"Result: {result}");
                            Console.ReadLine();
                            break;
                        case '/':
                            ExecuteDivision(num1, num2);

                            break;

                    }


                    break;
                case "0":
                    Console.WriteLine("Exiting the Calculator.Bye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadLine();
                    break;
            }

        }


    }

    private double GetNumberFromUser(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double convertedNumber))
            {
                return convertedNumber;
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid number.");
            }
        }


    }

    private (double, char, double) GetCompleteOperationFromUser(string message)
    {
        while (true)
        {
            char[] operators = { '+', '-', '*', '/' };
            Console.Write(message);


            string operationInput = Console.ReadLine() ?? string.Empty;
            operationInput = operationInput.Replace(" ", "");
            int operatorPosition = operationInput.IndexOfAny(operators, 1);
            if (operatorPosition == -1)
            {
                Console.WriteLine("Invalid operation. Please enter a valid operation.");
                continue;
            }
            char operatorChar = operationInput[operatorPosition];
            string num1 = operationInput.Substring(0, operatorPosition);
            string num2 = operationInput.Substring(operatorPosition + 1);
            if (double.TryParse(num1, out double firstConvertedNumber) && double.TryParse(num2, out double secondConvertedNumber))
            {
                return (firstConvertedNumber, operatorChar, secondConvertedNumber);
            }
            else
            {
                Console.WriteLine("Invalid operation. Please enter a valid operation.");
                continue;
            }
        }



    }

    private double ExecuteDivision(double num1, double num2)
    {
        try
        {
            var result = _calculatorService.Divide(num1, num2);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
            return result;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.ReadLine();
            return double.NaN;
        }

    }
}