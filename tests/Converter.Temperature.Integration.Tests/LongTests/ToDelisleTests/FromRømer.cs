using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromRømer
{
    [Theory]
    [InlineData(8L, 150L)]
    [InlineData(60L, 0L)]
    [InlineData(-3228180212899171472L, 9223372036854775806L)]
    [InlineData(3228180212899171592L, -9223372036854775806L)]
    public void Test_long_extension_from_rømer_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Theory]
    [InlineData(8L, 150L)]
    [InlineData(60L, 0L)]
    [InlineData(-3228180212899171472L, 9223372036854775806L)]
    [InlineData(3228180212899171592L, -9223372036854775806L)]
    public void Test_long_extension_generic_from_rømer_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.From<Rømer>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .BeInRange(expected - 1, expected + 1);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-3228180212899171473L)]
    [InlineData(3228180212899171593L)]
    public void Test_long_extension_from_rømer_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        long input)
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
    [InlineData(long.MinValue)]
    [InlineData(long.MaxValue)]
    [InlineData(-3228180212899171473L)]
    [InlineData(3228180212899171593L)]
    public void Test_long_extension_generic_from_rømer_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        long input)
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
