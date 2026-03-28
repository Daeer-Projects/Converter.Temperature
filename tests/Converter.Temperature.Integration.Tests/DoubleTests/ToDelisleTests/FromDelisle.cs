using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToDelisleTests;

public class FromDelisle
{
    [Theory]
    [InlineData(double.MinValue)]
    [InlineData(0d)]
    [InlineData(double.MaxValue)]
    public void Test_double_extension_from_delisle_to_delisle_returns_correct_double_value(
        double value)
    {
        // Arrange.
        // Act.
        double result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }
}
