using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(-9223372036854775348L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(-9223372036854775348L);
    }

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

    [Fact]
    public void Test_long_extensions_from_fahrenheit_to_rankine_with_max_value_throws_out_of_range_exception()
    {
        // Arrange.
        const long input = long.MaxValue;

        // Act.
        ArgumentOutOfRangeException ex = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit()
            .ToRankine());

        // Assert.
        ex.Message.Should().Contain("Value out of range for type.");
    }
}
