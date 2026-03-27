using Converter.Temperature.BaseTypes;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.TemperatureTypes;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, RéaumurString>
{
    public FromStringGenericExtensionTests() : base(
        double.MaxValue.ToString("R"),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString("R")) { }

    protected override RéaumurString ConvertFrom(
        string value)
    {
        return value.From<Réaumur>() as RéaumurString;
    }

    [Fact]
    public void Test_from_réaumur_generic_returns_réaumur_string_type()
    {
        // Arrange.
        const string input = "39.9";

        // Act.
        StringBase result = input.From<Réaumur>();

        // Assert.
        result.Should()
            .BeOfType<RéaumurString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
