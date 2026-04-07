using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Réaumur;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromRømer
{
    [Theory]
    [InlineData(7, -1)]
    [InlineData(60, 80)]
    [InlineData(-1409286136, -2147483647)]
    [InlineData(1409286151, 2147483647)]
    public void Test_int_extension_from_rømer_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(7, -1)]
    [InlineData(60, 80)]
    [InlineData(-1409286136, -2147483647)]
    [InlineData(1409286151, 2147483647)]
    public void Test_int_extension_generic_from_rømer_to_réaumur_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.

        // Act.
        int result = input.From<Rømer>().To<Réaumur>();

        // Assert.
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1409286137)]
    [InlineData(1409286152)]
    public void Test_int_extension_from_rømer_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToRéaumur());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(int.MaxValue)]
    [InlineData(-1409286137)]
    [InlineData(1409286152)]
    public void Test_int_extension_generic_from_rømer_and_to_réaumur_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Réaumur>());

        // Assert.
        result.Message.Should().Contain("Value out of range for type.");
    }
}
