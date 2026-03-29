using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromRankine
{
    [Theory]
    [InlineData(-1000f, -427.57043f)]
    [InlineData(0f, -135.90376f)]
    [InlineData(50f, -121.32041666666666f)]
    [InlineData(100f, -106.73709f)]
    [InlineData(500f, 9.92958f)]
    [InlineData(1000f, 155.76291f)]
    public void Test_float_extension_from_rankine_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f)]
    [InlineData(0f, -135.90376f)]
    [InlineData(50f, -121.32041666666666f)]
    [InlineData(100f, -106.73709f)]
    [InlineData(500f, 9.92958f)]
    [InlineData(1000f, 155.76291f)]
    public void Test_float_extension_generic_from_rankine_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f, -1)]
    [InlineData(0f, -135.90376f, -1)]
    [InlineData(50f, -121.32041666666666f, -1)]
    [InlineData(100f, -106.73709f, -1)]
    [InlineData(500f, 9.92958f, -1)]
    [InlineData(1000f, 155.76291f, -1)]
    [InlineData(-1000f, -428f, 0)]
    [InlineData(0f, -136f, 0)]
    [InlineData(50f, -121f, 0)]
    [InlineData(100f, -107f, 0)]
    [InlineData(500f, 10f, 0)]
    [InlineData(1000f, 156f, 0)]
    [InlineData(-1000f, -427.6f, 1)]
    [InlineData(0f, -135.90376f, 13)]
    [InlineData(50f, -121.3204f, 4)]
    [InlineData(100f, -106.7f, 1)]
    [InlineData(500f, 9.92958f, 7)]
    [InlineData(1000f, 155.76291f, 14)]
    public void Test_float_extension_with_parameter_from_rankine_to_rømer_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.FromRankine()
            .ToRømer(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000f, -427.57043f, -1)]
    [InlineData(0f, -135.90376f, -1)]
    [InlineData(50f, -121.32041666666666f, -1)]
    [InlineData(100f, -106.73709f, -1)]
    [InlineData(500f, 9.92958f, -1)]
    [InlineData(1000f, 155.76291f, -1)]
    [InlineData(-1000f, -428f, 0)]
    [InlineData(0f, -136f, 0)]
    [InlineData(50f, -121f, 0)]
    [InlineData(100f, -107f, 0)]
    [InlineData(500f, 10f, 0)]
    [InlineData(1000f, 156f, 0)]
    [InlineData(-1000f, -427.6f, 1)]
    [InlineData(0f, -135.90376f, 13)]
    [InlineData(50f, -121.3204f, 4)]
    [InlineData(100f, -106.7f, 1)]
    [InlineData(500f, 9.92958f, 7)]
    [InlineData(1000f, 155.76291f, 14)]
    public void Test_float_extension_generic_with_parameter_from_rankine_to_rømer_returns_correct_float_value(
        float value,
        float expected,
        int fractionalCount)
    {
        // Arrange.
        // Act.
        float result = value.From<Rankine>()
            .To<Rømer>(fractionalCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
