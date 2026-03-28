using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rankine;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRankineTests;

public class FromGas
{
    [Fact]
    public void Test_double_extension_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRankine();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_gas_to_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 851.67d;
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rankine>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.67d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extension_with_parameter_from_gas_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRankine(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(851.67d, -1)]
    [InlineData(852d, 0)]
    [InlineData(851.67d, 2)]
    public void Test_double_extension_generic_with_parameter_from_gas_to_rankine_returns_correct_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rankine>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
