using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromNewton
{
    [Theory]
    [InlineData(-33, 173)]
    [InlineData(0, 273)]
    [InlineData(33, 373)]
    public void Test_int_extensions_from_newton_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromNewton()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(-33, 173)]
    [InlineData(0, 273)]
    [InlineData(33, 373)]
    public void Test_int_extensions_generic_from_newton_to_kelvin_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Newton>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
