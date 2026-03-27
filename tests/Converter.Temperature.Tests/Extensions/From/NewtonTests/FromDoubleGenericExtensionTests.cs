using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Celsius;
using Converter.Temperature.Types.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.NewtonTests;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, NewtonDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override NewtonDouble ConvertFrom(
        double value)
    {
        return value.From<Newton>() as NewtonDouble;
    }

    [Fact]
    public void Test_from_newton_generic_returns_newton_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Newton>();

        // Assert.
        result.Should()
            .BeOfType<NewtonDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }

}
