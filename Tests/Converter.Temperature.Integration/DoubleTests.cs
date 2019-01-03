using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration
{
    public class DoubleTests
    {
        [Fact]
        public void Test_double_extension_from_and_to_celsius_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 39d;

            // Act.
            var result = expected.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_double_extension_from_celsius_and_to_fahrenheit_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 53.6d;
            const double input = 12d;

            // Act.
            var result = input.FromCelsius().ToFahrenheit();

            // Assert.
            result.Should().Be(expected);
        }

        [Fact]
        public void Test_double_extension_from_celsius_and_to_gas_returns_correct_double_value()
        {
            // Arrange.
            const double expected = 6d;
            const double input = 200d;

            // Act.
            var result = input.FromCelsius().ToGas();

            // Assert.
            result.Should().Be(expected);
        }
    }
}