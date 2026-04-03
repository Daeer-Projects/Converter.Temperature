using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(int.MinValue)]
    public void Test_int_extension_from_fahrenheit_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        int input)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(1789569883);
    }

    [Theory]
    [InlineData(int.MinValue)]
    public void
        Test_int_extension_generic_from_fahrenheit_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
            int input)
    {
        // Arrange.
        // Act.
        int result = input.From<Fahrenheit>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(1789569883);
    }

    [Theory]
    [InlineData(32, 150)]
    [InlineData(212, 0)]
    public void Test_int_extension_from_fahrenheit_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_int_extensions_from_fahrenheit_to_delisle_with_max_value_returns_correct_value()
    {
        // Arrange.
        const int expected = -1789569529;
        const int input = int.MaxValue;

        // Act.
        int result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
