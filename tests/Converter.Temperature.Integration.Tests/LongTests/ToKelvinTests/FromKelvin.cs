using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToKelvinTests;

public class FromKelvin
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(-345L)]
    [InlineData(0L)]
    [InlineData(7564L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_and_to_kelvin_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromKelvin()
            .ToKelvin();

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
    public void Test_long_extension_generic_from_and_to_kelvin_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.From<Kelvin>()
            .To<Kelvin>();

        // Assert.
        result.Should()
            .Be(value);
    }
}
