using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_int_extension_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
