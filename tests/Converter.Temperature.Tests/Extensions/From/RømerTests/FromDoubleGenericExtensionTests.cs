namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rømer;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, RømerDouble>
{
    public FromDoubleGenericExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

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
