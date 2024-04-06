namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Kelvin;
using Xunit;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, KelvinDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

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
