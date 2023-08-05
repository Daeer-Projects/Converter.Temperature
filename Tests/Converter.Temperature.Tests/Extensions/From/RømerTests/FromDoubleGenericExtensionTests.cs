namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using BaseTypes;
using Converter.Temperature.Extensions.From;
using TemperatureTypes;
using FluentAssertions;
using Types.Rømer;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, RømerDouble>
{
    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    protected override RømerDouble ConvertFrom(
        double value)
    {
        return value.From<Rømer>() as RømerDouble;
    }

    [Fact]
    public void Test_from_rømer_generic_returns_rømer_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Rømer>();

        // Assert.
        result.Should()
            .BeOfType<RømerDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
