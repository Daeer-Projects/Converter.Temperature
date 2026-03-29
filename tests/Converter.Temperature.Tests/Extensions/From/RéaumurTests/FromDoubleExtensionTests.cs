using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromDoubleExtensionTests : BaseFromExtensionTests<double, RéaumurDouble>
{
    public FromDoubleExtensionTests() : base(
        double.MaxValue,
        999.999d,
        0d,
        -999.999d,
        double.MinValue) { }

    protected override RéaumurDouble ConvertFrom(
        double value)
    {
        return value.FromRéaumur();
    }

    [Fact]
    public void Test_from_réaumur_returns_réaumur_double_type()
    {
        // Arrange.
        const double input = 39d;

        // Act.
        RéaumurDouble result = input.FromRéaumur();

        // Assert.
        result.Should()
            .BeOfType<RéaumurDouble>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
