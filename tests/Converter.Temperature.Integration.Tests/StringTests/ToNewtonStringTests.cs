using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To.Newton;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.StringTests;

public sealed class ToNewtonStringTests
{
    [Theory]
    [InlineData("100", "33")]
    [InlineData("0", "0")]
    public void Test_ToNewton_FromCelsius_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromCelsius().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("212", "33")]
    [InlineData("32", "0")]
    public void Test_ToNewton_FromFahrenheit_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromFahrenheit().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("373.15", "33")]
    [InlineData("273.15", "0")]
    public void Test_ToNewton_FromKelvin_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromKelvin().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("671.67", "33")]
    [InlineData("491.67", "0")]
    public void Test_ToNewton_FromRankine_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromRankine().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("60", "33")]
    [InlineData("7.5", "0")]
    public void Test_ToNewton_FromRømer_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromRømer().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("0", "33")]
    [InlineData("150", "0")]
    public void Test_ToNewton_FromDelisle_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromDelisle().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("33", "33")]
    [InlineData("0", "0")]
    public void Test_ToNewton_FromNewton_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromNewton().ToNewton();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData("80", "33")]
    [InlineData("0", "0")]
    public void Test_ToNewton_FromRéaumur_Returns_Correct_Value(string input, string expected)
    {
        // Act
        string result = input.FromRéaumur().ToNewton();

        // Assert
        result.Should().Be(expected);
    }
}
