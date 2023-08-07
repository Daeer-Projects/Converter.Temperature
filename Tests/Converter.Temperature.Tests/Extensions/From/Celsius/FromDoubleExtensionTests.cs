﻿namespace Converter.Temperature.Tests.Extensions.From.Celsius;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, CelsiusDouble>
{
    protected override CelsiusDouble ConvertFrom(
        double value)
    {
        return value.FromCelsius();
    }

    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    [Fact]
    public void Test_from_celsius_returns_celsius_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        CelsiusDouble result = input.FromCelsius();

        // Assert.
        result.Should()
            .BeOfType<CelsiusDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
