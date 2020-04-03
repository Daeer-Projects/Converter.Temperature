using System;

using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests
{
    public class ToGasDoubleTests
    {
        #region From Celsius

        [Fact]
        public void Test_double_extensions_from_celsius_to_gas_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 6d;
            const double input = 200d;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(80d, 0.25d)]
        [InlineData(114d, 0.25d)]
        [InlineData(115d, 0.5d)]
        [InlineData(134d, 0.5d)]
        [InlineData(135d, 1d)]
        [InlineData(144d, 1d)]
        [InlineData(145d, 2d)]
        [InlineData(154d, 2d)]
        [InlineData(155d, 3d)]
        [InlineData(174d, 3d)]
        [InlineData(175d, 4d)]
        [InlineData(184d, 4d)]
        [InlineData(185d, 5d)]
        [InlineData(194d, 5d)]
        [InlineData(195d, 6d)]
        [InlineData(209d, 6d)]
        [InlineData(210d, 7d)]
        [InlineData(224d, 7d)]
        [InlineData(225d, 8d)]
        [InlineData(234d, 8d)]
        [InlineData(235d, 9d)]
        [InlineData(244d, 9d)]
        [InlineData(245d, 10d)]
        [InlineData(269d, 10d)]
        public void Test_double_extensions_from_celsius_to_gas_returns_correct_gas_value(double input, double expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_double_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const double input = 74536.9876d;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Theory]
        [InlineData(79d, "Temp too low for gas mark!")]
        [InlineData(270d, "Temp too high for gas mark!")]
        public void Test_double_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(double input, string expectedError)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain(expectedError);
        }

        #endregion From Celsius

        #region From Fahrenheit

        [Fact]
        public void Test_double_extensions_from_fahrenheit_to_gas_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 6d;
            const double input = 392d;

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_double_extensions_from_kelvin_to_gas_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 6d;
            const double input = 473.15d;

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(0.25d)]
        [InlineData(3d)]
        [InlineData(5d)]
        [InlineData(8d)]
        [InlineData(10d)]
        public void Test_double_extension_from_and_to_gas_returns_correct_double_value(double value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(0.24d)]
        [InlineData(10.1d)]
        public void Test_double_extension_from_and_to_gas_throws_exception(double value)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => value.FromGas().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas
    }
}
