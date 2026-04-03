using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToKelvinTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    public void Test_int_extension_from_fahrenheit_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(-1193046216);
    }

    [Theory]
    [InlineData(int.MinValue)]
    public void
        Test_int_extension_generic_from_fahrenheit_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
            int input)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(-1193046216);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 473;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_kelvin_with_max_value_returns_correct_value()
    {
        // Arrange.
        const int expected = 1193046726;
        const int input = int.MaxValue;

        // Act.
        int result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
