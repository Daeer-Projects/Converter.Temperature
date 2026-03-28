using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromFahrenheit
{
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
