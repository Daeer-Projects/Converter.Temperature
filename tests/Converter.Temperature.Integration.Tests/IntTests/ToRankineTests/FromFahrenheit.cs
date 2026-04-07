using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRankineTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    public void Test_int_extension_from_fahrenheit_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(-2147483188);
    }

    [Theory]
    [InlineData(int.MinValue)]
    public void
        Test_int_extension_generic_from_fahrenheit_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
            int input)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(-2147483188);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_fahrenheit_to_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 852;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(int.MaxValue)]
    public void Test_int_extensions_from_fahrenheit_and_to_rankine_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromFahrenheit()
            .ToRankine());

        // Assert.
        result.Message.Should()
            .Contain("Value out of range for type.");
    }
}
