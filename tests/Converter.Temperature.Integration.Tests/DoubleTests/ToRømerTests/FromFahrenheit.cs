using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Rømer;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRømerTests;

public class FromFahrenheit
{
    [Fact]
    public void Test_double_extension_from_fahrenheit_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 392d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRømer();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Fact]
    public void Test_double_extension_generic_from_fahrenheit_to_rømer_returns_correct_double_value()
    {
        // Arrange.
        const double expected = 112.5d;
        const double input = 392d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rømer>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_double_extension_with_parameter_from_fahrenheit_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392.94d;

        // Act.
        double result = input.FromFahrenheit()
            .ToRømer(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }

    [Theory]
    [InlineData(112.77416666666666d, -1)]
    [InlineData(113d, 0)]
    [InlineData(112.77d, 2)]
    public void Test_double_extension_generic_with_parameter_from_fahrenheit_to_rømer_returns_correct_double_value(
        double expected,
        int fractionCount)
    {
        // Arrange.
        const double input = 392.94d;

        // Act.
        double result = input.From<Fahrenheit>()
            .To<Rømer>(fractionCount);

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
