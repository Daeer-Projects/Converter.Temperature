using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80, 300)]
    [InlineData(0, 150)]
    [InlineData(80, 0)]
    public void Test_int_extensions_from_réaumur_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-80, 300)]
    [InlineData(0, 150)]
    [InlineData(80, 0)]
    public void Test_int_extensions_generic_from_réaumur_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1145324533)]
    [InlineData(1145324693)]
    public void Test_int_extension_from_réaumur_to_delisle_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRéaumur()
            .ToDelisle());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1145324533)]
    [InlineData(1145324693)]
    public void Test_int_extension_generic_from_réaumur_to_delisle_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Réaumur>()
            .To<Delisle>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1145324531, 2147483646)]
    [InlineData(1145324692, -2147483648)]
    public void Test_int_extension_from_réaumur_to_delisle_with_boundary_values_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRéaumur()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1145324531, 2147483646)]
    [InlineData(1145324692, -2147483648)]
    public void Test_int_extension_generic_from_réaumur_to_delisle_with_boundary_values_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Réaumur>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
