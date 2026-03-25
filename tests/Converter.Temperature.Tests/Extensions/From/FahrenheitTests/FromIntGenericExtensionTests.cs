using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromIntGenericExtensionTests : BaseFromExtensionTests<int, FahrenheitInt>
{
    public FromIntGenericExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override FahrenheitInt ConvertFrom(
        int value)
    {
        return value.From<Fahrenheit>() as FahrenheitInt;
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        IntBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
