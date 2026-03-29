using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.DelisleTests;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, DelisleDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override DelisleDouble ConvertFrom(
        double value)
    {
        return value.From<Delisle>() as DelisleDouble;
    }

    [Fact]
    public void Test_from_delisle_generic_returns_delisle_double_type()
    {
        // Arrange.
        const double input = 39.9d;

        // Act.
        DoubleBase result = input.From<Delisle>();

        // Assert.
        result.Should()
            .BeOfType<DelisleDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
