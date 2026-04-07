using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRømerTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    public void Test_int_extension_from_fahrenheit_and_to_rømer_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(-626349399);
    }

    [Theory]
    [InlineData(int.MinValue)]
    public void
        Test_int_extension_generic_from_fahrenheit_and_to_rømer_with_invalid_values_throws_out_of_range_exception(
            int input)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(-626349399);
    }

    [Fact]
    public void Test_int_extension_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extension_generic_from_fahrenheit_to_rømer_returns_correct_int_value()
    {
        // Arrange.
        const int expected = 113;
        const int input = 392;

        // Act.
        int result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_rømer_with_max_value_returns_correct_value()
    {
        // Arrange.
        const int expected = 626349395;
        const int input = int.MaxValue;

        // Act.
        int result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
