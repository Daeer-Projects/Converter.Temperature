using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromCelsius
{
    [Fact]
    public void Test_long_extension_from_celsius_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 113L;
        const long input = 200L;

        // Act.
        long result = input.FromCelsius()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_celsius_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 113L;
        const long input = 200L;

        // Act.
        long result = input.From<Celsius>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
