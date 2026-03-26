using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromLongGenericExtensionTests : BaseFromExtensionTests<long, FahrenheitLong>
{
    public FromLongGenericExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override FahrenheitLong ConvertFrom(
        long value)
    {
        return value.From<Fahrenheit>() as FahrenheitLong;
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        LongBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
