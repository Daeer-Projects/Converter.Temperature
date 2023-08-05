namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Kelvin;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, KelvinDouble>
{
    protected override double HighValue => double.MaxValue;
    protected override double MidHighValue => 999.999d;
    protected override double MidValue => 0d;
    protected override double MidLowValue => -999.999d;
    protected override double LowValue => double.MinValue;

    protected override KelvinDouble ConvertFrom(
        double value)
    {
        return value.FromKelvin();
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        KelvinDouble result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
