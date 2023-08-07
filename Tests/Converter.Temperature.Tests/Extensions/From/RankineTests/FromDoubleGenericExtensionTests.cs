namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rankine;
using Xunit;

public sealed class FromDoubleGenericExtensionTests : BaseFromExtensionTests<double, RankineDouble>
{
    public FromDoubleGenericExtensionTests() : base(double.MaxValue, 999.999d, 0d, -999.999d, double.MinValue) { }

    protected override RankineDouble ConvertFrom(
        double value)
    {
        return value.From<Rankine>() as RankineDouble;
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        DoubleBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
