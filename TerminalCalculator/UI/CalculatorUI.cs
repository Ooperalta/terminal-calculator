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
            0. Exit
            ===========================
            Choose an option: 
            """);

            string? choice = Console.ReadLine();

            double num1;
            double num2;
            double result;
            string askFirstNumber = "Enter the first number: ";
            string askSecondNumber = "Enter the second number: ";

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
                    try
                    {
                        num1 = GetNumberFromUser(askFirstNumber);
                        num2 = GetNumberFromUser(askSecondNumber);
                        result = _calculatorService.Divide(num1, num2);

                        Console.WriteLine($"Result: {result}");
                        Console.ReadLine();
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }

                    break;
                case "0":
                    Console.WriteLine("Exiting the Calculator. Bye!");
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


}