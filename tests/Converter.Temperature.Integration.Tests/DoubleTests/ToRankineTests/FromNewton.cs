using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, 311.67d)]
    [InlineData(0d, 491.67d)]
    [InlineData(33d, 671.67d)]
    public void Test_double_extensions_from_newton_to_rankine_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, 311.67d)]
    [InlineData(0d, 491.67d)]
    [InlineData(33d, 671.67d)]
    public void Test_double_extensions_generic_from_newton_to_rankine_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
