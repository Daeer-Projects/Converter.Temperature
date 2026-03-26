using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Kelvin;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Kelvin;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<KelvinDouble, double>
{
    public ToDoubleExtensionTests() : base(999.9999d, GetData()) { }

    private static List<double> GetData()
    {
        return new List<double> { 999.999d, 0d, -999.999 };
    }

    protected override double To(
        KelvinDouble value,
        int fractionalCount)
    {
        return value.ToKelvin(fractionalCount);
    }

    protected override double ToUsingGeneric(
        KelvinDouble value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Kelvin>(fractionalCount);
    }

    protected override KelvinDouble Create(
        double value)
    {
        return new KelvinDouble(value);
    }

    [Fact]
    public void Test_to_kelvin_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        CelsiusDouble input = new(200);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_kelvin_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        double expected = input;
        CelsiusDouble inputCelsius = new(input);

        // Act.
        double result = inputCelsius.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(double.MaxValue)]
    public void Test_to_kelvin_generic_from_celsius_with_invalid_parameter_throws_exception(
        double input)
    {
        // Arrange.
        double expected = input;
        CelsiusDouble inputCelsius = new(input);

        // Act.
        double result = inputCelsius.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15000000000003d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15000000000003d;
        FahrenheitDouble input = new(392);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        GasDouble input = new(6);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.15d;
        GasDouble input = new(6);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(473.15d, -1)]
    [InlineData(473d, 0)]
    [InlineData(473.2d, 1)]
    public void Test_to_kelvin_with_parameter_from_gas_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        GasDouble input = new(6);

        // Act.
        double result = input.ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(473.15d, -1)]
    [InlineData(473d, 0)]
    [InlineData(473.2d, 1)]
    public void Test_to_kelvin_generic_with_parameter_from_gas_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        GasDouble input = new(6);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_kelvin_returns_same_value()
    {
        // Arrange.
        KelvinDouble input = new(473.15);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }

    [Fact]
    public void Test_to_kelvin_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.1499999999999d;
        RankineDouble input = new(851.67);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_kelvin_generic_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 473.1499999999999d;
        RankineDouble input = new(851.67);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.807142857143d, 493.47d)]
    [InlineData(773.15d, 270d)]
    [InlineData(663.15d, 212.25d)]
    [InlineData(563.15d, 159.75d)]
    [InlineData(258.8642857142857d, 0d)]
    [InlineData(0d, -135.90375d)]
    public void Test_to_kelvin_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.ToKelvin();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.807142857143d, 493.47d)]
    [InlineData(773.15d, 270d)]
    [InlineData(663.15d, 212.25d)]
    [InlineData(563.15d, 159.75d)]
    [InlineData(258.8642857142857d, 0d)]
    [InlineData(0d, -135.90375d)]
    public void Test_to_kelvin_generic_from_rømer_returns_correct_value(
        double expected,
        double originalTemp)
    {
        // Arrange.
        RømerDouble input = new(originalTemp);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.8d, 1)]
    [InlineData(1198.80714285714d, 11)]
    public void Test_to_kelvin_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.ToKelvin(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(1198.8d, 1)]
    [InlineData(1198.80714285714d, 11)]
    public void Test_to_kelvin_generic_with_parameter_from_rømer_returns_correct_value(
        double expected,
        int fractionalCount)
    {
        // Arrange.
        RømerDouble input = new(493.47d);

        // Act.
        double result = input.To<TemperatureTypes.Kelvin>(fractionalCount);

        // Assert.
        result.Should()
            .Be(expected);
    }
}
