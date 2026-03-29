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

public sealed class ToStringExtensionTests : BaseToExtensionTests<NewtonString, string>
{
    public ToStringExtensionTests() : base("9999", GetData()) { }

    private static List<string> GetData()
    {
        return ["999.999", "0", "-999.999"];
    }

    protected override string To(
        NewtonString value,
        int fractionalCount)
    {
        return value.ToNewton(fractionalCount);
    }

    protected override string ToUsingGeneric(
        NewtonString value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Newton>(fractionalCount);
    }

    protected override NewtonString Create(
        string value)
    {
        return new NewtonString(value);
    }

    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        CelsiusString input = new("100");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        CelsiusString input = new("100");

        // Act.
        string result = input.To<TemperatureTypes.Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_delisle_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        DelisleString input = new("0");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        FahrenheitString input = new("212");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_gas_returns_correct_value()
    {
        // Arrange.
        const string expected = "66";
        GasString input = new("6");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        KelvinString input = new("373.15");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rankine_returns_correct_value()
    {
        // Arrange.
        const string expected = "32.999999999999986";
        RankineString input = new("671.67");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_réaumur_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        RéaumurString input = new("80");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rømer_returns_correct_value()
    {
        // Arrange.
        const string expected = "33";
        RømerString input = new("60");

        // Act.
        string result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
