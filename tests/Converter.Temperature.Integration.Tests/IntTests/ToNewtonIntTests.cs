using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests;

public sealed class ToNewtonIntTests
{
    [Theory]
    [InlineData(100, 33)]
    [InlineData(0, 0)]
    [InlineData(-33, -11)]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromCelsius().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(212, 33)]
    [InlineData(32, 0)]
    [InlineData(0, -6)]
    public void Test_ToNewton_FromFahrenheit_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromFahrenheit().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(373, 33)]
    [InlineData(273, 0)]
    public void Test_ToNewton_FromKelvin_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromKelvin().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(672, 33)]
    [InlineData(492, 0)]
    public void Test_ToNewton_FromRankine_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromRankine().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(60, 33)]
    [InlineData(7, 0)]
    public void Test_ToNewton_FromRømer_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromRømer().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, 33)]
    [InlineData(150, 0)]
    public void Test_ToNewton_FromDelisle_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromDelisle().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(33, 33)]
    [InlineData(0, 0)]
    public void Test_ToNewton_FromNewton_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromNewton().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(80, 33)]
    [InlineData(0, 0)]
    public void Test_ToNewton_FromRéaumur_Returns_Correct_Value(int input, int expected)
    {
        // Act
        int result = input.FromRéaumur().ToNewton();

        // Assert
        result.Should().Be(expected);
    }
}
