using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(-80d, -45d)]
    [InlineData(0d, 7.5d)]
    [InlineData(80d, 60d)]
    public void Test_double_extensions_from_réaumur_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromRéaumur()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-80d, -45d)]
    [InlineData(0d, 7.5d)]
    [InlineData(80d, 60d)]
    public void Test_double_extensions_generic_from_réaumur_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Réaumur>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
