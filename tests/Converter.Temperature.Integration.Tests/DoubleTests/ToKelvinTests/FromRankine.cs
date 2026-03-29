using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToKelvinTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000d, -555.5555555555555d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 27.77777777777778d)]
    [InlineData(100d, 55.55555555555556d)]
    [InlineData(500d, 277.77777777777777d)]
    [InlineData(1000d, 555.5555555555555d)]
    public void Test_double_extension_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d)]
    [InlineData(0d, 0d)]
    [InlineData(50d, 27.77777777777778d)]
    [InlineData(100d, 55.55555555555556d)]
    [InlineData(500d, 277.77777777777777d)]
    [InlineData(1000d, 555.5555555555555d)]
    public void Test_double_extension_generic_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d, -1)]
    [InlineData(0d, 0d, -1)]
    [InlineData(50d, 27.77777777777778d, -1)]
    [InlineData(100d, 55.55555555555556d, -1)]
    [InlineData(500d, 277.77777777777777d, -1)]
    [InlineData(1000d, 555.5555555555555d, -1)]
    [InlineData(-1000d, -556d, 0)]
    [InlineData(0d, 0d, 0)]
    [InlineData(50d, 28d, 0)]
    [InlineData(100d, 56d, 0)]
    [InlineData(500d, 278d, 0)]
    [InlineData(1000d, 556d, 0)]
    [InlineData(-1000d, -555.6d, 1)]
    [InlineData(50d, 27.7777777777778d, 13)]
    [InlineData(100d, 55.5556d, 4)]
    [InlineData(500d, 277.8d, 1)]
    [InlineData(1000d, 555.5555556d, 7)]
    public void Test_double_extension_with_parameter_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.FromRankine()
            .ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555d, -1)]
    [InlineData(0d, 0d, -1)]
    [InlineData(50d, 27.77777777777778d, -1)]
    [InlineData(100d, 55.55555555555556d, -1)]
    [InlineData(500d, 277.77777777777777d, -1)]
    [InlineData(1000d, 555.5555555555555d, -1)]
    [InlineData(-1000d, -556d, 0)]
    [InlineData(0d, 0d, 0)]
    [InlineData(50d, 28d, 0)]
    [InlineData(100d, 56d, 0)]
    [InlineData(500d, 278d, 0)]
    [InlineData(1000d, 556d, 0)]
    [InlineData(-1000d, -555.6d, 1)]
    [InlineData(50d, 27.7777777777778d, 13)]
    [InlineData(100d, 55.5556d, 4)]
    [InlineData(500d, 277.8d, 1)]
    [InlineData(1000d, 555.5555556d, 7)]
    public void Test_double_extension_generic_with_parameter_from_rankine_and_to_kelvin_returns_correct_double_value(
        double value,
        double expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        double result = value.From<Rankine>()
            .To<Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
