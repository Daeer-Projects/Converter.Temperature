using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000d, -1459.67f)]
    [InlineData(0d, -459.67f)]
    [InlineData(50d, -409.67f)]
    [InlineData(100d, -359.67f)]
    [InlineData(500d, 40.329987f)]
    [InlineData(1000d, 540.32996f)]
    public void Test_float_extension_from_rankine_and_to_fahrenheit_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000d, -1459.67f)]
    [InlineData(0d, -459.67f)]
    [InlineData(50d, -409.67f)]
    [InlineData(100d, -359.67f)]
    [InlineData(500d, 40.329987f)]
    [InlineData(1000d, 540.32996f)]
    public void Test_float_extension_generic_from_rankine_and_to_fahrenheit_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
