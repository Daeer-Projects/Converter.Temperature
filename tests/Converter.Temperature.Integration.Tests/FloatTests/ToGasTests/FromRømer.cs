using System;
using Converter.Temperature.Extensions.From;
using Converter.Temperature.Extensions.To;
using Converter.Temperature.Extensions.To.Gas;
using Converter.Temperature.TemperatureTypes;
using FluentAssertions;
using Xunit;

namespace Converter.Temperature.Integration.Tests.FloatTests.ToGasTests;

public class FromRømer
{
    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_float_extensions_from_rømer_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.FromRømer()
            .ToGas();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Theory]
    [InlineData(49.5d, 0.25d)]
    [InlineData(67.35d, 0.25d)]
    [InlineData(67.875d, 0.5d)]
    [InlineData(77.85d, 0.5d)]
    [InlineData(78.375d, 1d)]
    [InlineData(83.1d, 1d)]
    [InlineData(83.625d, 2d)]
    [InlineData(88.35d, 2d)]
    [InlineData(88.875d, 3d)]
    [InlineData(98.85d, 3d)]
    [InlineData(99.375d, 4d)]
    [InlineData(104.1d, 4d)]
    [InlineData(104.63d, 5d)]
    [InlineData(109.35d, 5d)]
    [InlineData(109.88d, 6d)]
    [InlineData(117.23d, 6d)]
    [InlineData(117.75d, 7d)]
    [InlineData(125.1d, 7d)]
    [InlineData(125.63d, 8d)]
    [InlineData(130.35d, 8d)]
    [InlineData(130.88d, 9d)]
    [InlineData(135.6d, 9d)]
    [InlineData(136.13d, 10d)]
    [InlineData(148.73d, 10d)]
    public void Test_float_extensions_generic_from_rømer_to_gas_returns_correct_gas_value(
        float input,
        float expected)
    {
        // Arrange.
        // Act.
        float result = input.From<Rømer>()
            .To<Gas>();

        // Assert.
        result.Should()
            .BeApproximately(expected, 1e-4f);
    }

    [Fact]
    public void Test_float_extensions_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 48.975f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rømer_to_gas_with_low_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 48.975f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too low for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 149.25f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.FromRømer()
            .ToGas());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }

    [Fact]
    public void Test_float_extensions_generic_from_rømer_to_gas_with_high_invalid_value_throws_exception()
    {
        // Arrange.
        const float input = 149.25f;

        // Act.
        ArgumentOutOfRangeException result = Assert.Throws<ArgumentOutOfRangeException>(() => input.From<Rømer>()
            .To<Gas>());

        // Assert.
        result.Message.Should()
            .Contain("Temp too high for gas mark!");
    }
}
