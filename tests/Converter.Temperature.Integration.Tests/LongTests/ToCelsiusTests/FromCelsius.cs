using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToCelsiusTests;

public class FromCelsius
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_celsius_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromCelsius()
            .ToCelsius();

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
    public void Test_long_extension_generic_from_and_to_celsius_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Celsius>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
