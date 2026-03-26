using System.Globalization;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Types.Rankine;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Tests.Extensions.From.RankineTests;

public sealed class FromStringExtensionTests : BaseFromExtensionTests<string, RankineString>
{
    public FromStringExtensionTests() : base(
        double.MaxValue.ToString(CultureInfo.InvariantCulture),
        "999.999",
        "0",
        "-999.999",
        double.MinValue.ToString(CultureInfo.InvariantCulture)) { }

    protected override RankineString ConvertFrom(
        string value)
    {
        return value.FromRankine();
    }

    [Fact]
    public void Test_from_rankine_returns_rankine_string_type()
    {
        // Arrange.
        const string input = "39";

        // Act.
        RankineString result = input.FromRankine();

        // Assert.
        result.Should()
            .BeOfType<RankineString>()
            .Which.Temperature.Should()
            .Be(input);
    }
}
