using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0, 80)]
    [InlineData(150, 0)]
    public void Test_int_extension_from_delisle_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromDelisle().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
