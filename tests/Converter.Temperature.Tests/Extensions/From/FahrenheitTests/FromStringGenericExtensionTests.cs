using System.Globalization;
using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Fahrenheit;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, FahrenheitString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override FahrenheitString ConvertFrom(
        string value)
    {
        return value.From<Fahrenheit>() as FahrenheitString;
    }

    [Fact]
    public void Test_from_fahrenheit_generic_returns_fahrenheit_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Fahrenheit>();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
