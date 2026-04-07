using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    public void Test_long_extension_from_fahrenheit_and_to_newton_with_invalid_values_throws_out_of_range_exception(
        long input)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(-1690951540090042237L);
    }

    [Theory]
    [InlineData(long.MinValue)]
    public void
        Test_long_extension_generic_from_fahrenheit_and_to_newton_with_invalid_values_throws_out_of_range_exception(
            long input)
    {
        // Arrange.
        // Act.
        long result = input.From<Fahrenheit>()
            .To<Newton>();

        // Assert.
        result.Should()
            .Be(-1690951540090042237L);
    }

    [Theory]
    [InlineData(212L, 33L)]
    [InlineData(32L, 0L)]
    public void Test_long_extension_from_fahrenheit_to_newton_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromFahrenheit()
            .ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
