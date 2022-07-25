using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 6, 4, 14)]
        [InlineData(3, 9, 5, 17)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange// create a Calculator object

            var Calculator = new Calculator();
                

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = Calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 6, 6)]
        [InlineData(6, 2, 4)]
        [InlineData(2, 2, 0)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 3, 36)]
        [InlineData(3, 6, 18)]
        [InlineData(24, 2, 48)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Calculator = new Calculator();

            //Act
            var actual = Calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, 2, -1)]
        [InlineData(10, 0, 0)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Calculator = new Calculator();
            //Act
            var actual = Calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
