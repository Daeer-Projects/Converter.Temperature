using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToFahrenheitTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_from_and_to_fahrenheit_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromFahrenheit()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(value);
    }

    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extensions_generic_from_and_to_fahrenheit_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Fahrenheit>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
