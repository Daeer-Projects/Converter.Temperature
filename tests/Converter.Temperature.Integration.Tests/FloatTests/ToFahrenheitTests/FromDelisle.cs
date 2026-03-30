using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300f, -148f)]
    [InlineData(150f, 32f)]
    [InlineData(0f, 212f)]
    public void Test_float_extensions_from_delisle_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(300f, -148f)]
    [InlineData(150f, 32f)]
    [InlineData(0f, 212f)]
    public void Test_float_extensions_generic_from_delisle_to_fahrenheit_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
