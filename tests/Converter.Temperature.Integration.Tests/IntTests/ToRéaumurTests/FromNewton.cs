using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromNewton
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    public void Test_int_extension_from_newton_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromNewton().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
