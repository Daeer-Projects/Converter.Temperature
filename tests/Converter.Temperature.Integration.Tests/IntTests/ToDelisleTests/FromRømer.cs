using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromRømer
{
    [Theory]
    [InlineData(8, 150)]
    [InlineData(60, 0)]
    [InlineData(-751619216, 2147483646)]
    [InlineData(751619336, -2147483646)]
    public void Test_int_extension_from_rømer_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Theory]
    [InlineData(8, 150)]
    [InlineData(60, 0)]
    [InlineData(-751619216, 2147483646)]
    [InlineData(751619336, -2147483646)]
    public void Test_int_extension_generic_from_rømer_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Rømer>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-751619217)]
    [InlineData(751619337)]
    public void Test_int_extension_from_rømer_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToDelisle());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-751619217)]
    [InlineData(751619337)]
    public void Test_int_extension_generic_from_rømer_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Delisle>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
