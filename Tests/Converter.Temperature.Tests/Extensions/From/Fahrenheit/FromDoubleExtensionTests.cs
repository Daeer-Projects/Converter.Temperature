﻿namespace Converter.Temperature.Tests.Extensions.From.Fahrenheit;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Fahrenheit;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, FahrenheitDouble>
{
    protected override FahrenheitDouble ConvertFrom(
        double value)
    {
        return value.FromFahrenheit();
    }

    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        FahrenheitDouble result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
