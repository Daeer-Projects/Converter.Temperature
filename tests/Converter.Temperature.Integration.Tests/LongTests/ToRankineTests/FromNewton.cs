using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToRankineTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(33L, 672L)]
    [InlineData(-1690951540090042321L, -9223372036854775805L)]
    [InlineData(1690951540090042141L, 9223372036854775806L)]
    public void Test_long_extensions_from_newton_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromNewton()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33L, 312L)]
    [InlineData(0L, 492L)]
    [InlineData(33L, 672L)]
    [InlineData(-1690951540090042321L, -9223372036854775805L)]
    [InlineData(1690951540090042141L, 9223372036854775806L)]
    public void Test_long_extensions_generic_from_newton_to_rankine_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Newton>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1690951540090042142L)]
    public void Test_long_extensions_from_newton_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(1690951540090042142L)]
    public void Test_long_extensions_generic_from_newton_to_rankine_with_invalid_parameter_throws_exception(
        long input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
