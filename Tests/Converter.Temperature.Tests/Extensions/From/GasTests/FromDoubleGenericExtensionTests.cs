namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Gas;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, GasDouble>
{
    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    protected override GasDouble ConvertFrom(
        double value)
    {
        return value.From<Gas>() as GasDouble;
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
}
