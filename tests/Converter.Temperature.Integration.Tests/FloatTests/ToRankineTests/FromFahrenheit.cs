using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(float.MinValue)]
    public void Test_float_extension_from_fahrenheit_and_to_rankine_returns_correct_float_value(
        float input)
    {
        // Arrange.
        // Act.
        float result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(input + 459.67f);
    }

    [Theory]
    [InlineData(float.MinValue)]
    public void
        Test_float_extension_generic_from_fahrenheit_and_to_rankine_returns_correct_float_value(
            float input)
    {
        // Arrange.
        // Act.
        float result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(input + 459.67f);
    }

    [Fact]
    public void Test_float_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.69653f;
        const float input = 392.026531f;

        // Act.
        float result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.69653f;
        const float input = 392.026531f;

        // Act.
        float result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
