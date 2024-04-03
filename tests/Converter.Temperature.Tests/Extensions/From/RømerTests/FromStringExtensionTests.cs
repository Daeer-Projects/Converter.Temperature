namespace Converter.Temperature.Tests.Extensions.From.RømerTests;

using System.Globalization;
using FluentAssertions;
using Temperature.Extensions.From;
using Types.Rømer;
using Xunit;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, RømerString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override RømerString ConvertFrom(
        string value)
    {
        return value.FromRømer();
    }

    [Fact]
    public void Test_from_rømer_returns_rømer_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        RømerString result = input.FromRømer();

        // Assert.
        result.Should()
            .BeOfType<RømerString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
