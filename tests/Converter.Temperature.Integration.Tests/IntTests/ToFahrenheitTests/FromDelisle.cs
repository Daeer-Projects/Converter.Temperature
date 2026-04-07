using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Fahrenheit;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.IntTests.ToFahrenheitTests;

public class FromDelisle
{
    [Theory]
    [InlineData(300, -148)]
    [InlineData(150, 32)]
    [InlineData(0, 212)]
    public void Test_int_extensions_from_delisle_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.FromDelisle()
            .ToFahrenheit();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(300, -148)]
    [InlineData(150, 32)]
    [InlineData(0, 212)]
    public void Test_int_extensions_generic_from_delisle_to_fahrenheit_returns_correct_int_value(
        int input,
        int expected)
    {
        // Arrange.
        // Act.
        int result = input.From<Delisle>()
            .To<Fahrenheit>();

        // Assert.
        result.Should()
            .Be(expected);
    }

    [Fact]
    public void Test_delisle_to_fahrenheit_overflow_throws_exception()
    {
        // Arrange.
        // F = 212 - D * 1.2
        // If D is very negative, F will be very positive.
        const int input = int.MinValue;

        // Act.
        Func<int> action = () => input.FromDelisle().ToFahrenheit();

        // Assert.
        action.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }

    [Fact]
    public void Test_delisle_to_fahrenheit_underflow_throws_exception()
    {
        // Arrange.
        // If D is very positive, F will be very negative.
        const int input = int.MaxValue;

        // Act.
        Func<int> action = () => input.FromDelisle().ToFahrenheit();

        // Assert.
        action.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage("*Value out of range for type.*");
    }

    [Fact]
    public void Test_delisle_to_fahrenheit_near_boundary_does_not_throw()
    {
        // Arrange.
        // Max Int: 2,147,483,647
        // 212 - D * 1.2 = 2,147,483,647
        // -D * 1.2 = 2,147,483,435
        // D = -1,789,569,529.166...
        // Let's try D = -1,789,569,529
        const int input = -1789569529;

        // Act.
        int result = input.FromDelisle().ToFahrenheit();

        // Assert.
        // 212 - (-1789569529 * 1.2) = 212 + 2147483434.8 = 2147483646.8 -> 2147483647
        result.Should().Be(2147483647);
    }
}
