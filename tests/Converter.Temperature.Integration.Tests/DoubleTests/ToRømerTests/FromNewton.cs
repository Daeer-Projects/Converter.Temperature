using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, -45d)]
    [InlineData(0d, 7.5d)]
    [InlineData(33d, 60d)]
    public void Test_double_extensions_from_newton_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, -45d)]
    [InlineData(0d, 7.5d)]
    [InlineData(33d, 60d)]
    public void Test_double_extensions_generic_from_newton_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
