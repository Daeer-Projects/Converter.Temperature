using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, RéaumurDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override RéaumurDouble ConvertFrom(
        double value)
    {
        return value.From<Réaumur>() as RéaumurDouble;
    }

    [Fact]
    public void Test_from_réaumur_generic_returns_réaumur_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Réaumur>();

        // Assert.
        result.Should()
            .BeOfType<RéaumurDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
