namespace Converter.Temperature.Tests.Extensions.From.CelsiusTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Celsius;
using Xunit;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, CelsiusInt>
{
    public FromIntGenericExtensionTests() : base(int.MaxValue, 999, 0, -999, int.MinValue) { }

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
