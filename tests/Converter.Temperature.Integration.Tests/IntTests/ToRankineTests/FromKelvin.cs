using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    [InlineData(1193046470, 2147483646)]
    [InlineData(-1193046471, -2147483648)]
    public void Test_int_extension_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1800)]
    [InlineData(0, 0)]
    [InlineData(50, 90)]
    [InlineData(1000, 1800)]
    [InlineData(1193046470, 2147483646)]
    [InlineData(-1193046471, -2147483648)]
    public void Test_int_extension_generic_from_kelvin_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(1193046471)]
    [InlineData(-1193046472)]
    public void Test_int_extension_from_kelvin_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromKelvin()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(1193046471)]
    [InlineData(-1193046472)]
    public void Test_int_extension_generic_from_kelvin_to_rankine_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Kelvin>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
