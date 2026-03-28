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

public sealed class ToFloatExtensionTests : BaseToExtensionTests<NewtonFloat, float>
{
    public ToFloatExtensionTests() : base(999.999f, GetData()) { }

    private static List<float> GetData()
    {
        return [999.999f, 0f, -999.999f];
    }

    protected override float To(
        NewtonFloat value,
        int fractionalCount)
    {
        return value.ToNewton(fractionalCount);
    }

    protected override float ToUsingGeneric(
        NewtonFloat value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Newton>(fractionalCount);
    }

    protected override NewtonFloat Create(
        float value)
    {
        return new NewtonFloat(value);
    }

    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        CelsiusFloat input = new(100f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        CelsiusFloat input = new(100f);

        // Act.
        float result = input.To<TemperatureTypes.Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_delisle_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        DelisleFloat input = new(0f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        FahrenheitFloat input = new(212f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_gas_returns_correct_value()
    {
        // Arrange.
        const float expected = 66f;
        GasFloat input = new(6f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        KelvinFloat input = new(373.15f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rankine_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        RankineFloat input = new(671.67f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .BeApproximately(expected, 0.00001f);
    }

    [Fact]
    public void Test_to_newton_from_réaumur_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        RéaumurFloat input = new(80f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rømer_returns_correct_value()
    {
        // Arrange.
        const float expected = 33f;
        RømerFloat input = new(60f);

        // Act.
        float result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
