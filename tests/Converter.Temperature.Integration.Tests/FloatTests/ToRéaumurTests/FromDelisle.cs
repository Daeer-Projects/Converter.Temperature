using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRéaumurTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0f, 80f)]
    [InlineData(150f, 0f)]
    public void Test_float_extension_from_delisle_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromDelisle().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }
}
