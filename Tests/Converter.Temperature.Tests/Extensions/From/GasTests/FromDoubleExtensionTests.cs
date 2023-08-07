namespace Converter.Temperature.Tests.Extensions.From.GasTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Gas;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, GasDouble>
{
    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    protected override GasDouble ConvertFrom(
        double value)
    {
        return value.FromGas();
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
}
