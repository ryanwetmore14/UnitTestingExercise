using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(0, 1, 1, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -1, -1, -3)]
        [InlineData(-2, 1, 1, 0)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }


        [Theory]
        [InlineData(0, 1, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-2, 1, -3)]
        public void Subtract_Test(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }



        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-2, 1, -2)]
        public void Multiply_Test(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 1, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(10, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-2, 1, -2)]
        public void Divide_Test(int num1, int num2, int expected)
        {
            //Arrange
            var c = new Calculator();

            //Act
            var actual = c.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
