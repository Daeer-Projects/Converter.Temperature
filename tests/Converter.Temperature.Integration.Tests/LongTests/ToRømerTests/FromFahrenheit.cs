using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRømerTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_rømer_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(-2690150177415976279L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_rømer_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(-2690150177415976279L);
    }

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
