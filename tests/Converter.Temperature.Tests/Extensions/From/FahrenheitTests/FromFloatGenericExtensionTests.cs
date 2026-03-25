using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromFloatGenericExtensionTests : BaseFromExtensionTests<float, FahrenheitFloat>
{
    public FromFloatGenericExtensionTests() : base(
        float.MaxValue,
        999.999f,
        0f,
        -999.999f,
        float.MinValue) { }

    protected override FahrenheitFloat ConvertFrom(
        float value)
    {
        return value.From<Fahrenheit>() as FahrenheitFloat;
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_float_type()
    {
        // Arrange.
        const float input = 39f;

        // Act.
        FloatBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitFloat>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
