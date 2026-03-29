using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests.ToDelisleTests;

public class FromDelisle
{
    [Theory]
    [InlineData("0")]
    [InlineData("150")]
    public void Test_string_extension_from_delisle_to_delisle_returns_correct_string_value(
        string value)
    {
        // Arrange.
        // Act.
        string result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }
}
