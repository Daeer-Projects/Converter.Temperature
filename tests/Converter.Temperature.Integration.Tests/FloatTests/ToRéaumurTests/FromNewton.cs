using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRéaumurTests;

public class FromNewton
{
    [Theory]
    [InlineData(0f, 0f)]
    [InlineData(33f, 80f)]
    public void Test_float_extension_from_newton_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromNewton().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }
}
