namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Kelvin;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, KelvinDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override KelvinDouble ConvertFrom(
        double value)
    {
        return value.From<Kelvin>() as KelvinDouble;
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
}
