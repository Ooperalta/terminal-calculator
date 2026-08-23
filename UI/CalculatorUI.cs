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
        while(true)
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

            switch (choice)
            {
                case "1":
                // Add Logic
                break;
                case "2":
                // Subtract Logic
                break;
                case "3":
                // Multiply Logic
                break;
                case "4":
                // Divide Logic
                break;
                case "0":
                Console.WriteLine("Exiting the Calculator. Bye!");
                return;
                default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
       
        }
        

    }
}