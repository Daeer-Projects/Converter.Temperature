namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

using FluentAssertions;
using Temperature.Extensions.From;
using Types.Fahrenheit;
using Xunit;

public sealed class FromLongExtensionTests : BaseFromExtensionTests<long, FahrenheitLong>
{
    public FromLongExtensionTests() : base(
        long.MaxValue,
        999,
        0,
        -999,
        long.MinValue) { }

    protected override FahrenheitLong ConvertFrom(
        long value)
    {
        return value.FromFahrenheit();
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_long_type()
    {
        // Arrange.
        const long input = 39L;

        // Act.
        FahrenheitLong result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitLong>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
