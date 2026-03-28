using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToKelvinTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000d, -555.5555555555555f)]
    [InlineData(0d, 0f)]
    [InlineData(50d, 27.77777777777778f)]
    [InlineData(100d, 55.55555555555556f)]
    [InlineData(500d, 277.77777777777777f)]
    [InlineData(1000d, 555.5555555555555f)]
    public void Test_float_extension_from_rankine_and_to_kelvin_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToKelvin();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000d, -555.5555555555555f)]
    [InlineData(0d, 0f)]
    [InlineData(50d, 27.77777777777778f)]
    [InlineData(100d, 55.55555555555556f)]
    [InlineData(500d, 277.77777777777777f)]
    [InlineData(1000d, 555.5555555555555f)]
    public void Test_float_extension_generic_from_rankine_and_to_kelvin_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
