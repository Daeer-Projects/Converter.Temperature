using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromDelisle
{
    [Theory]
    [InlineData(long.MinValue)]
    [InlineData(0L)]
    [InlineData(long.MaxValue)]
    public void Test_long_extension_from_delisle_to_delisle_returns_correct_long_value(
        long value)
    {
        // Arrange.
        // Act.
        long result = value.FromDelisle()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(value);
    }
}
