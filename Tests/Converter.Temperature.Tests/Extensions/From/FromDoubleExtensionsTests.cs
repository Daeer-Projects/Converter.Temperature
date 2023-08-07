namespace Converter.Temperature.Tests.Extensions.From;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Types.Fahrenheit;
using Types.Gas;
using Types.Kelvin;
using Types.Rankine;
using Xunit;

public sealed class FromDoubleExtensionsTests : BaseFromExtensionTests<double, CelsiusDouble>
{
    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    protected override CelsiusDouble ConvertFrom(
        double value)
    {
        return value.FromCelsius();
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_returns_gas_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        GasDouble result = input.FromGas();

        // Assert.
        result.Should()
            .BeOfType<GasDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_gas_generic_returns_gas_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Gas>();

        // Assert.
        result.Should()
            .BeOfType<GasDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        KelvinDouble result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        RankineDouble result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
