using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests
{
    public class ToGasStringTests
    {
        #region From Celsius

        [Fact]
        public void Test_string_extensions_from_celsius_to_gas_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "6";
            const string input = "200";

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData("80", "0.25")]
        [InlineData("114", "0.25")]
        [InlineData("115", "0.5")]
        [InlineData("134", "0.5")]
        [InlineData("135", "1")]
        [InlineData("144", "1")]
        [InlineData("145", "2")]
        [InlineData("154", "2")]
        [InlineData("155", "3")]
        [InlineData("174", "3")]
        [InlineData("175", "4")]
        [InlineData("184", "4")]
        [InlineData("185", "5")]
        [InlineData("194", "5")]
        [InlineData("195", "6")]
        [InlineData("209", "6")]
        [InlineData("210", "7")]
        [InlineData("224", "7")]
        [InlineData("225", "8")]
        [InlineData("234", "8")]
        [InlineData("235", "9")]
        [InlineData("244", "9")]
        [InlineData("245", "10")]
        [InlineData("269", "10")]
        public void Test_string_extensions_from_celsius_to_gas_returns_correct_gas_value(string input, string expected)
        {
            // Arrange.
            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_from_celsius_to_gas_with_large_value_throws_exception()
        {
            // Arrange.
            const string input = "74536.9876";

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        [Theory]
        [InlineData("79", "Temp too low for gas mark!")]
        [InlineData("270", "Temp too high for gas mark!")]
        public void Test_string_extensions_from_celsius_to_gas_with_invalid_parameters_throws_exception(string input, string expectedError)
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
        public void Test_string_extensions_from_fahrenheit_to_gas_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "6";
            const string input = "392";

            // Act.
            var result = input.FromFahrenheit().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Fahrenheit

        #region From Kelvin

        [Fact]
        public void Test_string_extensions_from_kelvin_to_gas_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "6";
            const string input = "473.15";

            // Act.
            var result = input.FromKelvin().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        #endregion From Kelvin

        #region From Gas

        [Theory]
        [InlineData("0.25")]
        [InlineData("3")]
        [InlineData("5")]
        [InlineData("8")]
        [InlineData("10")]
        public void Test_string_extension_from_and_to_gas_returns_correct_string_value(string value)
        {
            // Arrange.
            // Act.
            var result = value.FromGas().ToGas();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData("0.24")]
        [InlineData("10.1")]
        public void Test_string_extension_from_and_to_gas_throws_exception(string value)
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
        public void Test_string_extensions_from_rankine_to_gas_returns_correct_string_value()
        {
            // Arrange.
            const string expected = "3";
            const string input = "806.67";

            // Act.
            var result = input.FromRankine().ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_string_extensions_from_rankine_to_gas_with_low_invalid_value_throws_exception()
        {
            // Arrange.
            const string input = "405.2368";

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too low for gas mark!");
        }

        [Fact]
        public void Test_string_extensions_from_rankine_to_gas_with_high_invalid_value_throws_exception()
        {
            // Arrange.
            const string input = "1002.89786";

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRankine().ToGas());

            // Assert.
            result.Message.Should().Contain("Temp too high for gas mark!");
        }

        #endregion From Rankine
    }
}
