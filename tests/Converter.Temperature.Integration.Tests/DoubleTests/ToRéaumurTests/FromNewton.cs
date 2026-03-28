using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRéaumurTests;

public class FromNewton
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(33, 80)]
    public void Test_double_extension_from_newton_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromNewton()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
