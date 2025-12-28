using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(5, 8, 1, 14)]
        [InlineData(6, 10, 2, 18)]
        [InlineData(-9, 8, 1, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 4, 6)]//Add test data <-------
        [InlineData(0, 14, -14)]
        [InlineData(4, 1, 3)]
        [InlineData(22, 7, 15)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(4, 15, 60)]
        [InlineData(9, 0, 0)]
        [InlineData(13, 3, 39)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(16, 4, 4)]
        [InlineData(48, 4, 12)]
        [InlineData(12, 12, 1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
