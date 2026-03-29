using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromRéaumur
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(80, 80)]
    public void Test_int_extension_from_réaumur_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRéaumur().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
