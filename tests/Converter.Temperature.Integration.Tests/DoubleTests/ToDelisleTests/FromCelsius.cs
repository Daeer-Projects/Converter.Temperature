using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToDelisleTests;

public class FromCelsius
{
    [Theory]
    [InlineData(0d, 150d)]
    [InlineData(100d, 0d)]
    [InlineData(-100d, 300d)]
    public void Test_double_extension_from_celsius_to_delisle_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.
        // Act.
        double result = input.FromCelsius()
            .ToDelisle();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
