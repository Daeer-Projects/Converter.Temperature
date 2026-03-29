using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToDelisleTests;

public class FromFahrenheit
{
    [Theory]
    [InlineData(32, 150)]
    [InlineData(212, 0)]
    public void Test_int_extension_from_fahrenheit_to_delisle_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromFahrenheit()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
