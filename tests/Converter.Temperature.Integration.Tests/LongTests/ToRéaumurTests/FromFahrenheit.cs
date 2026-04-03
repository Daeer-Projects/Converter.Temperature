using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(-4099276460824344818L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(-4099276460824344818L);
    }

    [Theory]
    [InlineData(32L, 0L)]
    [InlineData(212L, 80L)]
    public void Test_long_extension_from_fahrenheit_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
