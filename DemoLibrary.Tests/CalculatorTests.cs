using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4,3,7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Suma_simple(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void resta_simple()
        {
            // Arrange
            double expected = 9;
            // Act
            double resp = Calculator.Subtract(10, 1);
            // Assert
            Assert.Equal(expected, resp);
        }

        [Fact]
        public void resta_negativa()
        {
            // Arrange
            double expected = -1;
            // Act
            double resp = Calculator.Subtract(1, 2);
            // Assert
            Assert.Equal(expected, resp);
        }
        [Theory]
        [InlineData(8,4,2)]
        public void Division_Simple(double x, double y, double expected)
        {
            // Arrange

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_normal_8_2()
        {
            // Arrange
            double expected = 4;

            // Act
            double resp = Calculator.Divide(8, 2);

            // Assert
            Assert.Equal(expected, resp);
        }

        [Fact]
        public void Division_numero_entre_0()
        {
            // Arrange
            double expected = 0;

            // Act
            double resp = Calculator.Divide(0, 8);

            // Assert
            Assert.Equal(expected, resp);
        }

        [Fact]
        public void Division_por_0()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(20, 0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 8)]
        [InlineData(4, 10, 10)]
        [InlineData(0, 0, 0)]
        public void el_mayor_num(int a, int b, int expected)
        {
            var result = Calculator.Max(a, b);
            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(5, 10, 5)]
        [InlineData(0, 0, 0)]
        public void el_menor_num(int a, int b, int expected)
        {
            var result = Calculator.Min(a, b);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Obtener_impares_mayores_a_0()
        {
            var result = Calculator.GetOddNumbers(5);

            Assert.Contains(1, result);
            Assert.Contains(3, result);
            Assert.Contains(5, result);
    
        }
    }
}
