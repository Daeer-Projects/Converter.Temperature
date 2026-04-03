using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(-5124095576030430749L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_kelvin_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(-5124095576030430749L);
    }

    [Fact]
    public void Test_long_extensions_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 392L;

        // Act.
        long result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_generic_from_fahrenheit_to_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 473L;
        const long input = 392L;

        // Act.
        long result = input.From<Fahrenheit>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_long_extensions_from_fahrenheit_to_kelvin_with_max_value_returns_correct_value()
    {
        // Arrange.
        const long expected = 5124095576030431259L;
        const long input = long.MaxValue;

        // Act.
        long result = input.FromFahrenheit()
            .ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
