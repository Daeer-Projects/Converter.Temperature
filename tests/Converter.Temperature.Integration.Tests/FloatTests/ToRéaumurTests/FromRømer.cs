using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToRéaumurTests;

public class FromRømer
{
    [Theory]
    [InlineData(7.5f, 0f)]
    [InlineData(60f, 80f)]
    public void Test_float_extension_from_rømer_to_réaumur_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRømer().ToRéaumur();

        // Assert.
        result.Should().BeApproximately(expected, 1e-4f);
    }
}
