using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToDelisleTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33d, 300d)]
    [InlineData(0d, 150d)]
    [InlineData(33d, 0d)]
    public void Test_double_extensions_from_newton_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromNewton()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-33d, 300d)]
    [InlineData(0d, 150d)]
    [InlineData(33d, 0d)]
    public void Test_double_extensions_generic_from_newton_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Newton>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
