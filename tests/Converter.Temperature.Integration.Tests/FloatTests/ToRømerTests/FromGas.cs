using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromGas
{
    [Fact]
    public void Test_float_extension_from_gas_to_rømer_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extension_generic_from_gas_to_rømer_returns_correct_float_value()
    {
        // Arrange.
        const float expected = 112.5f;
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_float_extension_with_parameter_from_gas_to_rømer_returns_correct_float_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 6f;

        // Act.
        float result = input.FromGas()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(112.5d, -1)]
    [InlineData(112d, 0)]
    [InlineData(112.5d, 2)]
    public void Test_float_extension_generic_with_parameter_from_gas_to_rømer_returns_correct_float_value(
        float expected,
        int fractionCount)
    {
        // Arrange.
        const float input = 6f;

        // Act.
        float result = input.From<Gas>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
