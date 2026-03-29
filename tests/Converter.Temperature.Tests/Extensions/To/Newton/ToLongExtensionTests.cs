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

public sealed class ToLongExtensionTests : BaseToExtensionTests<NewtonLong, long>
{
    public ToLongExtensionTests() : base(999L, GetData()) { }

    private static List<long> GetData()
    {
        return [999L, 0L, -999L];
    }

    protected override long To(
        NewtonLong value,
        int fractionalCount)
    {
        return value.ToNewton();
    }

    protected override long ToUsingGeneric(
        NewtonLong value,
        int fractionalCount)
    {
        return value.To<TemperatureTypes.Newton>();
    }

    protected override NewtonLong Create(
        long value)
    {
        return new NewtonLong(value);
    }

    [Fact]
    public void Test_to_newton_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        CelsiusLong input = new(100L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_generic_from_celsius_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        CelsiusLong input = new(100L);

        // Act.
        long result = input.To<TemperatureTypes.Newton>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_delisle_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        DelisleLong input = new(0L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_fahrenheit_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        FahrenheitLong input = new(212L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_gas_returns_correct_value()
    {
        // Arrange.
        const long expected = 76L;
        GasLong input = new(7L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_kelvin_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        KelvinLong input = new(373L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rankine_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        RankineLong input = new(671L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_réaumur_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        RéaumurLong input = new(80L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_to_newton_from_rømer_returns_correct_value()
    {
        // Arrange.
        const long expected = 33L;
        RømerLong input = new(60L);

        // Act.
        long result = input.ToNewton();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
