using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, RéaumurInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override RéaumurInt ConvertFrom(
        int value)
    {
        return value.From<Réaumur>() as RéaumurInt;
    }

    [Fact]
    public void Test_from_réaumur_generic_returns_réaumur_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Réaumur>();

        // Assert.
        result.Should()
            .BeOfType<RéaumurInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
