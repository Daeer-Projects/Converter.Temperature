using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromGas
{
    [Fact]
    public void Test_double_extension_from_gas_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_gas_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_double_extension_with_parameter_from_gas_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.FromGas()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_double_extension_generic_with_parameter_from_gas_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 6d;

        // Act.
        double result = input.From<Gas>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
