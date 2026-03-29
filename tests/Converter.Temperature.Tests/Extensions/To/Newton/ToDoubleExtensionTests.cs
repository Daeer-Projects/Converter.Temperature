using System.Collections.Generic;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Delisle;
using Converter.Temperature.Types.Fahrenheit;
using Converter.Temperature.Types.Gas;
using Converter.Temperature.Types.Kelvin;
using Converter.Temperature.Types.Newton;
using Converter.Temperature.Types.Rankine;
using Converter.Temperature.Types.Réaumur;
using Converter.Temperature.Types.Rømer;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.To.Newton;

public sealed class ToDoubleExtensionTests : BaseToExtensionTests<NewtonDouble, double>
{
    public ToDoubleExtensionTests() : base(999.999d, GetData()) { }

    private static List<double> GetData()
    {
        return [999.999d, 0d, -999.999d];
    }

    protected override double To(
        NewtonDouble value,
        int fractionalCount)
    {
        return value.ToNewton(fractionalCount);
    }

    protected override double ToUsingGeneric(
        NewtonDouble value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Newton>(fractionalCount);
    }

    protected override NewtonDouble Create(
        double value)
    {
        return new NewtonDouble(value);
    }

    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        CelsiusDouble input = new(100d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        CelsiusDouble input = new(100d);

        // Act.
        double result = input.To<TemperatureTypes.Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_delisle_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        DelisleDouble input = new(0d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        FahrenheitDouble input = new(212d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_gas_returns_correct_value()
    {
        // Arrange.
        const double expected = 66d;
        GasDouble input = new(6d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        KelvinDouble input = new(373.15d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rankine_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        RankineDouble input = new(671.67d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.00000000001d);
    }

    [Fact]
    public void Test_to_newton_from_réaumur_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        RéaumurDouble input = new(80d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rømer_returns_correct_value()
    {
        // Arrange.
        const double expected = 33d;
        RømerDouble input = new(60d);

        // Act.
        double result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
