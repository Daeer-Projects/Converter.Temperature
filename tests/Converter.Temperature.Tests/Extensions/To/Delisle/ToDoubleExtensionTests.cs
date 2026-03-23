using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Delisle;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Delisle;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<DelisleDouble, double>
{
    public ToDoubleExtensionTests() : base(9999.999d, GetData()) { }

    private static List<double> GetData()
    {
        return new List<double>
        {
            999.999d,
            0d,
            -999.999d
        };
    }

    protected override double To(
        DelisleDouble value,
        int fractionalCount)
    {
        return value.ToDelisle(fractionalCount);
    }

    protected override double ToUsingGeneric(
        DelisleDouble value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Delisle>(fractionalCount);
    }

    protected override DelisleDouble Create(
        double value)
    {
        return new DelisleDouble(value);
    }

    [Fact]
    public void Test_to_delisle_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        CelsiusDouble input = new(0d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        CelsiusDouble input = new(0d);

        // Act.
        double result = input.To<TemperatureTypes.Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        FahrenheitDouble input = new(32d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_generic_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        FahrenheitDouble input = new(32d);

        // Act.
        double result = input.To<TemperatureTypes.Delisle>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = -150d;
        GasDouble input = new(6d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        KelvinDouble input = new(273.15d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        RankineDouble input = new(491.67d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.00000000001d);
    }

    [Fact]
    public void Test_to_delisle_from_rømer_returns_correct_value()
    {
        // Arrange.
        const double expected = 150d;
        RømerDouble input = new(7.5d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_delisle_from_delisle_returns_same_value()
    {
        // Arrange.
        DelisleDouble input = new(150d);

        // Act.
        double result = input.ToDelisle();

        // Assert.
        result.Should()
            .Be(input.Temperature);
    }
}
