using TerminalCalculator.Services;

namespace TerminalCalculator.Tests;

public class CalculatorServiceTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var calculatorService = new CalculatorService();
        var num1 = 5;
        var num2 = 3;

        // Act
        var result = calculatorService.Add(num1, num2);
        // Assert
        Assert.Equal(8, result);
    }

    [Fact]

    public void Divide_By_Zero_ShouldThrowException()
    {
        // Arrange
        var calculatorService = new CalculatorService();
        var num1 = 4;
        var num2 = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculatorService.Divide(num1, num2));
    }
}
