using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33, 300)]
    [InlineData(0, 150)]
    [InlineData(33, 0)]
    [InlineData(-472446369, 2147483645)]
    [InlineData(472446435, -2147483645)]
    public void Test_int_extensions_from_newton_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromNewton()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33, 300)]
    [InlineData(0, 150)]
    [InlineData(33, 0)]
    [InlineData(-472446369, 2147483645)]
    [InlineData(472446435, -2147483645)]
    public void Test_int_extensions_generic_from_newton_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(472446436)]
    public void Test_int_extensions_from_newton_to_delisle_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromNewton()
            .ToDelisle());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }

    [Theory]
    [InlineData(472446436)]
    public void Test_int_extensions_generic_from_newton_to_delisle_with_invalid_parameter_throws_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Newton>()
            .To<Delisle>());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
