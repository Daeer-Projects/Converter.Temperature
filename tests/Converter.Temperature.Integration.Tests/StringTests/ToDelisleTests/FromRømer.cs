using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToDelisleTests;

public class FromRømer
{
    [Theory]
    [InlineData("7.5", "150")]
    [InlineData("60", "0")]
    public void Test_string_extension_from_rømer_to_delisle_returns_correct_string_value(
        string input,
        string expected)
    {
        // Arrange.
        // Act.
        string result = input.FromRømer()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
