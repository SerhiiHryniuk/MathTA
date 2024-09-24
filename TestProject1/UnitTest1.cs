using ConsoleApp1;
using Moq;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Mock<ICalculationService> _mockService;
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _mockService = new Mock<ICalculationService>();
        _calculator = new Calculator(_mockService.Object);
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        _mockService.Setup(s => s.Add(2, 3)).Returns(5);

        // Act
        var result = _calculator.Add(2, 3);

        // Assert
        Assert.That(result, Is.EqualTo(5));
        _mockService.Verify(s => s.Add(2, 3), Times.Once);
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        // Arrange
        _mockService.Setup(s => s.Subtract(5, 2)).Returns(3);

        // Act
        var result = _calculator.Subtract(5, 2);

        // Assert
        Assert.That(result, Is.EqualTo(3));
        _mockService.Verify(s => s.Subtract(5, 2), Times.Once);
    }

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange & Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        // Arrange
        _mockService.Setup(s => s.Multiply(4, 5)).Returns(20);

        // Act
        var result = _calculator.Multiply(4, 5);

        // Assert
        Assert.That(result, Is.EqualTo(20));
        _mockService.Verify(s => s.Multiply(4, 5), Times.Once);
    }

    [Test]
    public void IsGreaterThan_FirstNumberIsGreater_ReturnsTrue()
    {
        _mockService.Setup(s => s.IsGreaterThan(5, 3)).Returns(true);
        var result = _calculator.IsGreaterThan(5, 3);
        Assert.IsTrue(result);
        _mockService.Verify(s => s.IsGreaterThan(5, 3), Times.Once);
    }

    [Test]
    public void IsLessThan_FirstNumberIsSmaller_ReturnsTrue()
    {
        _mockService.Setup(s => s.IsLessThan(2, 4)).Returns(true);
        var result = _calculator.IsLessThan(2, 4);
        Assert.IsTrue(result);
        _mockService.Verify(s => s.IsLessThan(2, 4), Times.Once);
    }

    [Test]
    public void IsEqual_TwoNumbersAreEqual_ReturnsTrue()
    {
        _mockService.Setup(s => s.IsEqual(7, 7)).Returns(true);
        var result = _calculator.IsEqual(7, 7);
        Assert.IsTrue(result);
        _mockService.Verify(s => s.IsEqual(7, 7), Times.Once);
    }

    [Test]
    public void IsEqual_TwoNumbersAreNotEqual_ReturnsFalse()
    {
        _mockService.Setup(s => s.IsEqual(5, 3)).Returns(false);
        var result = _calculator.IsEqual(5, 3);
        Assert.IsFalse(result);
        _mockService.Verify(s => s.IsEqual(5, 3), Times.Once);
    }
}