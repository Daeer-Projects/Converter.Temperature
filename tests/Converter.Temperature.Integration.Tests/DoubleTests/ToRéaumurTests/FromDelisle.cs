using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRéaumurTests;

public class FromDelisle
{
    [Theory]
    [InlineData(0, 80)]
    [InlineData(150, 0)]
    public void Test_double_extension_from_delisle_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromDelisle()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
