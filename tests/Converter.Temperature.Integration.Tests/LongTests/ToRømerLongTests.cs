using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests;

/// <summary>
///     The to rømer long tests.
/// </summary>
public sealed class ToRømerLongTests
{
    #region From Celsius

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

    #endregion From Celsius

    #region From Fahrenheit

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

    #endregion From Fahrenheit

    #region From Kelvin

    [Theory]
    [InlineData(-1000L, -661L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -110L)]
    [InlineData(1000L, 389L)]
    public void Test_long_extension_from_kelvin_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -661L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -110L)]
    [InlineData(1000L, 389L)]
    public void Test_long_extension_generic_from_kelvin_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Kelvin

    #region From Gas

    [Fact]
    public void Test_long_extension_from_gas_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 121L;
        const long input = 6L;

        // Act.
        long result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extension_generic_from_gas_to_rømer_returns_correct_long_value()
    {
        // Arrange.
        const long expected = 121L;
        const long input = 6L;

        // Act.
        long result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Gas

    #region From Rankine

    [Theory]
    [InlineData(-1000L, -428L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -121L)]
    [InlineData(100L, -107L)]
    [InlineData(500L, 10L)]
    [InlineData(1000L, 156L)]
    public void Test_long_extension_from_rankine_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000L, -428L)]
    [InlineData(0L, -136L)]
    [InlineData(50L, -121L)]
    [InlineData(100L, -107L)]
    [InlineData(500L, 10L)]
    [InlineData(1000L, 156L)]
    public void Test_long_extension_generic_from_rankine_to_rømer_returns_correct_long_value(
        long value,
        long expected)
    {
        // Arrange.
        // Act.
        long result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    #endregion From Rankine

    #region From Rømer

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_rømer_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromRømer()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_generic_from_and_to_rømer_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Rømer>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(value);
    }

    #endregion From Rømer
}
