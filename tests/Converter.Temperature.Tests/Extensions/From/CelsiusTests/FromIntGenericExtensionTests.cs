using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Celsius;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, CelsiusInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override CelsiusInt ConvertFrom(
        int value)
    {
        return value.From<Celsius>() as CelsiusInt;
    }

    [Fact]
    public void Test_from_celsius_generic_returns_celsius_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Celsius>();

        // Assert.
        result.Should()
            .BeOfType<CelsiusInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
