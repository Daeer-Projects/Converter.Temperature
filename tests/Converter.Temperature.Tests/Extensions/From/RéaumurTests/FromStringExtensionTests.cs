using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RéaumurTests;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, RéaumurString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString("R"),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString("R")) { }

    protected override RéaumurString ConvertFrom(
        string value)
    {
        return value.FromRéaumur();
    }

    [Fact]
    public void Test_from_réaumur_returns_réaumur_string_type()
    {
        // Arrange.
        const string input = "39.9";

        // Act.
        RéaumurString result = input.FromRéaumur();

        // Assert.
        result.Should()
            .BeOfType<RéaumurString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
