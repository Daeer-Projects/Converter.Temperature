using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromRømer
{
    [Theory]
    [InlineData(-1000, -1646)]
    [InlineData(0, 259)]
    [InlineData(50, 354)]
    [InlineData(100, 449)]
    [InlineData(500, 1211)]
    [InlineData(1000, 2164)]
    public void Test_int_extension_from_rømer_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.FromRømer()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-1000, -1646)]
    [InlineData(0, 259)]
    [InlineData(50, 354)]
    [InlineData(100, 449)]
    [InlineData(500, 1211)]
    [InlineData(1000, 2164)]
    public void Test_int_extension_generic_from_rømer_and_to_kelvin_returns_correct_int_value(
        int value,
        int expected)
    {
        // Arrange.
        // Act.
        int result = value.From<Rømer>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
