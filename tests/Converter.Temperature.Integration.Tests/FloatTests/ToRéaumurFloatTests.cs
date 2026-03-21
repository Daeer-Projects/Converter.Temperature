namespace Converter.Temperature.Integration.Tests.FloatTests;

using Extensions.From;
using Extensions.To;
using TemperatureTypes;
using FluentAssertions;
using Xunit;

public class ToRéaumurFloatTests
{
    [Theory]
    [InlineData(0f, 0f)]
    [InlineData(100f, 80f)]
    public void Test_ToRéaumur_FromCelsius_Returns_Correct_Value(float input, float expected)
    {
        // Arrange
        // Act
        var result = input.FromCelsius().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(32f, 0f)]
    [InlineData(212f, 80f)]
    public void Test_ToRéaumur_FromFahrenheit_Returns_Correct_Value(float input, float expected)
    {
        // Arrange
        // Act
        var result = input.FromFahrenheit().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Test_ToRéaumur_Generic_Returns_Correct_Value()
    {
        // Arrange
        const float input = 100f;
        const float expected = 80f;

        // Act
        var result = input.FromCelsius().To<Réaumur>();

        // Assert
        result.Should().Be(expected);
    }
}
