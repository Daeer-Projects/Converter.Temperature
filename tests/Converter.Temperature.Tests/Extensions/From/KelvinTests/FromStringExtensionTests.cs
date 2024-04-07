namespace Converter.Temperature.Tests.Extensions.From.KelvinTests;

using System.Globalization;
using FluentAssertions;
using Temperature.Extensions.From;
using Types.Kelvin;
using Xunit;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, KelvinString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override KelvinString ConvertFrom(
        string value)
    {
        return value.FromKelvin();
    }

    [Fact]
    public void Test_from_kelvin_returns_kelvin_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        KelvinString result = input.FromKelvin();

        // Assert.
        result.Should()
            .BeOfType<KelvinString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
