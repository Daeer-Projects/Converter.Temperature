namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Kelvin;
using Xunit;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, KelvinInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override KelvinInt ConvertFrom(
        int value)
    {
        return value.From<Kelvin>() as KelvinInt;
    }

    [Fact]
    public void Test_from_kelvin_generic_returns_kelvin_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Kelvin>();

        // Assert.
        result.Should()
            .BeOfType<KelvinInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
