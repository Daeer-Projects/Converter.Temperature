namespace Converter.Temperature.Tests.Extensions.To
{
    using System;
    using FluentAssertions;
    using Temperature.Extensions.To;
    using Types.Celsius;
    using Types.Fahrenheit;
    using Types.Gas;
    using Types.Kelvin;
    using Types.Rankine;
    using Xunit;

    public class ToIntExtensionsTests
    {
        [Fact]
        public void Test_to_celsius_from_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusInt(42);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const int expected = 10;
            var input = new FahrenheitInt(50);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_gas_returns_correct_value()
        {
            // Arrange.
            const int expected = 220;
            var input = new GasInt(7);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 1;
            var input = new KelvinInt(274);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_celsius_from_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = -121;
            var input = new RankineInt(274);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 54;
            var input = new CelsiusInt(12);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void Test_to_fahrenheit_from_celsius_with_invalid_parameter_throws_exception(int input)
        {
            // Arrange.
            var inputCelsius = new CelsiusInt(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToFahrenheit());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_fahrenheit_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitInt(50);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_from_gas_returns_correct_value()
        {
            // Arrange.
            const int expected = 428;
            var input = new GasInt(7);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 34;
            var input = new KelvinInt(274);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_from_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = -186;
            var input = new RankineInt(274);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 6;
            var input = new CelsiusInt(200);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const int expected = 6;
            var input = new FahrenheitInt(392);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasInt(7);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 6;
            var input = new KelvinInt(473);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_gas_from_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = 6;
            var input = new RankineInt(862);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = new CelsiusInt(200);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MaxValue)]
        public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception(int input)
        {
            // Arrange.
            var inputCelsius = new CelsiusInt(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToKelvin());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = new FahrenheitInt(392);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_gas_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = new GasInt(6);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_from_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinInt(473);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_kelvin_from_rankine_returns_correct_value()
        {
            // Arrange.
            const int expected = 479;
            var input = new RankineInt(862);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 852;
            var input = new CelsiusInt(200);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(int.MaxValue)]
        public void Test_to_rankine_from_celsius_with_invalid_parameter_throws_exception(int input)
        {
            // Arrange.
            var inputCelsius = new CelsiusInt(input);

            // Act.
            var result = Assert.Throws<ArgumentOutOfRangeException>(() => inputCelsius.ToRankine());

            // Assert.
            result.Message.Should().Contain("Value out of range for type.");
        }

        [Fact]
        public void Test_to_rankine_from_fahrenheit_returns_correct_value()
        {
            // Arrange.
            const int expected = 716;
            var input = new FahrenheitInt(256);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_gas_returns_correct_value()
        {
            // Arrange.
            const int expected = 852;
            var input = new GasInt(6);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_kelvin_returns_correct_value()
        {
            // Arrange.
            const int expected = 11860;
            var input = new KelvinInt(6589);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_rankine_from_rankine_returns_same_value()
        {
            // Arrange.
            var input = new RankineInt(862);

            // Act.
            var result = input.ToRankine();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}
