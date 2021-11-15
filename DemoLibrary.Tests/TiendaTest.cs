using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Tienda;
using Xunit;

namespace Software.Tests
{
    public class TiendaTest
    {
        [Fact]
        public void nombreTest()
        {
            var p = new Product("A", 2.00);
            Assert.Equal("A", p.GetName());
            Assert.Equal(2.00, p.GetPrice());
        }
        [Fact]
        public void PriceTest()
        {
            var p = new Product("A", 5.20);
            Assert.Equal(5.20, p.GetPrice());
        }

        [Theory]
        [InlineData(40,8)]
        [InlineData(0, 0)]
        [InlineData(0, -10)]
        public void TestTotalPedido(double expected,double cant)
        {
            // Arrange
            var p = new Product("A", 5);
            // Act
            double resp = p.GetTotal(cant);
            // Assert
            Assert.Equal(expected , resp);
        }
    }
}
