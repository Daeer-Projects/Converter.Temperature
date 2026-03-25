using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromFloatExtensionTests : BaseFromExtensionTests<float, FahrenheitFloat>
{
    public FromFloatExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override FahrenheitFloat ConvertFrom(
        float value)
    {
        return value.FromFahrenheit();
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FahrenheitFloat result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
