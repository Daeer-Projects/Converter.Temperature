using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Réaumur;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.DoubleTests.ToRéaumurTests;

public class FromKelvin
{
    [Theory]
    [InlineData(273.15, 0)]
    [InlineData(373.15, 80)]
    public void Test_double_extension_from_kelvin_to_réaumur_returns_correct_double_value(
        double input,
        double expected)
    {
        // Arrange.

        // Act.
        double result = input.FromKelvin()
            .ToRéaumur();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-12);
    }
}
