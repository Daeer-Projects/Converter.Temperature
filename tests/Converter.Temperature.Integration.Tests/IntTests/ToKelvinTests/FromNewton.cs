using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33, 173)]
    [InlineData(0, 273)]
    [InlineData(33, 373)]
    [InlineData(-708669694, -2147483648)]
    [InlineData(708669513, 2147483646)]
    public void Test_int_extensions_from_newton_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33, 173)]
    [InlineData(0, 273)]
    [InlineData(33, 373)]
    [InlineData(-708669694, -2147483648)]
    [InlineData(708669513, 2147483646)]
    public void Test_int_extensions_generic_from_newton_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(708669514)]
    public void Test_int_extensions_from_newton_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(708669514)]
    public void Test_int_extensions_generic_from_newton_to_kelvin_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
