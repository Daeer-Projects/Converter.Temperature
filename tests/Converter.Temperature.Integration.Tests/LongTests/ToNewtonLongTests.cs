using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.LongTests;

public sealed class ToNewtonLongTests
{
    [Theory]
    [InlineData(100L, 33L)]
    [InlineData(0L, 0L)]
    [InlineData(-33L, -11L)]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromCelsius().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(212L, 33L)]
    [InlineData(32L, 0L)]
    public void Test_ToNewton_FromFahrenheit_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromFahrenheit().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(373L, 33L)]
    [InlineData(273L, 0L)]
    public void Test_ToNewton_FromKelvin_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromKelvin().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(672L, 33L)]
    [InlineData(492L, 0L)]
    public void Test_ToNewton_FromRankine_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromRankine().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(60L, 33L)]
    [InlineData(7L, 0L)]
    public void Test_ToNewton_FromRømer_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromRømer().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0L, 33L)]
    [InlineData(150L, 0L)]
    public void Test_ToNewton_FromDelisle_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromDelisle().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(33L, 33L)]
    [InlineData(0L, 0L)]
    public void Test_ToNewton_FromNewton_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromNewton().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(80L, 33L)]
    [InlineData(0L, 0L)]
    public void Test_ToNewton_FromRéaumur_Returns_Correct_Value(long input, long expected)
    {
        // Act
        long result = input.FromRéaumur().ToNewton();

        // Assert
        result.Should().Be(expected);
    }
}
