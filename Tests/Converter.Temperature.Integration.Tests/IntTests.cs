using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests
{
    public class IntTests
    {
        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0.0)]
        [InlineData(7564.2334d)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_celsius_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromCelsius().ToCelsius();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0.0)]
        [InlineData(7564.2334d)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_fahrenheit_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromFahrenheit().ToFahrenheit();

            // Assert.
            result.Should().Be(value);
        }

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-345)]
        [InlineData(0.0)]
        [InlineData(7564.2334d)]
        [InlineData(int.MaxValue)]
        public void Test_int_extension_from_and_to_kelvin_returns_correct_int_value(int value)
        {
            // Arrange.
            // Act.
            var result = value.FromKelvin().ToKelvin();

            // Assert.
            result.Should().Be(value);
        }
    }
}
