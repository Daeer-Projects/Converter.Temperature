using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToDelisleTests;

public class FromDelisle
{
    [Theory]
    [InlineData(float.MinValue)]
    [InlineData(0f)]
    [InlineData(float.MaxValue)]
    public void Test_float_extension_from_delisle_to_delisle_returns_correct_float_value(
        float value)
    {
        // Arrange.
        // Act.
        float result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }
}
