namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Fahrenheit;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, FahrenheitDouble>
{
    public FromDoubleExtensionTests() : base(double.MaxValue, 999.999d, 0d, -999.999d, double.MinValue) { }

    protected override FahrenheitDouble ConvertFrom(
        double value)
    {
        return value.FromFahrenheit();
    }

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
