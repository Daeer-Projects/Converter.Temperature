using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromNewton
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    [InlineData(-885837005, -2147483648)]
    [InlineData(885837004, 2147483646)]
    public void Test_int_extension_from_newton_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromNewton()
            .ToRéaumur();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    [InlineData(-885837005, -2147483648)]
    [InlineData(885837004, 2147483646)]
    public void Test_int_extensions_generic_from_newton_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Réaumur>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(885837005)]
    public void Test_int_extensions_from_newton_to_réaumur_with_invalid_parameter_throws_exception(
        int input)
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
    [InlineData(885837005)]
    public void Test_int_extensions_generic_from_newton_to_réaumur_with_invalid_parameter_throws_exception(
        int input)
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
