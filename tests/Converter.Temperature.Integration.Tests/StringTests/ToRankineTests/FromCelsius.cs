using System;
using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToRankineTests;

public class FromCelsius
{
        [Fact]
    public void Test_string_extensions_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        const string input = "200";

        // Act.
        string result = input.FromCelsius()
            .ToRankine();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_string_extensions_generic_from_celsius_to_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "851.67";
        const string input = "200";

        // Act.
        string result = input.From<Celsius>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("851.67", -1)]
    [InlineData("852", 0)]
    [InlineData("851.67", 2)]
    public void Test_string_extensions_with_parameter_from_celsius_to_rankine_returns_correct_value(
        string expected,
        int fractionalCount)
    {
        // Arrange.
        const string input = "200";

        // Act.
        string result = input.FromCelsius()
            .ToRankine(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("851.67", -1)]
    [InlineData("852", 0)]
    [InlineData("851.67", 2)]
    public void Test_string_extensions_generic_with_parameter_from_celsius_to_rankine_returns_correct_value(
        string expected,
        int fractionalCount)
    {
        // Arrange.
        const string input = "200";

        // Act.
        string result = input.From<Celsius>()
            .To<Rankine>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        Action action = () => input
            .ToString(CultureInfo.InvariantCulture)
            .FromCelsius()
            .ToRankine();

        // Assert.
        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_string_extensions_generic_from_celsius_to_rankine_with_invalid_parameter_throws_exception(
        double input)
    {

        // Arrange.
        // Act.
        Action action = () => input
            .ToString(CultureInfo.InvariantCulture)
            .From<Celsius>()
            .To<Rankine>();

        // Assert.
        action.Should()
            .Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }
}
