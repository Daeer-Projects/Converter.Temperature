using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300f, -45f)]
    [InlineData(150f, 7.5f)]
    [InlineData(0f, 60f)]
    public void Test_float_extensions_from_delisle_to_rømer_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromDelisle()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(300f, -45f)]
    [InlineData(150f, 7.5f)]
    [InlineData(0f, 60f)]
    public void Test_float_extensions_generic_from_delisle_to_rømer_returns_correct_float_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Delisle>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
