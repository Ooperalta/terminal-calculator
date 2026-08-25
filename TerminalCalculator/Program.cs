using TerminalCalculator.UI;
using TerminalCalculator.Services;

var calculatorService = new CalculatorService();
var calculatorUI = new CalculatorUI(calculatorService);
calculatorUI.Run();
