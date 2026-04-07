using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(7686143364045646683L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_delisle_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Delisle>();

        // Assert.
        result.Should()
            .Be(7686143364045646683L);
    }

    [Theory]
    [InlineData(32L, 150L)]
    [InlineData(212L, 0L)]
    public void Test_long_extension_from_fahrenheit_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
