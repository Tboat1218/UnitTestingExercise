using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 7)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 4)]
        public void DivideTest(int num1, int num2, int expected)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}