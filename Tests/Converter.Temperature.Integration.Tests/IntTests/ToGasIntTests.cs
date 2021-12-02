namespace Converter.Temperature.Integration.Tests.IntTests
{
    using System;
    using Extensions.From;
    using Extensions.To;
    using FluentAssertions;
    using Xunit;

    public class ToGasIntTests
    {
        #region From Celsius

        [Fact]
        public void Test_int_extensions_from_celsius_to_gas_returns_correct_int_value()
        {
            // Arrange.
            const int expected = 6;
            const int input = 200;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(80, 0)]
        [InlineData(114, 0)]
        [InlineData(115, 0)]
        [InlineData(134, 0)]
        [InlineData(135, 1)]
        [InlineData(144, 1)]
        [InlineData(145, 2)]
        [InlineData(154, 2)]
        [InlineData(155, 3)]
        [InlineData(174, 3)]
        [InlineData(175, 4)]
        [InlineData(184, 4)]
        [InlineData(185, 5)]
        [InlineData(194, 5)]
        [InlineData(195, 6)]
        [InlineData(209, 6)]
        [InlineData(210, 7)]
        [InlineData(224, 7)]
        [InlineData(225, 8)]
        [InlineData(234, 8)]
        [InlineData(235, 9)]
        [InlineData(244, 9)]
        [InlineData(245, 10)]
        [InlineData(269, 10)]
        public void Test_int_extensions_from_celsius_to_gas_returns_correct_gas_value(int input, int expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_int_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const int input = 74536;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Theory]
        [InlineData(79, "Temp too low for gas mark!")]
        [InlineData(270, "Temp too high for gas mark!")]
        public void Test_int_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(int input, string expectedError)
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
        public void Test_int_extensions_from_fahrenheit_to_gas_returns_correct_int_value()
        {
            // Arrange.
            const int expected = 6;
            const int input = 392;

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_int_extensions_from_kelvin_to_gas_returns_correct_int_value()
        {
            // Arrange.
            const int expected = 6;
            const int input = 473;

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(10)]
        public void Test_int_extension_from_and_to_gas_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(11)]
        public void Test_int_extension_from_and_to_gas_throws_exception(int value)
        {
            // Arrange.
            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => value.FromGas().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low or too high for gas mark!");
        }

        #endregion From Gas

        #region From Rankine

        [Fact]
        public void Test_int_extensions_from_rankine_to_gas_returns_correct_int_value()
        {
            // Arrange.
            const int expected = 4;
            const int input = 807;

            // Act.
            var result = input.FromRankine().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_int_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
        {
            // Arrange.
            const int input = 405;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_int_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
        {
            // Arrange.
            const int input = 1001;

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        #endregion From Rankine
    }
}
