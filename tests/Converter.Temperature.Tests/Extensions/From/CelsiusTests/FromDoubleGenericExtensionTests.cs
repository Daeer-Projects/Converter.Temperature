namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, CelsiusDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override CelsiusDouble ConvertFrom(
        double value)
    {
        return value.From<Celsius>() as CelsiusDouble;
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
