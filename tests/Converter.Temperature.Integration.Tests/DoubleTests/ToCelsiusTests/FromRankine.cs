using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToCelsiusTests;

public class FromRankine
{
    [Theory]
    [InlineData(0d, -273.15d)]
    [InlineData(50d, -245.3722222222222d)]
    [InlineData(100d, -217.59444444444446d)]
    [InlineData(500d, 4.627777777777769d)]
    [InlineData(1000d, 282.40555555555557d)]
    public void Test_double_extension_from_rankine_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToCelsius();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -273.15d)]
    [InlineData(50d, -245.3722222222222d)]
    [InlineData(100d, -217.59444444444446d)]
    [InlineData(500d, 4.627777777777769d)]
    [InlineData(1000d, 282.40555555555557d)]
    public void Test_double_extension_generic_from_rankine_and_to_celsius_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -273.15d, -1)]
    [InlineData(50d, -245.3722222222222d, -1)]
    [InlineData(100d, -217.59444444444446d, -1)]
    [InlineData(500d, 4.627777777777769d, -1)]
    [InlineData(1000d, 282.40555555555557d, -1)]
    [InlineData(0d, -273d, 0)]
    [InlineData(50d, -245d, 0)]
    [InlineData(100d, -218d, 0)]
    [InlineData(500d, 5d, 0)]
    [InlineData(1000d, 282d, 0)]
    [InlineData(0d, -273.2d, 1)]
    [InlineData(50d, -245.37d, 2)]
    [InlineData(100d, -217.6d, 1)]
    [InlineData(500d, 4.62777777777777d, 14)]
    [InlineData(1000d, 282.41d, 2)]
    public void Test_double_extension_with_parameter_from_rankine_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToCelsius(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(0d, -273.15d, -1)]
    [InlineData(50d, -245.3722222222222d, -1)]
    [InlineData(100d, -217.59444444444446d, -1)]
    [InlineData(500d, 4.627777777777769d, -1)]
    [InlineData(1000d, 282.40555555555557d, -1)]
    [InlineData(0d, -273d, 0)]
    [InlineData(50d, -245d, 0)]
    [InlineData(100d, -218d, 0)]
    [InlineData(500d, 5d, 0)]
    [InlineData(1000d, 282d, 0)]
    [InlineData(0d, -273.2d, 1)]
    [InlineData(50d, -245.37d, 2)]
    [InlineData(100d, -217.6d, 1)]
    [InlineData(500d, 4.62777777777777d, 14)]
    [InlineData(1000d, 282.41d, 2)]
    public void Test_double_extension_generic_with_parameter_from_rankine_and_to_celsius_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Celsius>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
