using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRéaumurTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33L, -80L)]
    [InlineData(0L, 0L)]
    [InlineData(33L, 80L)]
    [InlineData(-3804640965202595021L, long.MinValue)]
    [InlineData(3804640965202595020L, 9223372036854775806L)]
    public void Test_long_extensions_from_newton_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33L, -80L)]
    [InlineData(0L, 0L)]
    [InlineData(33L, 80L)]
    [InlineData(-3804640965202595021L, long.MinValue)]
    [InlineData(3804640965202595020L, 9223372036854775806L)]
    public void Test_long_extensions_generic_from_newton_to_réaumur_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(3804640965202595021L)]
    public void Test_long_extensions_from_newton_to_réaumur_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToRéaumur());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(3804640965202595021L)]
    public void Test_long_extensions_generic_from_newton_to_réaumur_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Réaumur>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
