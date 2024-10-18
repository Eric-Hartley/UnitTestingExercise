using System;
using Xunit;
using Xunit.Sdk;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 5, 7, 16)]
        [InlineData(1, 15, 9, 25)]
        [InlineData(22, 19, 1, 42)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var Calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = Calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(2, 5, -3)]
        [InlineData(10, 5, 5)]
        [InlineData(5, 5, 0)]
        [InlineData(7, 11, -4)]//Add test data <-------
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
        [InlineData(1, 4, 4)]
        [InlineData(1, 1, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(4, 5, 20)]
        [InlineData(6, 8, 48)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Calculator = new Calculator();
            //Act
            var actual = Calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(20, 4, 5)]
        [InlineData(5, 2, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(0, 1, 0)]//Add test data <-------
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
