namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Fahrenheit;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, FahrenheitDouble>
{
    public FromDoubleGenericExtensionTests() : base(double.MaxValue, 999.999d, 0d, -999.999d, double.MinValue) { }

    protected override FahrenheitDouble ConvertFrom(
        double value)
    {
        return value.From<Fahrenheit>() as FahrenheitDouble;
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
}
