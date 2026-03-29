using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000d, -660.9037500000001d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -109.65374999999999d)]
    [InlineData(1000d, 389.09625d)]
    public void Test_double_extension_from_kelvin_to_rømer_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(-1000d, -660.9037500000001d)]
    [InlineData(0d, -135.90375d)]
    [InlineData(50d, -109.65374999999999d)]
    [InlineData(1000d, 389.09625d)]
    public void Test_double_extension_generic_from_kelvin_to_rømer_returns_correct_double_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        double result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
