using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToCelsiusTests;

public class FromRømer
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1127428908)]
    [InlineData(1127428923)]
    public void Test_int_extension_from_rømer_and_to_celsius_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToCelsius());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1127428908)]
    [InlineData(1127428923)]
    public void Test_int_extension_generic_from_rømer_and_to_celsius_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Celsius>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    [InlineData(-1127428907, -2147483647)]
    [InlineData(1127428922, 2147483647)]
    public void Test_int_extension_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, -14)]
    [InlineData(50, 81)]
    [InlineData(100, 176)]
    [InlineData(500, 938)]
    [InlineData(1000, 1890)]
    [InlineData(-1127428907, -2147483647)]
    [InlineData(1127428922, 2147483647)]
    public void Test_int_extension_generic_from_rømer_and_to_celsius_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
