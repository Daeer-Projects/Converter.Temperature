using Converter.Temperature.Extensions.To;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To
{
    public class ToIntExtensionsTests
    {
        [Fact]
        public void Test_to_celsius_with_celsius_returns_same_value()
        {
            // Arrange.
            var input = new CelsiusInt(42);

            // Act.
            var result = input.ToCelsius();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_celsius_with_fahrenheit_returns_correct_value()
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
        public void Test_to_celsius_with_gas_returns_correct_value()
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
        public void Test_to_celsius_with_kelvin_returns_correct_value()
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
        public void Test_to_fahrenheit_with_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 54;
            var input = new CelsiusInt(12);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_fahrenheit_with_fahrenheit_returns_correct_value()
        {
            // Arrange.
            var input = new FahrenheitInt(50);

            // Act.
            var result = input.ToFahrenheit();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_fahrenheit_with_gas_returns_correct_value()
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
        public void Test_to_fahrenheit_with_kelvin_returns_correct_value()
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
        public void Test_to_gas_with_celsius_returns_correct_value()
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
        public void Test_to_gas_with_fahrenheit_returns_correct_value()
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
        public void Test_to_gas_with_gas_returns_same_value()
        {
            // Arrange.
            var input = new GasInt(7);

            // Act.
            var result = input.ToGas();

            // Assert.
            result.Should().Be(input.Temperature);
        }

        [Fact]
        public void Test_to_gas_with_kelvin_returns_correct_value()
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
        public void Test_to_kelvin_with_celsius_returns_correct_value()
        {
            // Arrange.
            const int expected = 473;
            var input = new CelsiusInt(200);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_to_kelvin_with_fahrenheit_returns_correct_value()
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
        public void Test_to_kelvin_with_gas_returns_correct_value()
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
        public void Test_to_kelvin_with_kelvin_returns_same_value()
        {
            // Arrange.
            var input = new KelvinInt(473);

            // Act.
            var result = input.ToKelvin();

            // Assert.
            result.Should().Be(input.Temperature);
        }
    }
}
