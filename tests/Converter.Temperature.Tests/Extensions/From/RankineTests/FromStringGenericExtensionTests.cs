namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

using System.Globalization;
using BaseTypes;
using FluentAssertions;
using Temperature.Extensions.From;
using TemperatureTypes;
using Types.Rankine;
using Xunit;

public sealed class FromStringGenericExtensionTests : BaseFromExtensionTests<string, RankineString>
{
    public FromStringGenericExtensionTests() : base(double.MaxValue.ToString(CultureInfo.InvariantCulture), "999.999", "0",
        "-999.999", double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override RankineString ConvertFrom(
        string value)
    {
        return value.From<Rankine>() as RankineString;
    }

    [Fact]
    public void Test_from_rankine_generic_returns_rankine_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        StringBase result = input.From<Rankine>();

        // Assert.
        result.Should()
            .BeOfType<RankineString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
