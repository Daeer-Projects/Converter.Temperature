using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80d, 311.67d)]
    [InlineData(0d, 491.67d)]
    [InlineData(80d, 671.67d)]
    public void Test_double_extensions_from_réaumur_to_rankine_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-80d, 311.67d)]
    [InlineData(0d, 491.67d)]
    [InlineData(80d, 671.67d)]
    public void Test_double_extensions_generic_from_réaumur_to_rankine_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Réaumur>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
