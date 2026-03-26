using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Kelvin;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, KelvinInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override KelvinInt ConvertFrom(
        int value)
    {
        return value.FromKelvin();
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        KelvinInt result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
