using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Delisle;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToDelisleTests;

public class FromKelvin
{
    [Theory]
    [InlineData(273L, 150L)]
    [InlineData(373L, 0L)]
    public void Test_long_extension_from_kelvin_to_delisle_returns_correct_long_value(
        long input,
        long expected)
    {
        // Arrange.
        // Act.
        long result = input.FromKelvin()
            .ToDelisle();

        // Assert.
        result.Should()
            .Be(expected);
    }
}
