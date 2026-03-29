using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRømerTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000d, -660.9037500000001f)]
    [InlineData(0d, -135.90375f)]
    [InlineData(50d, -109.65374999999999f)]
    [InlineData(1000d, 389.09625f)]
    public void Test_float_extension_from_kelvin_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(-1000d, -660.9037500000001f)]
    [InlineData(0d, -135.90375f)]
    [InlineData(50d, -109.65374999999999f)]
    [InlineData(1000d, 389.09625f)]
    public void Test_float_extension_generic_from_kelvin_to_rømer_returns_correct_float_value(
        float value,
        float expected)
    {
        // Arrange.
        // Act.
        float result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }
}
