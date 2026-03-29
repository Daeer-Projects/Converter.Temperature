using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToNewtonTests;

public class FromRankine
{
    [Theory]
    [InlineData(671.67f, 33.0f)]
    [InlineData(491.67f, 0.0f)]
    public void Test_float_extension_from_rankine_to_newton_returns_correct_float_value(float input, float expected)
    {
        // Arrange.

        // Act.
        float result = input.FromRankine().ToNewton();

        // Assert.
        result.Should().BeApproximately(expected, 0.01f);
    }
}
