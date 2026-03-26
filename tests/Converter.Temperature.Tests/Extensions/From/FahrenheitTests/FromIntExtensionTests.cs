using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromIntExtensionTests : BaseFromExtensionTests<int, FahrenheitInt>
{
    public FromIntExtensionTests() : base(
        int.MaxValue,
        999,
        0,
        -999,
        int.MinValue) { }

    protected override FahrenheitInt ConvertFrom(
        int value)
    {
        return value.FromFahrenheit();
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_int_type()
    {
        // Arrange.
        const int input = 39;

        // Act.
        FahrenheitInt result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitInt>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
