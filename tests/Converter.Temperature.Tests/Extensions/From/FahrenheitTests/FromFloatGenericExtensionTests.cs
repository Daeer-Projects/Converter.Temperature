namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Fahrenheit;
using Xunit;

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
