using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, 173)]
    [InlineData(150, 273)]
    [InlineData(0, 373)]
    public void Test_int_extensions_from_delisle_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, 173)]
    [InlineData(150, 273)]
    [InlineData(0, 373)]
    public void Test_int_extensions_generic_from_delisle_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
