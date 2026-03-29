using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Celsius;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToCelsiusTests;

public class FromNewton
{
    [Theory]
    [InlineData(0d, 0d)]
    [InlineData(33d, 100d)]
    public void Test_string_extension_from_newton_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .FromNewton()
            .ToCelsius();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }

    [Theory]
    [InlineData(0d, 0d)]
    [InlineData(33d, 100d)]
    public void Test_string_extension_generic_from_newton_and_to_celsius_returns_correct_string_value(
        double value,
        double expected)
    {
        // Arrange.
        // Act.
        string result = value.ToString(CultureInfo.InvariantCulture)
            .From<Newton>()
            .To<Celsius>();

        // Assert.
        result.Should()
            .Be(expected.ToString(CultureInfo.InvariantCulture));
    }
}
