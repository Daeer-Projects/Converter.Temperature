using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRankineTests;

public class FromCelsius
{
    [Fact]
    public void Test_float_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67f;
        const float input = 200f;

        // Act.
        float result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 851.67f;
        const float input = 200f;

        // Act.
        float result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
