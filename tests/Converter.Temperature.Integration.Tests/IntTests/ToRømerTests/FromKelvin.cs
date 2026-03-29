using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromKelvin
{
    [Theory]
    [InlineData(-1000, -661)]
    [InlineData(0, -136)]
    [InlineData(50, -110)]
    [InlineData(1000, 389)]
    public void Test_int_extension_from_kelvin_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromKelvin()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -661)]
    [InlineData(0, -136)]
    [InlineData(50, -110)]
    [InlineData(1000, 389)]
    public void Test_int_extension_generic_from_kelvin_to_rømer_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Kelvin>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
