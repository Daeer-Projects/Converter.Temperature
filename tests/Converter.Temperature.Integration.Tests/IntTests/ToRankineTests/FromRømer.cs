using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromRømer
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-626349534)]
    [InlineData(626349262)]
    public void Test_int_extension_from_rømer_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-626349534)]
    [InlineData(626349262)]
    public void Test_int_extension_generic_from_rømer_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Rankine>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    [InlineData(-626349533, -2147483647)]
    [InlineData(626349261, 2147483647)]
    public void Test_int_extension_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -2963)]
    [InlineData(0, 466)]
    [InlineData(50, 637)]
    [InlineData(100, 809)]
    [InlineData(500, 2180)]
    [InlineData(1000, 3895)]
    [InlineData(-626349533, -2147483647)]
    [InlineData(626349261, 2147483647)]
    public void Test_int_extension_generic_from_rømer_and_to_rankine_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
