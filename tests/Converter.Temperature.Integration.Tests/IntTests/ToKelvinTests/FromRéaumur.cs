using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, 173)]
    [InlineData(0, 273)]
    [InlineData(80, 373)]
    public void Test_int_extensions_from_réaumur_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, 173)]
    [InlineData(0, 273)]
    [InlineData(80, 373)]
    public void Test_int_extensions_generic_from_réaumur_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1717987138)]
    [InlineData(1717986700)]
    public void Test_int_extension_from_réaumur_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1717987138)]
    [InlineData(1717986700)]
    public void Test_int_extension_generic_from_réaumur_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1717987137, -2147483648)]
    [InlineData(1717986699, 2147483647)]
    public void Test_int_extension_from_réaumur_to_kelvin_with_boundary_values_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1717987137, -2147483648)]
    [InlineData(1717986699, 2147483647)]
    public void Test_int_extension_generic_from_réaumur_to_kelvin_with_boundary_values_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
