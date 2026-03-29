using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_long_extension_from_fahrenheit_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 113L;
        const long input = 392L;

        // Act.
        long result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_fahrenheit_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 113L;
        const long input = 392L;

        // Act.
        long result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
