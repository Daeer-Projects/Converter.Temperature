using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300d, -45d)]
    [InlineData(150d, 7.5d)]
    [InlineData(0d, 60d)]
    public void Test_double_extensions_from_delisle_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromDelisle()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(300d, -45d)]
    [InlineData(150d, 7.5d)]
    [InlineData(0d, 60d)]
    public void Test_double_extensions_generic_from_delisle_to_rømer_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.From<Delisle>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
