using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToRéaumurTests;

public class FromRømer
{
    [Theory]
    [InlineData(7, -1)]
    [InlineData(60, 80)]
    public void Test_int_extension_from_rømer_to_réaumur_returns_correct_int_value(int input, int expected)
    {
        // Arrange.

        // Act.
        int result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().Be(expected);
    }
}
