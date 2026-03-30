using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToCelsiusTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300f, -100f)]
    [InlineData(150f, 0f)]
    [InlineData(0f, 100f)]
    public void Test_float_extensions_from_delisle_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromDelisle()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(300f, -100f)]
    [InlineData(150f, 0f)]
    [InlineData(0f, 100f)]
    public void Test_float_extensions_generic_from_delisle_to_celsius_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Delisle>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
