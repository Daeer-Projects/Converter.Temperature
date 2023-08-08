namespace Converter.Temperature.Tests.Extensions.From.FahrenheitTests;

using System.Globalization;
using FluentAssertions;
using Temperature.Extensions.From;
using Types.Celsius;
using Types.Fahrenheit;
using Xunit;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, FahrenheitString>
{
    public FromStringExtensionTests() : base(double.MaxValue.ToString(CultureInfo.InvariantCulture), "999.999", "0", "-999.999", double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override FahrenheitString ConvertFrom(
        string value)
    {
        return value.FromFahrenheit();
    }

    [Fact]
    public void Test_from_fahrenheit_returns_fahrenheit_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        FahrenheitString result = input.FromFahrenheit();

        // Assert.
        result.Should()
            .BeOfType<FahrenheitString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
