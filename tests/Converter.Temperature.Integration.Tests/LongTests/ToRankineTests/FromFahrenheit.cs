using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_long_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        const long input = 392L;

        // Act.
        long result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 852L;
        const long input = 392L;

        // Act.
        long result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
