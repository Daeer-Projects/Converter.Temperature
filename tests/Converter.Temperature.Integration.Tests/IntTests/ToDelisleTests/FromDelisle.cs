using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromDelisle
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(0)]
    [InlineData(int.MaxValue)]
    public void Test_int_extension_from_delisle_to_delisle_returns_correct_int_value(
        int value)
    {
        // Arrange.
        // Act.
        int result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }
}
