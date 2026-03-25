using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Gas;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.GasTests;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, GasDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

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
