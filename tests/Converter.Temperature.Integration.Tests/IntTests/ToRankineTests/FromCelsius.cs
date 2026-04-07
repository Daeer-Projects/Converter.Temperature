using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromCelsius
{
    [Theory]
    [InlineData(200, 852)]
    [InlineData(1193046197, 2147483646)]
    [InlineData(-1193046743, -2147483646)]
    public void Test_int_extensions_from_celsius_to_rankine_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(200, 852)]
    [InlineData(1193046197, 2147483646)]
    [InlineData(-1193046743, -2147483646)]
    public void Test_int_extensions_generic_from_celsius_to_rankine_returns_correct_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(1193046198)]
    [InlineData(-1193046745)]
    public void Test_int_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromCelsius()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(1193046198)]
    [InlineData(-1193046745)]
    public void Test_int_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Celsius>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
