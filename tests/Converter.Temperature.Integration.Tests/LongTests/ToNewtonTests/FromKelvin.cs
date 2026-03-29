using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests.ToNewtonTests;

public class FromKelvin
{
    [Theory]
    [InlineData(373L, 33L)]
    [InlineData(273L, 0L)]
    public void Test_long_extension_from_kelvin_to_newton_returns_correct_long_value(long input, long expected)
    {
        // Arrange.

        // Act.
        long result = input.FromKelvin().ToNewton();

        // Assert.
        result.Should().Be(expected);
    }
}
