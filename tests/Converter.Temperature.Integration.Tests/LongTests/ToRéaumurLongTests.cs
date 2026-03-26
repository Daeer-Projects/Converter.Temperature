using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests;

/// <summary>
///     The to réaumur long tests.
/// </summary>
public sealed class ToRéaumurLongTests
{
    #region From Fahrenheit

    [Theory]
    [InlineData(32L, 0L)]
    [InlineData(212L, 80L)]
    public void Test_long_extension_from_fahrenheit_to_réaumur_returns_correct_long_value(long input, long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Fahrenheit

    #region From Celsius

    [Theory]
    [InlineData(0L, 0L)]
    [InlineData(100L, 80L)]
    public void Test_long_extension_from_celsius_to_réaumur_returns_correct_long_value(long input, long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromCelsius()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_celsius_to_réaumur_returns_correct_long_value()
    {
        // Arrange.
        const long input = 100L;
        const long expected = 80L;

        // Act.
        long result = input.FromCelsius()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Celsius
}
