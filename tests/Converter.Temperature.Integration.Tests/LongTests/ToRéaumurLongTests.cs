namespace Converter.Temperature.Integration.Tests.LongTests;

using Extensions.From;
using Extensions.To;
using TemperatureTypes;
using FluentAssertions;
using Xunit;

public class ToRéaumurLongTests
{
    [Theory]
    [InlineData(0L, 0L)]
    [InlineData(100L, 80L)]
    public void Test_ToRéaumur_FromCelsius_Returns_Correct_Value(long input, long expected)
    {
        // Arrange
        // Act
        var result = input.FromCelsius().ToRéaumur();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(32L, 0L)]
    [InlineData(212L, 80L)]
    public void Test_ToRéaumur_FromFahrenheit_Returns_Correct_Value(long input, long expected)
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
        const long input = 100L;
        const long expected = 80L;

        // Act
        var result = input.FromCelsius().To<Réaumur>();

        // Assert
        result.Should().Be(expected);
    }
}
