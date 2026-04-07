using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromRømer
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1127429052)]
    [InlineData(1127428780)]
    public void Test_int_extension_from_rømer_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToKelvin());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1127429052)]
    [InlineData(1127428780)]
    public void Test_int_extension_generic_from_rømer_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Kelvin>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1000, -1646)]
    [InlineData(0, 259)]
    [InlineData(50, 354)]
    [InlineData(100, 449)]
    [InlineData(500, 1211)]
    [InlineData(1000, 2164)]
    [InlineData(-1127429051, -2147483648)]
    [InlineData(1127428779, 2147483647)]
    public void Test_int_extension_from_rømer_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1646)]
    [InlineData(0, 259)]
    [InlineData(50, 354)]
    [InlineData(100, 449)]
    [InlineData(500, 1211)]
    [InlineData(1000, 2164)]
    [InlineData(-1127429051, -2147483648)]
    [InlineData(1127428779, 2147483647)]
    public void Test_int_extension_generic_from_rømer_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
