using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33f, 300f)]
    [InlineData(0f, 150f)]
    [InlineData(33f, 0f)]
    public void Test_float_extensions_from_newton_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromNewton()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-33f, 300f)]
    [InlineData(0f, 150f)]
    [InlineData(33f, 0f)]
    public void Test_float_extensions_generic_from_newton_to_delisle_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Newton>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
