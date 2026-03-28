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

public sealed class ToIntExtensionTests : BaseToExtensionTests<NewtonInt, int>
{
    public ToIntExtensionTests() : base(999, GetData()) { }

    private static List<int> GetData()
    {
        return [999, 0, -999];
    }

    protected override int To(
        NewtonInt value,
        int fractionalCount)
    {
        return value.ToNewton();
    }

    protected override int ToUsingGeneric(
        NewtonInt value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Newton>();
    }

    protected override NewtonInt Create(
        int value)
    {
        return new NewtonInt(value);
    }

    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        CelsiusInt input = new(100);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        CelsiusInt input = new(100);

        // Act.
        int result = input.To<TemperatureTypes.Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_delisle_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        DelisleInt input = new(0);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        FahrenheitInt input = new(212);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_gas_returns_correct_value()
    {
        // Arrange.
        const int expected = 76;
        GasInt input = new(7);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        KelvinInt input = new(373);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rankine_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        RankineInt input = new(671);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_réaumur_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        RéaumurInt input = new(80);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rømer_returns_correct_value()
    {
        // Arrange.
        const int expected = 33;
        RømerInt input = new(60);

        // Act.
        int result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
